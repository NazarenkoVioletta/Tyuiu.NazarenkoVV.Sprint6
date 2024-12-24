namespace Tyuiu.NazarenkoVV.Sprint6.Task3.V20
{
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask_NVV = new GroupBox();
            dataGridViewMtrx_NVV = new DataGridView();
            textBoxData_NVV = new TextBox();
            groupBoxResults_NVV = new GroupBox();
            dataGridViewResultMatrix = new DataGridView();
            buttonDone_NVV = new Button();
            buttonHelp_NVV = new Button();
            text1 = new TextBox();
            groupBoxTask_NVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_NVV).BeginInit();
            groupBoxResults_NVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BKV
            // 
            groupBoxTask_NVV.Controls.Add(dataGridViewMtrx_NVV);
            groupBoxTask_NVV.Controls.Add(textBoxData_NVV);
            groupBoxTask_NVV.Location = new Point(12, 12);
            groupBoxTask_NVV.Name = "groupBoxTask_NVV";
            groupBoxTask_NVV.Size = new Size(718, 438);
            groupBoxTask_NVV.TabIndex = 0;
            groupBoxTask_NVV.TabStop = false;
            groupBoxTask_NVV.Text = "Условие";
            // 
            // dataGridViewMtrx_NVV
            // 
            dataGridViewMtrx_NVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx_NVV.Location = new Point(493, 30);
            dataGridViewMtrx_NVV.Name = "dataGridViewMtrx_NVV";
            dataGridViewMtrx_NVV.RowHeadersVisible = false;
            dataGridViewMtrx_NVV.Size = new Size(223, 404);
            dataGridViewMtrx_NVV.TabIndex = 1;
            // 
            // textBoxData_NVV
            // 
            textBoxData_NVV.Location = new Point(6, 31);
            textBoxData_NVV.Multiline = true;
            textBoxData_NVV.Name = "textBoxData_NVV";
            textBoxData_NVV.ReadOnly = true;
            textBoxData_NVV.Size = new Size(481, 401);
            textBoxData_NVV.TabIndex = 0;
            textBoxData_NVV.Text = "Дана матрица 5 на 5\r\n-14  17 -19   3   2\r\n  -4 -14 -19  -9 -1\r\n   1   0  13  14   8\r\n  13   7   8  -3 -15\r\n   2 -20  12 -14   4\r\n\r\n Заменить четные значения в пятой строке на 0.";
            // 
            // groupBoxResults_NVV
            // 
            groupBoxResults_NVV.Controls.Add(dataGridViewResultMatrix);
            groupBoxResults_NVV.Controls.Add(buttonDone_NVV);
            groupBoxResults_NVV.Controls.Add(buttonHelp_NVV);
            groupBoxResults_NVV.Controls.Add(text1);
            groupBoxResults_NVV.Location = new Point(736, 12);
            groupBoxResults_NVV.Name = "groupBoxResults_BKV";
            groupBoxResults_NVV.Size = new Size(251, 432);
            groupBoxResults_NVV.TabIndex = 1;
            groupBoxResults_NVV.TabStop = false;
            groupBoxResults_NVV.Text = "Вывод данных";
            // 
            // dataGridViewResultMatrix
            // 
            dataGridViewResultMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultMatrix.EnableHeadersVisualStyles = false;
            dataGridViewResultMatrix.Location = new Point(15, 61);
            dataGridViewResultMatrix.Name = "dataGridViewResultMatrix";
            dataGridViewResultMatrix.Size = new Size(209, 175);
            dataGridViewResultMatrix.TabIndex = 4;
            // 
            // buttonDone_NVV
            // 
            buttonDone_NVV.Location = new Point(86, 365);
            buttonDone_NVV.Name = "buttonDone_NVV";
            buttonDone_NVV.Size = new Size(136, 51);
            buttonDone_NVV.TabIndex = 3;
            buttonDone_NVV.Text = "Выполнить";
            buttonDone_NVV.UseVisualStyleBackColor = true;
            buttonDone_NVV.Click += buttonDone_NVV_Click;
            // 
            // buttonHelp_NVV
            // 
            buttonHelp_NVV.Location = new Point(21, 365);
            buttonHelp_NVV.Name = "buttonHelp_NVV";
            buttonHelp_NVV.Size = new Size(59, 51);
            buttonHelp_NVV.TabIndex = 2;
            buttonHelp_NVV.Text = "?";
            buttonHelp_NVV.UseVisualStyleBackColor = true;
            buttonHelp_NVV.Click += buttonHelp_NVV_Click;
            // 
            // text1
            // 
            text1.BackColor = SystemColors.ButtonFace;
            text1.Location = new Point(11, 31);
            text1.Multiline = true;
            text1.Name = "text1";
            text1.ReadOnly = true;
            text1.Size = new Size(213, 24);
            text1.TabIndex = 1;
            text1.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(groupBoxResults_NVV);
            Controls.Add(groupBoxTask_NVV);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск 3 | Вариант 20| Назаренко Н.В.";
            Load += FormMain_Load;
            groupBoxTask_NVV.ResumeLayout(false);
            groupBoxTask_NVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_NVV).EndInit();
            groupBoxResults_NVV.ResumeLayout(false);
            groupBoxResults_NVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NVV;
        private TextBox textBoxData_NVV;
        private GroupBox groupBoxResults_NVV;
        private DataGridView dataGridViewMtrx_NVV;
        private Button buttonHelp_NVV;
        private TextBox text1;
        private Button buttonDone_NVV;
        private DataGridView dataGridViewResultMatrix;
    }
}