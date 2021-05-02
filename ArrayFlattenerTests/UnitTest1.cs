using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayFlattenerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var values = new[]
            {
                new[] { 1,2 },
                new[] { 3 },
                new[] { 4 }
            };
            //IntArrayFlattener.Flattener.Main(values.ToString());
        }
    }
}
