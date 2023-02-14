using TestRunner.TestAttributes;

namespace TestRunner;

[MyTestClass]
public class LogicServiceTest
{
    public void AddMethodTest()
    {
        var logic = new LogicService();
        var a = logic.Add(1, 2);

        Console.WriteLine(a == 3);
    }
}

[MyTestClass]
public class LogicServiceTest2
{
    public void AddMethodTest2()
    {
        var logic = new LogicService();
        var a = logic.Add(1, 2);

        Console.WriteLine(a == 3);
    }
}
