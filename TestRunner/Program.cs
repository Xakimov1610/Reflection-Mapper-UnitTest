using System.Reflection;
using TestRunner.TestAttributes;

var testClasses = typeof(Program).Assembly.GetTypes()
    .Where(p => p.GetCustomAttribute(typeof(MyTestClass)) != null);

foreach (var testClass in testClasses)
    Console.WriteLine(testClass.FullName);
