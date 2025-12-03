namespace Tyuiu.SokolovaHS.Sprint6.Task4.V23
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
            buttonResult_HSH = new TextBox();
            buttonSave_HSH = new Button();
            StartStep_HSH = new TextBox();
            StopStep_HSH = new TextBox();
            SuspendLayout();
            // 
            // buttonDone_HSH
            // 
            buttonDone_HSH.Location = new Point(417, 366);
            buttonDone_HSH.Name = "buttonDone_HSH";
            buttonDone_HSH.Size = new Size(146, 51);
            buttonDone_HSH.TabIndex = 0;
            buttonDone_HSH.Text = "Выполнить";
            buttonDone_HSH.UseVisualStyleBackColor = true;
            buttonDone_HSH.Click += buttonDone_HSH_Click;
            // 
            // buttonResult_HSH
            // 
            buttonResult_HSH.Location = new Point(458, 28);
            buttonResult_HSH.Multiline = true;
            buttonResult_HSH.Name = "buttonResult_HSH";
            buttonResult_HSH.ReadOnly = true;
            buttonResult_HSH.Size = new Size(274, 289);
            buttonResult_HSH.TabIndex = 1;
            // 
            // buttonSave_HSH
            // 
            buttonSave_HSH.Location = new Point(611, 366);
            buttonSave_HSH.Name = "buttonSave_HSH";
            buttonSave_HSH.Size = new Size(146, 51);
            buttonSave_HSH.TabIndex = 2;
            buttonSave_HSH.Text = "Сохранить";
            buttonSave_HSH.UseVisualStyleBackColor = true;
            buttonSave_HSH.Click += buttonSave_HSH_Click;
            // 
            // StartStep_HSH
            // 
            StartStep_HSH.Location = new Point(68, 381);
            StartStep_HSH.Name = "StartStep_HSH";
            StartStep_HSH.Size = new Size(100, 23);
            StartStep_HSH.TabIndex = 3;
            // 
            // StopStep_HSH
            // 
            StopStep_HSH.Location = new Point(239, 381);
            StopStep_HSH.Name = "StopStep_HSH";
            StopStep_HSH.Size = new Size(100, 23);
            StopStep_HSH.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StopStep_HSH);
            Controls.Add(StartStep_HSH);
            Controls.Add(buttonSave_HSH);
            Controls.Add(buttonResult_HSH);
            Controls.Add(buttonDone_HSH);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_HSH;
        private TextBox buttonResult_HSH;
        private Button buttonSave_HSH;
        private TextBox StartStep_HSH;
        private TextBox StopStep_HSH;
    }
}
