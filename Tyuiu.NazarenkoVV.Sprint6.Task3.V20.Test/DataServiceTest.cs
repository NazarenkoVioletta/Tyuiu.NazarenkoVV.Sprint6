using Tyuiu.NazarenkoVV.Sprint6.Task3.V20.Lib;
namespace Tyuiu.NazarenkoVV.Sprint6.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { {-14, 17, -19, 3, 2},
                                         { -4,-14,-19, -9, -1},
                                         {   1,  0, 13, 14, 8},
                                         { 13, 7, 8,  -3, -15},
                                         {2, -20, 12, -14, 4 }};
            int[,] res = ds.Calculate(mas2);
            int[,] wait = { {-14, 17, -19, 3, 2},
                            { -4,-14,-19, -9, -1},
                            {   1,  0, 13, 14, 8},
                            { 13, 7, 8,  -3, -15},
                            { 0, 0, 0, 0, 0 }};
            CollectionAssert.AreEqual(wait, res);

        }
    }
}