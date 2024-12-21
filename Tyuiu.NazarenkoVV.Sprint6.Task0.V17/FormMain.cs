namespace Tyuiu.NazarenkoVV.Sprint6.Task0.V17
{
    using Tyuiu.NazarenkoVV.Sprint6.Task0.V17.Lib;

    
        public partial class FormMain : Form
        {
            public FormMain()
            {
                InitializeComponent();
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void executeButton_SMA_Click(object sender, EventArgs e)
            {
                DataService ds = new DataService();
                try
                {
                    resultTextBox_SMA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(xinputBox_SMA.Text)));
                }
                catch
                {
                    MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void xinputBox_SMA_KeyPress(object sender, KeyPressEventArgs e)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
                {
                    e.Handled = true;
                }
            }

            private void xinputBox_SMA_TextChanged(object sender, EventArgs e)
            {

            }

            private void aboutButton_SMA_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÐÏÏá-24-1 Ñèìîíîâ Ìèõàèë Àëåêñååâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK);
            }
        }
    }