using System;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Tyuiu.NazarenkoVV.Sprint6.Task2.V19;
partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        object value = base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        groupBoxTask_NVV = new GroupBox();
        pictureBoxFormula_NVV = new PictureBox();
        textBoxTask_NVV = new TextBox();
        groupBoxEnter_NVV = new GroupBox();
        labelVarEnd_NVV = new Label();
        labelVarStart_NVV = new Label();
        textBoxVarEnd_NVV = new TextBox();
        textBoxVarStart_NVV = new TextBox();
        buttonHelp_NVV = new Button();
        buttonResult_NVV = new Button();
        groupBoxResult_NVV = new GroupBox();
        chartResult_NVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
        labelResult_NVV = new Label();
        dataGridViewResult_NVV = new DataGridView();
        X = new DataGridViewTextBoxColumn();
        F = new DataGridViewTextBoxColumn();
        groupBoxTask_NVV.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NVV).BeginInit();
        groupBoxEnter_NVV.SuspendLayout();
        groupBoxResult_NVV.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chartResult_NVV).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NVV).BeginInit();
        SuspendLayout();
        // 
        // groupBoxTask_NVV
        // 
        groupBoxTask_NVV.Controls.Add(pictureBoxFormula_NVV);
        groupBoxTask_NVV.Controls.Add(textBoxTask_NVV);
        groupBoxTask_NVV.Location = new Point(12, 12);
        groupBoxTask_NVV.Name = "groupBoxTask_NVV";
        groupBoxTask_NVV.Size = new Size(556, 243);
        groupBoxTask_NVV.TabIndex = 1;
        groupBoxTask_NVV.TabStop = false;
        groupBoxTask_NVV.Text = "Условие";
        // 
        // pictureBoxFormula_NVV
        // 
        pictureBoxFormula_NVV.Image = Properties.Resources.FormulaTask2V19;
        pictureBoxFormula_NVV.Location = new Point(248, 31);
        pictureBoxFormula_NVV.Name = "pictureBoxFormula_NVV";
        pictureBoxFormula_NVV.Size = new Size(298, 37);
        pictureBoxFormula_NVV.TabIndex = 1;
        pictureBoxFormula_NVV.TabStop = false;
        // 
        // textBoxTask_NVV
        // 
        textBoxTask_NVV.Location = new Point(16, 31);
        textBoxTask_NVV.Multiline = true;
        textBoxTask_NVV.Name = "textBoxTask_NVV";
        textBoxTask_NVV.ReadOnly = true;
        textBoxTask_NVV.Size = new Size(224, 138);
        textBoxTask_NVV.TabIndex = 0;
        textBoxTask_NVV.TabStop = false;
        textBoxTask_NVV.Text = "Протабулировать функцию f(x) на заданном промежутке [-5,5].\r\nРезультат вывести в DataGridView и построить график.";
        // 
        // groupBoxEnter_NVV
        // 
        groupBoxEnter_NVV.Controls.Add(labelVarEnd_NVV);
        groupBoxEnter_NVV.Controls.Add(labelVarStart_NVV);
        groupBoxEnter_NVV.Controls.Add(textBoxVarEnd_NVV);
        groupBoxEnter_NVV.Controls.Add(textBoxVarStart_NVV);
        groupBoxEnter_NVV.Location = new Point(12, 261);
        groupBoxEnter_NVV.Name = "groupBoxEnter_NVV";
        groupBoxEnter_NVV.Size = new Size(273, 100);
        groupBoxEnter_NVV.TabIndex = 2;
        groupBoxEnter_NVV.TabStop = false;
        groupBoxEnter_NVV.Text = "Ввод данных";
        // 
        // labelVarEnd_NVV
        // 
        labelVarEnd_NVV.AutoSize = true;
        labelVarEnd_NVV.Location = new Point(140, 30);
        labelVarEnd_NVV.Name = "labelVarEnd_NVV";
        labelVarEnd_NVV.Size = new Size(75, 15);
        labelVarEnd_NVV.TabIndex = 3;
        labelVarEnd_NVV.Text = "Конец шага:";
        // 
        // labelVarStart_NVV
        // 
        labelVarStart_NVV.AutoSize = true;
        labelVarStart_NVV.Location = new Point(16, 30);
        labelVarStart_NVV.Name = "labelVarStart_NVV";
        labelVarStart_NVV.Size = new Size(72, 15);
        labelVarStart_NVV.TabIndex = 2;
        labelVarStart_NVV.Text = "Старт шага:";
        // 
        // textBoxVarEnd_NVV
        // 
        textBoxVarEnd_NVV.Location = new Point(140, 61);
        textBoxVarEnd_NVV.Name = "textBoxVarEnd_NVV";
        textBoxVarEnd_NVV.Size = new Size(100, 23);
        textBoxVarEnd_NVV.TabIndex = 1;
        textBoxVarEnd_NVV.Text = "5";
        // 
        // textBoxVarStart_NVV
        // 
        textBoxVarStart_NVV.Location = new Point(16, 61);
        textBoxVarStart_NVV.Name = "textBoxVarStart_NVV";
        textBoxVarStart_NVV.Size = new Size(100, 23);
        textBoxVarStart_NVV.TabIndex = 0;
        textBoxVarStart_NVV.Text = "-5";
        // 
        // buttonHelp_NVV
        // 
        buttonHelp_NVV.BackColor = Color.CornflowerBlue;
        buttonHelp_NVV.ForeColor = SystemColors.ControlText;
        buttonHelp_NVV.Location = new Point(306, 306);
        buttonHelp_NVV.Name = "buttonHelp_NVV";
        buttonHelp_NVV.Size = new Size(102, 53);
        buttonHelp_NVV.TabIndex = 6;
        buttonHelp_NVV.Text = "Справка";
        buttonHelp_NVV.UseVisualStyleBackColor = false;
        buttonHelp_NVV.Click += buttonHelp_Click;
        // 
        // buttonResult_NVV
        // 
        buttonResult_NVV.BackColor = Color.Green;
        buttonResult_NVV.Location = new Point(423, 306);
        buttonResult_NVV.Name = "buttonResult_NVV";
        buttonResult_NVV.Size = new Size(135, 53);
        buttonResult_NVV.TabIndex = 5;
        buttonResult_NVV.Text = "Выполнить";
        buttonResult_NVV.UseVisualStyleBackColor = false;
        buttonResult_NVV.Click += buttonResult_Click;
        buttonResult_NVV.MouseDown += buttonResult_MouseDown;
        buttonResult_NVV.MouseEnter += buttonResult_MouseEnter;
        buttonResult_NVV.MouseLeave += buttonResult_MouseLeave;
        // 
        // groupBoxResult_NVV
        // 
        groupBoxResult_NVV.Controls.Add(chartResult_NVV);
        groupBoxResult_NVV.Controls.Add(labelResult_NVV);
        groupBoxResult_NVV.Controls.Add(dataGridViewResult_NVV);
        groupBoxResult_NVV.Location = new Point(583, 12);
        groupBoxResult_NVV.Name = "groupBoxResult_NVV";
        groupBoxResult_NVV.Size = new Size(642, 347);
        groupBoxResult_NVV.TabIndex = 7;
        groupBoxResult_NVV.TabStop = false;
        groupBoxResult_NVV.Text = "Вывод данных";
        // 
        // chartResult_NVV
        // 
        chartArea1.Name = "ChartAreaResult_NVV";
        chartResult_NVV.ChartAreas.Add(chartArea1);
        legend1.Name = "Legend1";
        chartResult_NVV.Legends.Add(legend1);
        chartResult_NVV.Location = new Point(193, 41);
        chartResult_NVV.Name = "chartResult_NVV";
        series1.ChartArea = "ChartAreaResult_NVV";
        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        series1.IsVisibleInLegend = false;
        series1.Legend = "Legend1";
        series1.Name = "Series1";
        chartResult_NVV.Series.Add(series1);
        chartResult_NVV.Size = new Size(443, 292);
        chartResult_NVV.TabIndex = 2;
        chartResult_NVV.Text = "Таблица";
        // 
        // labelResult_NVV
        // 
        labelResult_NVV.AutoSize = true;
        labelResult_NVV.Location = new Point(6, 19);
        labelResult_NVV.Name = "labelResult_NVV";
        labelResult_NVV.Size = new Size(63, 15);
        labelResult_NVV.TabIndex = 1;
        labelResult_NVV.Text = "Результат:";
        // 
        // dataGridViewResult_NVV
        // 
        dataGridViewResult_NVV.AllowUserToResizeColumns = false;
        dataGridViewResult_NVV.AllowUserToResizeRows = false;
        dataGridViewResult_NVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewResult_NVV.Columns.AddRange(new DataGridViewColumn[] { X, F });
        dataGridViewResult_NVV.Location = new Point(6, 41);
        dataGridViewResult_NVV.Name = "dataGridViewResult_NVV";
        dataGridViewResult_NVV.RowHeadersVisible = false;
        dataGridViewResult_NVV.Size = new Size(155, 292);
        dataGridViewResult_NVV.TabIndex = 0;
        // 
        // X
        // 
        X.HeaderText = "X";
        X.Name = "X";
        X.Width = 50;
        // 
        // F
        // 
        F.FillWeight = 50F;
        F.HeaderText = "F(X)";
        F.Name = "F";
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1250, 379);
        Controls.Add(groupBoxResult_NVV);
        Controls.Add(buttonHelp_NVV);
        Controls.Add(buttonResult_NVV);
        Controls.Add(groupBoxEnter_NVV);
        Controls.Add(groupBoxTask_NVV);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт 6 | Таск 2 | Вариант 19 | Назаренко В. В.";
        groupBoxTask_NVV.ResumeLayout(false);
        groupBoxTask_NVV.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NVV).EndInit();
        groupBoxEnter_NVV.ResumeLayout(false);
        groupBoxEnter_NVV.PerformLayout();
        groupBoxResult_NVV.ResumeLayout(false);
        groupBoxResult_NVV.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)chartResult_NVV).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NVV).EndInit();
        ResumeLayout(false);
    }

    private void ResumeLayout(bool v)
    {
        throw new NotImplementedException();
    }

    #endregion

    private GroupBox groupBoxTask_NVV;
    private PictureBox pictureBoxFormula_NVV;
    private TextBox textBoxTask_NVV;
    private GroupBox groupBoxEnter_NVV;
    private Label labelVarEnd_NVV;
    private Label labelVarStart_NVV;
    private TextBox textBoxVarEnd_NVV;
    private TextBox textBoxVarStart_NVV;
    private Button buttonHelp_NVV;
    private Button buttonResult_NVV;
    private GroupBox groupBoxResult_NVV;
    private DataGridView dataGridViewResult_NVV;
    private DataGridViewTextBoxColumn X;
    private DataGridViewTextBoxColumn F;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_NVV;
    private Label labelResult_NVV;
}



