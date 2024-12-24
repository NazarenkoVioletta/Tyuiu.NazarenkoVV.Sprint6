using System.Drawing.Drawing2D;
using Tyuiu.NazarenkoVV.Sprint6.Task3.V20.Lib;
namespace Tyuiu.NazarenkoVV.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { {-14, 17, -19, 3, 2},
                                         { -4,-14,-19, -9, -1},
                                         {   1,  0, 13, 14, 8},
                                         { 13, 7, 8,  -3, -15},
                                         {2, -20, 12, -14, 4 }};
        private void FormMain_Load(object sender, EventArgs e)
        {
            int r = mtrx.GetUpperBound(0) + 1;
            int c = mtrx.Length / r;
            dataGridViewMtrx_NVV.ColumnCount = c;
            dataGridViewMtrx_NVV.RowCount = r;
            for (int i = 0; i < c; i++)
            {
                dataGridViewMtrx_NVV.Columns[i].Width = 25;
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    dataGridViewMtrx_NVV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_NVV_Click(object sender, EventArgs e)
        {
            int[,] ResultMatrix = ds.Calculate(mtrx);

            int rows = ResultMatrix.GetUpperBound(0) + 1;
            int columns = ResultMatrix.Length / rows;

            dataGridViewResultMatrix.ColumnCount = columns;
            dataGridViewResultMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResultMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResultMatrix.Rows[i].Cells[j].Value = Convert.ToString(ResultMatrix[i, j]);
                }
            }
        }

        private void buttonHelp_NVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 3 âûïîëíèëà ñòóäåíòêà ãðóïïû ÑÌÀÐÒá-24-1 Áàáàé Êñåíèÿ Âèòàëüåâíà", "Ñîîáùåíèå", MessageBoxButtons.OK);
        }


    }
}
