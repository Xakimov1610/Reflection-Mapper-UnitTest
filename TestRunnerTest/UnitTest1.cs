using TestRunner;

namespace TestRunnerTest;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var logic = new LogicService();
        var a = logic.Add(1,2);

        Console.WriteLine(a == 3);
    }
}