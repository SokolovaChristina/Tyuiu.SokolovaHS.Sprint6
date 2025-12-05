namespace Tyuiu.SokolovaHS.Sprint6.Task6.V2
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
            buttonDone_HSH = new Button();
            textBoxOut_HSH = new TextBox();
            SuspendLayout();
            // 
            // buttonDone_HSH
            // 
            buttonDone_HSH.Location = new Point(69, 366);
            buttonDone_HSH.Name = "buttonDone_HSH";
            buttonDone_HSH.Size = new Size(140, 55);
            buttonDone_HSH.TabIndex = 0;
            buttonDone_HSH.Text = "Выполнить";
            buttonDone_HSH.UseVisualStyleBackColor = true;
            buttonDone_HSH.Click += buttonDone_HSH_Click;
            // 
            // textBoxOut_HSH
            // 
            textBoxOut_HSH.Location = new Point(359, 38);
            textBoxOut_HSH.Multiline = true;
            textBoxOut_HSH.Name = "textBoxOut_HSH";
            textBoxOut_HSH.Size = new Size(238, 326);
            textBoxOut_HSH.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOut_HSH);
            Controls.Add(buttonDone_HSH);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_HSH;
        private TextBox textBoxOut_HSH;
    }
}
