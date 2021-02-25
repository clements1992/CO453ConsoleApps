using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            
            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1;
            converter.CalculateDistance();

            double expectedDistance = 3.28084;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}
