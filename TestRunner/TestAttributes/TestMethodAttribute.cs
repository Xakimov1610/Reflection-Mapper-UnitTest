namespace TestRunner.TestAttributes;

[AttributeUsage(AttributeTargets.Method , AllowMultiple = true)]
public class MyTestMethod : Attribute
{
}
