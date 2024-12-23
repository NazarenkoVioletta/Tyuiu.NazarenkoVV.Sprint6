﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NazarenkoVV.Sprint6.Task1.V10.Lib;

namespace Tyuiu.NazarenkoVV.Sprint6.Task1.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_NVV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_NVV.Text);
                int end = Convert.ToInt32(textBoxEnd_NVV.Text);

                string strLine;

                int len = ds.GetMassFunction(start, end).Length;

                double[] res = new double[len];
                res = ds.GetMassFunction(start, end);

                textBoxOutPut_NVV.Text = "";
                textBoxOutPut_NVV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxOutPut_NVV.AppendText("+    x     +   f(x)   +" + Environment.NewLine);
                textBoxOutPut_NVV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}  |", start, res[i]);
                    textBoxOutPut_NVV.AppendText(strLine + Environment.NewLine);
                    start++;
                }
                textBoxOutPut_NVV.AppendText("+----------+----------+");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_NVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск1 выполнил студент группы ИСПБ-24-1 Назаренко Виолетта Вячеславовна", "Сообщение");
        }
    }
}
