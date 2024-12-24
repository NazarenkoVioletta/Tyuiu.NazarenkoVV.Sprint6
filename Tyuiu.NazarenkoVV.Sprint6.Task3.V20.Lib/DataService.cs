using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NazarenkoVV.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rowss = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rowss;

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < rowss; j++)
                {
                    if (i == 4 && matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}