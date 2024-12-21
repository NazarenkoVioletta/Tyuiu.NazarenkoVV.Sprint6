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
            taskPicture_SMA = new PictureBox();
            taskTextBox_SMA = new TextBox();
            taskLabel_SMA = new Label();
            resultTextBox_SMA = new TextBox();
            xinputBox_SMA = new TextBox();
            outputLabel_SMA = new Label();
            inputLabel_SMA = new Label();
            xinputLabel_SMA = new Label();
            resultLabel_SMA = new Label();
            executeButton_SMA = new Button();
            aboutButton_SMA = new Button();
            ((System.ComponentModel.ISupportInitialize)taskPicture_SMA).BeginInit();
            SuspendLayout();
            // 
            // taskPicture_SMA
            // 
            taskPicture_SMA.Image = Properties.Resources.загруженное;
            taskPicture_SMA.Location = new Point(350, 49);
            taskPicture_SMA.Margin = new Padding(3, 4, 3, 4);
            taskPicture_SMA.Name = "taskPicture_SMA";
            taskPicture_SMA.Size = new Size(80, 71);
            taskPicture_SMA.TabIndex = 0;
            taskPicture_SMA.TabStop = false;
            // 
            // taskTextBox_SMA
            // 
            taskTextBox_SMA.Enabled = false;
            taskTextBox_SMA.HideSelection = false;
            taskTextBox_SMA.Location = new Point(14, 33);
            taskTextBox_SMA.Margin = new Padding(3, 4, 3, 4);
            taskTextBox_SMA.Multiline = true;
            taskTextBox_SMA.Name = "taskTextBox_SMA";
            taskTextBox_SMA.ReadOnly = true;
            taskTextBox_SMA.Size = new Size(427, 177);
            taskTextBox_SMA.TabIndex = 1;
            taskTextBox_SMA.Text = "Вычислить выражение по формуле";
            taskTextBox_SMA.TextChanged += textBox1_TextChanged;
            // 
            // taskLabel_SMA
            // 
            taskLabel_SMA.AutoSize = true;
            taskLabel_SMA.Location = new Point(14, 9);
            taskLabel_SMA.Name = "taskLabel_SMA";
            taskLabel_SMA.Size = new Size(67, 20);
            taskLabel_SMA.TabIndex = 2;
            taskLabel_SMA.Text = "Условие";
            // 
            // resultTextBox_SMA
            // 
            resultTextBox_SMA.Location = new Point(271, 269);
            resultTextBox_SMA.Margin = new Padding(3, 4, 3, 4);
            resultTextBox_SMA.Name = "resultTextBox_SMA";
            resultTextBox_SMA.ReadOnly = true;
            resultTextBox_SMA.Size = new Size(158, 27);
            resultTextBox_SMA.TabIndex = 3;
            // 
            // xinputBox_SMA
            // 
            xinputBox_SMA.Location = new Point(53, 269);
            xinputBox_SMA.Margin = new Padding(3, 4, 3, 4);
            xinputBox_SMA.Name = "xinputBox_SMA";
            xinputBox_SMA.Size = new Size(114, 27);
            xinputBox_SMA.TabIndex = 4;
            xinputBox_SMA.TextChanged += xinputBox_SMA_TextChanged;
            xinputBox_SMA.KeyPress += xinputBox_SMA_KeyPress;
            // 
            // outputLabel_SMA
            // 
            outputLabel_SMA.AutoSize = true;
            outputLabel_SMA.Location = new Point(271, 216);
            outputLabel_SMA.Name = "outputLabel_SMA";
            outputLabel_SMA.Size = new Size(110, 20);
            outputLabel_SMA.TabIndex = 5;
            outputLabel_SMA.Text = "Вывод данных";
            outputLabel_SMA.Click += label2_Click;
            // 
            // inputLabel_SMA
            // 
            inputLabel_SMA.AutoSize = true;
            inputLabel_SMA.Location = new Point(53, 217);
            inputLabel_SMA.Name = "inputLabel_SMA";
            inputLabel_SMA.Size = new Size(99, 20);
            inputLabel_SMA.TabIndex = 6;
            inputLabel_SMA.Text = "Ввод данных";
            inputLabel_SMA.Click += label3_Click;
            // 
            // xinputLabel_SMA
            // 
            xinputLabel_SMA.AutoSize = true;
            xinputLabel_SMA.Location = new Point(53, 245);
            xinputLabel_SMA.Name = "xinputLabel_SMA";
            xinputLabel_SMA.Size = new Size(112, 20);
            xinputLabel_SMA.TabIndex = 7;
            xinputLabel_SMA.Text = "Переменная x:";
            // 
            // resultLabel_SMA
            // 
            resultLabel_SMA.AutoSize = true;
            resultLabel_SMA.Location = new Point(271, 245);
            resultLabel_SMA.Name = "resultLabel_SMA";
            resultLabel_SMA.Size = new Size(78, 20);
            resultLabel_SMA.TabIndex = 8;
            resultLabel_SMA.Text = "Результат:";
            // 
            // executeButton_SMA
            // 
            executeButton_SMA.Location = new Point(315, 308);
            executeButton_SMA.Margin = new Padding(3, 4, 3, 4);
            executeButton_SMA.Name = "executeButton_SMA";
            executeButton_SMA.Size = new Size(114, 37);
            executeButton_SMA.TabIndex = 9;
            executeButton_SMA.Text = "Выполнить";
            executeButton_SMA.UseVisualStyleBackColor = true;
            executeButton_SMA.Click += executeButton_SMA_Click;
            // 
            // aboutButton_SMA
            // 
            aboutButton_SMA.FlatStyle = FlatStyle.Flat;
            aboutButton_SMA.Location = new Point(271, 308);
            aboutButton_SMA.Margin = new Padding(3, 4, 3, 4);
            aboutButton_SMA.Name = "aboutButton_SMA";
            aboutButton_SMA.Size = new Size(38, 37);
            aboutButton_SMA.TabIndex = 10;
            aboutButton_SMA.Text = "?";
            aboutButton_SMA.UseVisualStyleBackColor = true;
            aboutButton_SMA.Click += aboutButton_SMA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 361);
            Controls.Add(aboutButton_SMA);
            Controls.Add(executeButton_SMA);
            Controls.Add(resultLabel_SMA);
            Controls.Add(xinputLabel_SMA);
            Controls.Add(inputLabel_SMA);
            Controls.Add(outputLabel_SMA);
            Controls.Add(xinputBox_SMA);
            Controls.Add(resultTextBox_SMA);
            Controls.Add(taskLabel_SMA);
            Controls.Add(taskPicture_SMA);
            Controls.Add(taskTextBox_SMA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 17 |  Назаренко В. В.";
            ((System.ComponentModel.ISupportInitialize)taskPicture_SMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox taskPicture_SMA;
        private TextBox taskTextBox_SMA;
        private Label taskLabel_SMA;
        private TextBox resultTextBox_SMA;
        private TextBox xinputBox_SMA;
        private Label outputLabel_SMA;
        private Label inputLabel_SMA;
        private Label xinputLabel_SMA;
        private Label resultLabel_SMA;
        private Button executeButton_SMA;
        private Button aboutButton_SMA;
    }
}