namespace Common.Net8.Extensions;

public static class GenericTypeExtensions
{
    public static string GetGenericTypeName(this object @object)
    {
        var type = @object.GetType();
        if (!type.IsGenericType)
            return type.Name;

        var genericTypes = string.Join(",", type.GetGenericArguments().Select(t => t.Name).ToArray());
        return $"{type.Name.Remove(type.Name.IndexOf('`'))}<{genericTypes}>";
    }
}