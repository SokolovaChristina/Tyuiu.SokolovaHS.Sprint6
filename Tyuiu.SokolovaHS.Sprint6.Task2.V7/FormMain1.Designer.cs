namespace Tyuiu.SokolovaHS.Sprint6.Task2.V7
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
            buttonDone_SHS = new Button();
            buttonResult_HSH = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            buttonStartStep_HSH = new TextBox();
            buttonStopStep_HSH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)buttonResult_HSH).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_SHS
            // 
            buttonDone_SHS.Location = new Point(311, 377);
            buttonDone_SHS.Name = "buttonDone_SHS";
            buttonDone_SHS.Size = new Size(136, 56);
            buttonDone_SHS.TabIndex = 0;
            buttonDone_SHS.Text = "Выполнить";
            buttonDone_SHS.UseVisualStyleBackColor = true;
            buttonDone_SHS.Click += buttonDone_SHS_Click;
            // 
            // buttonResult_HSH
            // 
            buttonResult_HSH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            buttonResult_HSH.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            buttonResult_HSH.Location = new Point(525, 65);
            buttonResult_HSH.Name = "buttonResult_HSH";
            buttonResult_HSH.RowHeadersVisible = false;
            buttonResult_HSH.Size = new Size(103, 273);
            buttonResult_HSH.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "(X)";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // buttonStartStep_HSH
            // 
            buttonStartStep_HSH.Location = new Point(29, 395);
            buttonStartStep_HSH.Name = "buttonStartStep_HSH";
            buttonStartStep_HSH.Size = new Size(100, 23);
            buttonStartStep_HSH.TabIndex = 2;
            // 
            // buttonStopStep_HSH
            // 
            buttonStopStep_HSH.Location = new Point(163, 395);
            buttonStopStep_HSH.Name = "buttonStopStep_HSH";
            buttonStopStep_HSH.Size = new Size(100, 23);
            buttonStopStep_HSH.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStopStep_HSH);
            Controls.Add(buttonStartStep_HSH);
            Controls.Add(buttonResult_HSH);
            Controls.Add(buttonDone_SHS);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)buttonResult_HSH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_SHS;
        private DataGridView buttonResult_HSH;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox buttonStartStep_HSH;
        private TextBox buttonStopStep_HSH;
    }
}
