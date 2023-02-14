using Mapper;

var user = new User() { Id = 1, Name = "Test12", Email = "21e@s.com" };

var userDto = new UserDTO();

userDto = user.MapTo<UserDTO>();

Console.WriteLine(userDto.Name);
Console.WriteLine(userDto.Email);

var userView = user.MapTo<UserView>();

Console.WriteLine(userView.Id);
Console.WriteLine(userView.Email);

