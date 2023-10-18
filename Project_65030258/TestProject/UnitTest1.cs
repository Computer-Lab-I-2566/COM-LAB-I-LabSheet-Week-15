  using Project_65030258;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Project.Members)).Length == 3);
        }
    }
}