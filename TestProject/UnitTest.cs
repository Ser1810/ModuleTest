using ModuleTest;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var a = 1;
            var b = 2;
            var c = 0;
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            quadraticEquation.Solve(a, b, c);
        }
    }
}