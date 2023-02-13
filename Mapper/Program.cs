using Mapper;

var user = new User()
{
    Id = 1,
    Name = "Test",
    Email = "e@s.com"
};

var userDto = new UserDTO();

userDto.Email = user.Email;
userDto.Name = user.Name;

var userType = user.GetType();
var properties = userType.GetProperties();

var userDtoType = userDto.GetType();
var userDtoProperties = userDtoType.GetProperties();

foreach (var propertyInfo in properties)
{
    Console.WriteLine(propertyInfo.Name);
}

foreach (var dtoPropertyInfo in userDtoProperties)
{
    Console.WriteLine(dtoPropertyInfo.Name);
}
