namespace Tyuiu.SokolovaHS.Sprint6.Task5.V22;

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
        dataGridViewResult_HSH = new DataGridView();
        buttonDone_HSH = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_HSH).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewResult_HSH
        // 
        dataGridViewResult_HSH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewResult_HSH.Location = new Point(507, 57);
        dataGridViewResult_HSH.Name = "dataGridViewResult_HSH";
        dataGridViewResult_HSH.Size = new Size(240, 350);
        dataGridViewResult_HSH.TabIndex = 0;
        dataGridViewResult_HSH.CellContentClick += dataGridViewResult_HSH_CellContentClick;
        // 
        // buttonDone_HSH
        // 
        buttonDone_HSH.Location = new Point(87, 339);
        buttonDone_HSH.Name = "buttonDone_HSH";
        buttonDone_HSH.Size = new Size(200, 68);
        buttonDone_HSH.TabIndex = 1;
        buttonDone_HSH.Text = "Выполнить";
        buttonDone_HSH.UseVisualStyleBackColor = true;
        buttonDone_HSH.Click += buttonDone_HSH_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(buttonDone_HSH);
        Controls.Add(dataGridViewResult_HSH);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_HSH).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridViewResult_HSH;
    private Button buttonDone_HSH;
}
