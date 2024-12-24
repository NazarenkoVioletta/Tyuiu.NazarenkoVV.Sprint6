using Tyuiu.NazarenkoVV.Sprint6.Task2.V19.Lib;
namespace Tyuiu.NazarenkoVV.Sprint6.Task2.V19
{
    public partial class FromMain : Form
    {

        public FromMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_NVV.Text);
                int stopStep = Convert.ToInt32(textBoxVarEnd_NVV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                double[] xData = new double[len];
                double[] yData = new double[len];

                for (int i = 0; i < len; i++)
                {
                    xData[i] = startStep + i;
                    yData[i] = valueArray[i];
                }

                this.chartResult_NVV.Titles.Clear();
                this.chartResult_NVV.Series[0].Points.Clear();
                this.chartResult_NVV.Titles.Add("График функции F(x)");
                this.chartResult_NVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_NVV.ChartAreas[0].AxisY.Title = "Ось Y";
                chartResult_NVV.Refresh();
                this.dataGridViewResult_NVV.Rows.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_NVV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult_NVV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Неверно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСПб-24-1 Назаренко В.В.", "Справка");
        }
        private void buttonResult_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_NVV.BackColor = Color.Blue;
        }

        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_NVV.BackColor = Color.Red;
        }

        private void buttonResult_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_NVV.BackColor = Color.Green;
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(7, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 87);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапозоне. Резальтат вывести в DataGridView и построить график функций\r\n\r\n\r\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(5, 236);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 169);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(5, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 27);
            textBox2.TabIndex = 0;
            textBox2.Text = "Старт шага";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(168, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 27);
            textBox3.TabIndex = 1;
            textBox3.Text = "Конец шага";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 108);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 27);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(164, 108);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 27);
            textBox5.TabIndex = 3;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(388, 33);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 137);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(textBox6);
            groupBox4.Location = new Point(626, 11);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(394, 397);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ввод данных";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(4, 30);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(147, 27);
            textBox6.TabIndex = 0;
            textBox6.Text = "Результат";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(3, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(199, 324);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // FromMain
            // 
            ClientSize = new Size(1029, 417);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FromMain";
            Text = "Спринт6 | Таск 2 | Вариант 19 | Назаренко В. В.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox textBox6;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

