using System.Reflection;
using TestRunner.TestAttributes;

var testClasses = typeof(Program).Assembly.GetTypes()
    .Where(p => p.GetCustomAttribute(typeof(MyTestClass)) != null);

foreach (var testClass in testClasses)
    Console.WriteLine(testClass.FullName);


foreach(Type testClass in testClasses)
{
    var testClassObj = Activator.CreateInstance(testClass);

    var testMethods = testClass.GetMethods()
        .Where(method => method.GetCustomAttribute(typeof(MyTestMethod)) != null);
}