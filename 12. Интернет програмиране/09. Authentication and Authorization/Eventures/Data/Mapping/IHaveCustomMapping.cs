using AutoMapper;

namespace Eventures.Data
{
    public interface IHaveCustomMapping
    {
        void ConfigureMapping(IMapperConfigurationExpression mapper);
    }
}
