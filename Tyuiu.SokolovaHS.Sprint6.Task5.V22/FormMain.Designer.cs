namespace Tyuiu.SokolovaHS.Sprint6.Task5.V22
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
            dataGridViewResult_HSH = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_HSH).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_HSH
            // 
            buttonDone_HSH.Location = new Point(154, 256);
            buttonDone_HSH.Name = "buttonDone_HSH";
            buttonDone_HSH.Size = new Size(75, 23);
            buttonDone_HSH.TabIndex = 0;
            buttonDone_HSH.Text = "button1";
            buttonDone_HSH.UseVisualStyleBackColor = true;
            buttonDone_HSH.Click += this.buttonDone_HSH_Click;
            // 
            // dataGridViewResult_HSH
            // 
            dataGridViewResult_HSH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_HSH.Location = new Point(356, 22);
            dataGridViewResult_HSH.Name = "dataGridViewResult_HSH";
            dataGridViewResult_HSH.Size = new Size(240, 257);
            dataGridViewResult_HSH.TabIndex = 1;
            dataGridViewResult_HSH.CellContentClick += this.dataGridViewResult_HSH_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewResult_HSH);
            Controls.Add(buttonDone_HSH);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_HSH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_HSH;
        private DataGridView dataGridViewResult_HSH;
    }
}
