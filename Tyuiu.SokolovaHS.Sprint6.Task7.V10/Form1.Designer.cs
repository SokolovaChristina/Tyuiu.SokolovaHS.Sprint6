namespace Tyuiu.SokolovaHS.Sprint6.Task7.V10
{
    partial class Form1
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
            buttonDone_HSH = new Button();
            buttonResult_HSH = new TextBox();
            SuspendLayout();
            // 
            // buttonDone_HSH
            // 
            buttonDone_HSH.Location = new Point(116, 207);
            buttonDone_HSH.Name = "buttonDone_HSH";
            buttonDone_HSH.Size = new Size(142, 69);
            buttonDone_HSH.TabIndex = 0;
            buttonDone_HSH.Text = "Выполнить";
            buttonDone_HSH.UseVisualStyleBackColor = true;
            buttonDone_HSH.Click += buttonDone_HSH_Click;
            // 
            // buttonResult_HSH
            // 
            buttonResult_HSH.Location = new Point(427, 47);
            buttonResult_HSH.Multiline = true;
            buttonResult_HSH.Name = "buttonResult_HSH";
            buttonResult_HSH.ReadOnly = true;
            buttonResult_HSH.Size = new Size(237, 269);
            buttonResult_HSH.TabIndex = 1;
            buttonResult_HSH.TextChanged += buttonResult_HSH_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResult_HSH);
            Controls.Add(buttonDone_HSH);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_HSH;
        private TextBox buttonResult_HSH;
    }
}
