namespace Mapper;

public static class Converter
{
    public static T MapTo<T>(this object obj) where T : class, new()
    {
        var objType = obj.GetType();
        var properties = objType.GetProperties();

        var dtoType = typeof(T);
        var dtoProperties = dtoType.GetProperties();

        var dto = new T();
        //var dto = Activator.CreateInstance(dtoType);

        foreach (var propertyInfo in properties)
        {
            if (dtoProperties.Any(p => p.Name == propertyInfo.Name))
            {
                var userDtoProperty = dtoType.GetProperty(propertyInfo.Name);
                var value = propertyInfo.GetValue(obj);

                userDtoProperty!.SetValue(dto, value);
            }
        }

        return dto;
    }
}
