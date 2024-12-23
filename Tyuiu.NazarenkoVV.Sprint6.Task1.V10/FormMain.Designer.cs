namespace Tyuiu.NazarenkoVV.Sprint6.Task1.V10
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_NVV = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask = new System.Windows.Forms.PictureBox();
            this.groupBoxInPut_NVV = new System.Windows.Forms.GroupBox();
            this.labelEnd_NVV = new System.Windows.Forms.Label();
            this.labelStart_NVV = new System.Windows.Forms.Label();
            this.textBoxEnd_NVV = new System.Windows.Forms.TextBox();
            this.textBoxStart_NVV = new System.Windows.Forms.TextBox();
            this.buttonInfo_NVV = new System.Windows.Forms.Button();
            this.buttonResult_NVV = new System.Windows.Forms.Button();
            this.groupBoxOutPut_NVV = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_NVV = new System.Windows.Forms.TextBox();
            this.groupBoxTask_NVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).BeginInit();
            this.groupBoxInPut_NVV.SuspendLayout();
            this.groupBoxOutPut_NVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_NVV
            // 
            this.groupBoxTask_NVV.Controls.Add(this.pictureBoxTask);
            this.groupBoxTask_NVV.Location = new System.Drawing.Point(6, 11);
            this.groupBoxTask_NVV.Name = "groupBoxTask_NVV";
            this.groupBoxTask_NVV.Size = new System.Drawing.Size(650, 184);
            this.groupBoxTask_NVV.TabIndex = 0;
            this.groupBoxTask_NVV.TabStop = false;
            this.groupBoxTask_NVV.Text = "Условия";
            // 
            // pictureBoxTask
            // 
            this.pictureBoxTask.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask.Image")));
            this.pictureBoxTask.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxTask.Name = "pictureBoxTask";
            this.pictureBoxTask.Size = new System.Drawing.Size(639, 159);
            this.pictureBoxTask.TabIndex = 0;
            this.pictureBoxTask.TabStop = false;
            // 
            // groupBoxInPut_NVV
            // 
            this.groupBoxInPut_NVV.Controls.Add(this.labelEnd_NVV);
            this.groupBoxInPut_NVV.Controls.Add(this.labelStart_NVV);
            this.groupBoxInPut_NVV.Controls.Add(this.textBoxEnd_NVV);
            this.groupBoxInPut_NVV.Controls.Add(this.textBoxStart_NVV);
            this.groupBoxInPut_NVV.Location = new System.Drawing.Point(6, 211);
            this.groupBoxInPut_NVV.Name = "groupBoxInPut_NVV";
            this.groupBoxInPut_NVV.Size = new System.Drawing.Size(319, 100);
            this.groupBoxInPut_NVV.TabIndex = 1;
            this.groupBoxInPut_NVV.TabStop = false;
            this.groupBoxInPut_NVV.Text = "Ввод Данных";
            // 
            // labelEnd_NVV
            // 
            this.labelEnd_NVV.AutoSize = true;
            this.labelEnd_NVV.Location = new System.Drawing.Point(130, 30);
            this.labelEnd_NVV.Name = "labelEnd_NVV";
            this.labelEnd_NVV.Size = new System.Drawing.Size(66, 13);
            this.labelEnd_NVV.TabIndex = 1;
            this.labelEnd_NVV.Text = "Конец шага";
            // 
            // labelStart_NVV
            // 
            this.labelStart_NVV.AutoSize = true;
            this.labelStart_NVV.Location = new System.Drawing.Point(6, 30);
            this.labelStart_NVV.Name = "labelStart_NVV";
            this.labelStart_NVV.Size = new System.Drawing.Size(64, 13);
            this.labelStart_NVV.TabIndex = 1;
            this.labelStart_NVV.Text = "Старт шага";
            // 
            // textBoxEnd_NVV
            // 
            this.textBoxEnd_NVV.Location = new System.Drawing.Point(133, 46);
            this.textBoxEnd_NVV.Name = "textBoxEnd_NVV";
            this.textBoxEnd_NVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd_NVV.TabIndex = 0;
            // 
            // textBoxStart_NVV
            // 
            this.textBoxStart_NVV.Location = new System.Drawing.Point(6, 46);
            this.textBoxStart_NVV.Name = "textBoxStart_NVV";
            this.textBoxStart_NVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_NVV.TabIndex = 0;
            // 
            // buttonInfo_NVV
            // 
            this.buttonInfo_NVV.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInfo_NVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_NVV.Location = new System.Drawing.Point(348, 246);
            this.buttonInfo_NVV.Name = "buttonInfo_NVV";
            this.buttonInfo_NVV.Size = new System.Drawing.Size(133, 30);
            this.buttonInfo_NVV.TabIndex = 2;
            this.buttonInfo_NVV.Text = "Справка";
            this.buttonInfo_NVV.UseVisualStyleBackColor = false;
            this.buttonInfo_NVV.Click += new System.EventHandler(this.buttonInfo_NVV_Click);
            // 
            // buttonResult_NVV
            // 
            this.buttonResult_NVV.BackColor = System.Drawing.Color.LightGreen;
            this.buttonResult_NVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_NVV.Location = new System.Drawing.Point(497, 246);
            this.buttonResult_NVV.Name = "buttonResult_SKE";
            this.buttonResult_NVV.Size = new System.Drawing.Size(136, 30);
            this.buttonResult_NVV.TabIndex = 3;
            this.buttonResult_NVV.Text = "Результат";
            this.buttonResult_NVV.UseVisualStyleBackColor = false;
            this.buttonResult_NVV.Click += new System.EventHandler(this.buttonResult_NVV_Click);
            // 
            // groupBoxOutPut_NVV
            // 
            this.groupBoxOutPut_NVV.Controls.Add(this.textBoxOutPut_NVV);
            this.groupBoxOutPut_NVV.Location = new System.Drawing.Point(662, 11);
            this.groupBoxOutPut_NVV.Name = "groupBoxOutPut_SKE";
            this.groupBoxOutPut_NVV.Size = new System.Drawing.Size(224, 299);
            this.groupBoxOutPut_NVV.TabIndex = 4;
            this.groupBoxOutPut_NVV.TabStop = false;
            this.groupBoxOutPut_NVV.Text = "Вывод Данных";
            // 
            // textBoxOutPut_NVV
            // 
            this.textBoxOutPut_NVV.Location = new System.Drawing.Point(5, 17);
            this.textBoxOutPut_NVV.Multiline = true;
            this.textBoxOutPut_NVV.Name = "textBoxOutPut_SKE";
            this.textBoxOutPut_NVV.ReadOnly = true;
            this.textBoxOutPut_NVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_NVV.Size = new System.Drawing.Size(212, 282);
            this.textBoxOutPut_NVV.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 324);
            this.Controls.Add(this.groupBoxOutPut_NVV);
            this.Controls.Add(this.buttonResult_NVV);
            this.Controls.Add(this.buttonInfo_NVV);
            this.Controls.Add(this.groupBoxInPut_NVV);
            this.Controls.Add(this.groupBoxTask_NVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 10 | Назаренко В. В.";
            this.groupBoxTask_NVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).EndInit();
            this.groupBoxInPut_NVV.ResumeLayout(false);
            this.groupBoxInPut_NVV.PerformLayout();
            this.groupBoxOutPut_NVV.ResumeLayout(false);
            this.groupBoxOutPut_NVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NVV;
        private System.Windows.Forms.PictureBox pictureBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInPut_NVV;
        private System.Windows.Forms.Label labelEnd_NVV;
        private System.Windows.Forms.Label labelStart_NVV;
        private System.Windows.Forms.TextBox textBoxEnd_NVV;
        private System.Windows.Forms.TextBox textBoxStart_NVV;
        private System.Windows.Forms.Button buttonInfo_NVV;
        private System.Windows.Forms.Button buttonResult_NVV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_NVV;
        private System.Windows.Forms.TextBox textBoxOutPut_NVV;
    }
}


