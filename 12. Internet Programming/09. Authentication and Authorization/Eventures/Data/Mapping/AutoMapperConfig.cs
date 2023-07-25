using System;
using System.Linq;
using AutoMapper;

namespace Eventures.Data.Mapping
{
    public class AutoMapperConfig
    {
        private static bool isInitialized;

        public static void ConfigureMapping()
        {
            if (isInitialized)
            {
                return;
            }

            isInitialized = true;

            var allTypes = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Where(a => a.GetName().FullName.Contains(nameof(Eventures)))
                .SelectMany(a => a.GetTypes())
                .ToArray();

            var allMappingTypes = allTypes
                .Where(t => t.IsClass
                            && !t.IsAbstract
                            && t.GetInterfaces()
                                .Where(i => i.IsGenericType)
                                .Select(i => i.GetGenericTypeDefinition())
                                .Contains(typeof(IMapWith<>)))
                .Select(t => new
                {
                    Type1 = t,
                    Type2 = t.GetInterfaces()
                        .Where(i => i.IsGenericType)
                        .Select(i => new
                        {
                            Definition = i.GetGenericTypeDefinition(),
                            Arguments = i.GetGenericArguments()
                        })
                        .Where(i => i.Definition == typeof(IMapWith<>))
                        .SelectMany(i => i.Arguments)
                        .First()
                })
                .ToList();

            Mapper.Initialize(config =>
            {
                foreach (var type in allMappingTypes)
                {
                    config.CreateMap(type.Type1, type.Type2);
                    config.CreateMap(type.Type2, type.Type1);
                }

                allTypes
                    .Where(t => t.IsClass
                                && !t.IsAbstract
                                && typeof(IHaveCustomMapping).IsAssignableFrom(t))
                    .Select(Activator.CreateInstance)
                    .Cast<IHaveCustomMapping>()
                    .ToList()
                    .ForEach(mapping => mapping.ConfigureMapping(config));
            });
        }
    }
}
