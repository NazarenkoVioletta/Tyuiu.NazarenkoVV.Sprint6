using Tyuiu.NazarenkoVV.Sprint6.Task5.V21.Lib;

namespace Tyuiu.NazarenkoVV.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {

        string path = @"C:\Users\Vivobook\source\repos\Tyuiu.NazarenkoVV.Sprint6\Tyuiu.NazarenkoVV.Sprint6.Task5.V21.Lib\bin\Debug\net8.0\InPutFileTask5V21.txt";
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                this.chartOut.ChartAreas[0].AxisX.Title = "Îñü Õ";
                this.chartOut.ChartAreas[0].AxisY.Title = "Îñü Y";

                chartOut.Series[0].Points.Clear();

                dataGridViewNums.ColumnCount = 2;
                dataGridViewNums.Columns[0].Width = 20;
                dataGridViewNums.Columns[1].Width = 50;

                double[] numMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numMass.Length; i++)
                {
                    dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                    chartOut.Series[0].Points.AddXY(i, numMass[i]);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Ïðîèçîøëà îøèáêà.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ïðîèçîøëà îøèáêà: {ex.Message}");
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 5 âûïîëíèë ñòóäåíò ãðóïïû ÀÑÎèÓÁ-24-1 Ñàôîíîâ Ðóñëàí Âàñèëüåâè÷", "Cîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


