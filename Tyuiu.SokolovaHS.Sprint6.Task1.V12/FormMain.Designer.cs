namespace Tyuiu.SokolovaHS.Sprint6.Task1.V12
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
            ButtonDone_HSH = new Button();
            buttonResult_HSH = new TextBox();
            buttonStartStep_HSH = new TextBox();
            buttonStopStep_HSH = new TextBox();
            SuspendLayout();
            // 
            // ButtonDone_HSH
            // 
            ButtonDone_HSH.Location = new Point(390, 388);
            ButtonDone_HSH.Name = "ButtonDone_HSH";
            ButtonDone_HSH.Size = new Size(141, 50);
            ButtonDone_HSH.TabIndex = 0;
            ButtonDone_HSH.Text = "Выполнить";
            ButtonDone_HSH.UseVisualStyleBackColor = true;
            ButtonDone_HSH.Click += ButtonDone_HSH_Click;
            // 
            // buttonResult_HSH
            // 
            buttonResult_HSH.Location = new Point(577, 71);
            buttonResult_HSH.Multiline = true;
            buttonResult_HSH.Name = "buttonResult_HSH";
            buttonResult_HSH.ReadOnly = true;
            buttonResult_HSH.ScrollBars = ScrollBars.Vertical;
            buttonResult_HSH.Size = new Size(196, 290);
            buttonResult_HSH.TabIndex = 1;
            // 
            // buttonStartStep_HSH
            // 
            buttonStartStep_HSH.Location = new Point(37, 403);
            buttonStartStep_HSH.Name = "buttonStartStep_HSH";
            buttonStartStep_HSH.Size = new Size(105, 23);
            buttonStartStep_HSH.TabIndex = 2;
            // 
            // buttonStopStep_HSH
            // 
            buttonStopStep_HSH.Location = new Point(195, 403);
            buttonStopStep_HSH.Name = "buttonStopStep_HSH";
            buttonStopStep_HSH.Size = new Size(105, 23);
            buttonStopStep_HSH.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStopStep_HSH);
            Controls.Add(buttonStartStep_HSH);
            Controls.Add(buttonResult_HSH);
            Controls.Add(ButtonDone_HSH);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 12 | Соколова Х. С.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonDone_HSH;
        private TextBox buttonResult_HSH;
        private TextBox buttonStartStep_HSH;
        private TextBox buttonStopStep_HSH;
    }
}
