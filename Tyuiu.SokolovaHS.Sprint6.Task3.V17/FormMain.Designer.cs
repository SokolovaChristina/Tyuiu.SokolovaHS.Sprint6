namespace Tyuiu.SokolovaHS.Sprint6.Task3.V17
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
            dataGridView_HSH = new DataGridView();
            buttonResult_HSH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_HSH).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_HSH
            // 
            buttonDone_HSH.Location = new Point(68, 348);
            buttonDone_HSH.Name = "buttonDone_HSH";
            buttonDone_HSH.Size = new Size(168, 63);
            buttonDone_HSH.TabIndex = 0;
            buttonDone_HSH.Text = "Выполнить";
            buttonDone_HSH.UseVisualStyleBackColor = true;
            buttonDone_HSH.Click += buttonDone_HSH_Click;
            // 
            // dataGridView_HSH
            // 
            dataGridView_HSH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_HSH.Location = new Point(314, 39);
            dataGridView_HSH.Name = "dataGridView_HSH";
            dataGridView_HSH.Size = new Size(211, 286);
            dataGridView_HSH.TabIndex = 1;
            // 
            // buttonResult_HSH
            // 
            buttonResult_HSH.Location = new Point(560, 39);
            buttonResult_HSH.Multiline = true;
            buttonResult_HSH.Name = "buttonResult_HSH";
            buttonResult_HSH.ReadOnly = true;
            buttonResult_HSH.Size = new Size(211, 286);
            buttonResult_HSH.TabIndex = 2;
            buttonResult_HSH.TextChanged += buttonResult_HSH_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResult_HSH);
            Controls.Add(dataGridView_HSH);
            Controls.Add(buttonDone_HSH);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_HSH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_HSH;
        private DataGridView dataGridView_HSH;
        private TextBox buttonResult_HSH;
    }
}
