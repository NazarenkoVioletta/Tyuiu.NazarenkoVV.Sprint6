namespace Tyuiu.NazarenkoVV.Sprint6.Task0.V17
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
            taskPicture_NVV = new PictureBox();
            taskTextBox_NVV = new TextBox();
            taskLabel_NVV = new Label();
            resultTextBox_NVV = new TextBox();
            xinputBox_NVV = new TextBox();
            outputLabel_NVV = new Label();
            inputLabel_NVV = new Label();
            xinputLabel_NVV = new Label();
            resultLabel_NVV = new Label();
            executeButton_NVV = new Button();
            aboutButton_NVV = new Button();
            ((System.ComponentModel.ISupportInitialize)taskPicture_NVV).BeginInit();
            SuspendLayout();
            // 
            // taskPicture_NVV
            // 
            taskPicture_NVV.Image = Properties.Resources.загруженное;
            taskPicture_NVV.Location = new Point(350, 49);
            taskPicture_NVV.Margin = new Padding(3, 4, 3, 4);
            taskPicture_NVV.Name = "taskPicture_NVV";
            taskPicture_NVV.Size = new Size(80, 71);
            taskPicture_NVV.TabIndex = 0;
            taskPicture_NVV.TabStop = false;
            // 
            // taskTextBox_NVV
            // 
            taskTextBox_NVV.Enabled = false;
            taskTextBox_NVV.HideSelection = false;
            taskTextBox_NVV.Location = new Point(14, 33);
            taskTextBox_NVV.Margin = new Padding(3, 4, 3, 4);
            taskTextBox_NVV.Multiline = true;
            taskTextBox_NVV.Name = "taskTextBox_NVV";
            taskTextBox_NVV.ReadOnly = true;
            taskTextBox_NVV.Size = new Size(427, 177);
            taskTextBox_NVV.TabIndex = 1;
            taskTextBox_NVV.Text = "Вычислить выражение по формуле";
            taskTextBox_NVV.TextChanged += textBox1_TextChanged;
            // 
            // taskLabel_NVV
            // 
            taskLabel_NVV.AutoSize = true;
            taskLabel_NVV.Location = new Point(14, 9);
            taskLabel_NVV.Name = "taskLabel_NVV";
            taskLabel_NVV.Size = new Size(67, 20);
            taskLabel_NVV.TabIndex = 2;
            taskLabel_NVV.Text = "Условие";
            // 
            // resultTextBox_NVV
            // 
            resultTextBox_NVV.Location = new Point(271, 269);
            resultTextBox_NVV.Margin = new Padding(3, 4, 3, 4);
            resultTextBox_NVV.Name = "resultTextBox_NVV";
            resultTextBox_NVV.ReadOnly = true;
            resultTextBox_NVV.Size = new Size(158, 27);
            resultTextBox_NVV.TabIndex = 3;
            // 
            // xinputBox_NVV
            // 
            xinputBox_NVV.Location = new Point(53, 269);
            xinputBox_NVV.Margin = new Padding(3, 4, 3, 4);
            xinputBox_NVV.Name = "xinputBox_SMA";
            xinputBox_NVV.Size = new Size(114, 27);
            xinputBox_NVV.TabIndex = 4;
            xinputBox_NVV.TextChanged += xinputBox_NVV_TextChanged;
            xinputBox_NVV.KeyPress += xinputBox_NVV_KeyPress;
            // 
            // outputLabel_NVV
            // 
            outputLabel_NVV.AutoSize = true;
            outputLabel_NVV.Location = new Point(271, 216);
            outputLabel_NVV.Name = "outputLabel_NVV";
            outputLabel_NVV.Size = new Size(110, 20);
            outputLabel_NVV.TabIndex = 5;
            outputLabel_NVV.Text = "Вывод данных";
            outputLabel_NVV.Click += label2_Click;
            // 
            // inputLabel_NVV
            // 
            inputLabel_NVV.AutoSize = true;
            inputLabel_NVV.Location = new Point(53, 217);
            inputLabel_NVV.Name = "inputLabel_NVV";
            inputLabel_NVV.Size = new Size(99, 20);
            inputLabel_NVV .TabIndex = 6;
            inputLabel_NVV.Text = "Ввод данных";
            inputLabel_NVV.Click += label3_Click;
            // 
            // xinputLabel_NVV
            // 
            xinputLabel_NVV.AutoSize = true;
            xinputLabel_NVV.Location = new Point(53, 245);
            xinputLabel_NVV.Name = "xinputLabel_NVV";
            xinputLabel_NVV.Size = new Size(112, 20);
            xinputLabel_NVV.TabIndex = 7;
            xinputLabel_NVV.Text = "Переменная x:";
            // 
            // resultLabel_NVV
            // 
            resultLabel_NVV.AutoSize = true;
            resultLabel_NVV.Location = new Point(271, 245);
            resultLabel_NVV.Name = "resultLabel_NVV";
            resultLabel_NVV.Size = new Size(78, 20);
            resultLabel_NVV.TabIndex = 8;
            resultLabel_NVV.Text = "Результат:";
            // 
            // executeButton_NVV
            // 
            executeButton_NVV.Location = new Point(315, 308);
            executeButton_NVV.Margin = new Padding(3, 4, 3, 4);
            executeButton_NVV.Name = "executeButton_NVV";
            executeButton_NVV.Size = new Size(114, 37);
            executeButton_NVV.TabIndex = 9;
            executeButton_NVV.Text = "Выполнить";
            executeButton_NVV.UseVisualStyleBackColor = true;
            executeButton_NVV.Click += executeButton_NVV_Click;
            // 
            // aboutButton_NVV
            // 
            aboutButton_NVV.FlatStyle = FlatStyle.Flat;
            aboutButton_NVV.Location = new Point(271, 308);
            aboutButton_NVV.Margin = new Padding(3, 4, 3, 4);
            aboutButton_NVV.Name = "aboutButton_NVV";
            aboutButton_NVV.Size = new Size(38, 37);
            aboutButton_NVV.TabIndex = 10;
            aboutButton_NVV.Text = "?";
            aboutButton_NVV.UseVisualStyleBackColor = true;
            aboutButton_NVV.Click += aboutButton_NVV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 361);
            Controls.Add(aboutButton_NVV);
            Controls.Add(executeButton_NVV);
            Controls.Add(resultLabel_NVV);
            Controls.Add(xinputLabel_NVV);
            Controls.Add(inputLabel_NVV);
            Controls.Add(outputLabel_NVV);
            Controls.Add(xinputBox_NVV);
            Controls.Add(resultTextBox_NVV);
            Controls.Add(taskLabel_NVV);
            Controls.Add(taskPicture_NVV);
            Controls.Add(taskTextBox_NVV);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 17 |  Назаренко В. В.";
            ((System.ComponentModel.ISupportInitialize)taskPicture_NVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox taskPicture_NVV;
        private TextBox taskTextBox_NVV;
        private Label taskLabel_NVV;
        private TextBox resultTextBox_NVV;
        private TextBox xinputBox_NVV;
        private Label outputLabel_NVV;
        private Label inputLabel_NVV;
        private Label xinputLabel_NVV;
        private Label resultLabel_NVV;
        private Button executeButton_NVV;
        private Button aboutButton_NVV;
    }
}