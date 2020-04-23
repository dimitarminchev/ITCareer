namespace MiniORM
{
	using System;
	using System.Linq;
	using System.Reflection;

	internal static class ReflectionHelper
	{
		/// <summary>
		/// Replaces an auto-generated backing field with an object instance.
		/// Commonly used to set properties without a setter.
		/// </summary>
		public static void ReplaceBackingField(object sourceObj, string propertyName, object targetObj)
		{
			var backingField = sourceObj.GetType()
				.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetField)
				.First(fi => fi.Name == $"<{propertyName}>k__BackingField");

			backingField.SetValue(sourceObj, targetObj);
		}

		/// <summary>
		/// Extension method for MemberInfo, which checks if a member contains an attribute.
		/// </summary>
		public static bool HasAttribute<T>(this MemberInfo mi)
			where T : Attribute
		{
			var hasAttribute = mi.GetCustomAttribute<T>() != null;
			return hasAttribute;
		}
	}
}