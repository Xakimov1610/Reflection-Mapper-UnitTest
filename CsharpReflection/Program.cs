using System.Reflection;
using Models;

var user = new User();
user.Name= "Test";
user.SetName("Mike");

Console.WriteLine(user.Name);

var userType = user.GetType();
Console.WriteLine(userType.FullName);

PropertyInfo userProperty = userType.GetProperty("Name");
//user.Name = "vali";
userProperty!.SetValue(user, "newVali");

Console.WriteLine(userProperty!.GetValue(user));

MethodInfo method = userType.GetMethods().Where(m => m.Name == "SetName").First();
method.Invoke(user, new []{"vali"} );

Console.WriteLine(userProperty!.GetValue(user));

namespace Models
{
    public class User
    {
        public string? Name { get; set; }

        public void SetName(string name) => Name = name;
    }
}
