namespace Tyuiu.SokolovaHS.Sprint6.Task0.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDoneProgramm_HSH = new Button();
            buttonVarA_HSH = new TextBox();
            textResultProgramm_HSH = new TextBox();
            textBoxTask_HSH = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDoneProgramm_HSH
            // 
            buttonDoneProgramm_HSH.Location = new Point(413, 399);
            buttonDoneProgramm_HSH.Name = "buttonDoneProgramm_HSH";
            buttonDoneProgramm_HSH.Size = new Size(151, 39);
            buttonDoneProgramm_HSH.TabIndex = 0;
            buttonDoneProgramm_HSH.Text = "Выполнить";
            buttonDoneProgramm_HSH.UseVisualStyleBackColor = true;
            buttonDoneProgramm_HSH.Click += buttonDoneProgramm_HSH_Click;
            // 
            // buttonVarA_HSH
            // 
            buttonVarA_HSH.Location = new Point(101, 358);
            buttonVarA_HSH.Name = "buttonVarA_HSH";
            buttonVarA_HSH.Size = new Size(140, 23);
            buttonVarA_HSH.TabIndex = 1;
            buttonVarA_HSH.KeyPress += buttonVarA_HSH_KeyPress;
            // 
            // textResultProgramm_HSH
            // 
            textResultProgramm_HSH.Location = new Point(413, 358);
            textResultProgramm_HSH.Name = "textResultProgramm_HSH";
            textResultProgramm_HSH.ReadOnly = true;
            textResultProgramm_HSH.Size = new Size(151, 23);
            textResultProgramm_HSH.TabIndex = 2;
            // 
            // textBoxTask_HSH
            // 
            textBoxTask_HSH.Location = new Point(12, 35);
            textBoxTask_HSH.Multiline = true;
            textBoxTask_HSH.Name = "textBoxTask_HSH";
            textBoxTask_HSH.ReadOnly = true;
            textBoxTask_HSH.Size = new Size(538, 248);
            textBoxTask_HSH.TabIndex = 3;
            textBoxTask_HSH.Text = "Вычислить выражение по формуле:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 51);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxTask_HSH);
            Controls.Add(textResultProgramm_HSH);
            Controls.Add(buttonVarA_HSH);
            Controls.Add(buttonDoneProgramm_HSH);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 21 | Соколова Х. С.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDoneProgramm_HSH;
        private TextBox textResultProgramm_HSH;
        private TextBox textBoxTask_HSH;
        private PictureBox pictureBox1;
        private TextBox buttonVarA_HSH;
    }
}
