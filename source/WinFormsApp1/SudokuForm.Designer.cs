namespace WinFormsApp1
{
    partial class SudokuForm
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
            saveButton = new Button();
            solveButton = new Button();
            importButton = new Button();
            inputRichTextBox = new RichTextBox();
            outputRichTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            messageGroupBox1 = new GroupBox();
            label3 = new Label();
            messageGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Enabled = false;
            saveButton.Location = new Point(960, 27);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // solveButton
            // 
            solveButton.Enabled = false;
            solveButton.Location = new Point(804, 27);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(150, 46);
            solveButton.TabIndex = 1;
            solveButton.Text = "Solve";
            solveButton.UseVisualStyleBackColor = true;
            solveButton.Click += SolveButton_Click;
            // 
            // importButton
            // 
            importButton.Location = new Point(12, 27);
            importButton.Name = "importButton";
            importButton.Size = new Size(150, 46);
            importButton.TabIndex = 2;
            importButton.Text = "Import";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += ImportButton_Click;
            // 
            // inputRichTextBox
            // 
            inputRichTextBox.Location = new Point(12, 283);
            inputRichTextBox.Name = "inputRichTextBox";
            inputRichTextBox.Size = new Size(524, 699);
            inputRichTextBox.TabIndex = 3;
            inputRichTextBox.Text = "";
            inputRichTextBox.TextChanged += InputRichTextBox_TextChanged;
            // 
            // outputRichTextBox
            // 
            outputRichTextBox.Location = new Point(589, 283);
            outputRichTextBox.Name = "outputRichTextBox";
            outputRichTextBox.ReadOnly = true;
            outputRichTextBox.Size = new Size(521, 699);
            outputRichTextBox.TabIndex = 4;
            outputRichTextBox.Text = "";
            outputRichTextBox.TextChanged += OutputRichTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 248);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 5;
            label1.Text = "Input box";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 248);
            label2.Name = "label2";
            label2.Size = new Size(328, 32);
            label2.TabIndex = 6;
            label2.Text = "Output box ( Solved sudoku )";
            // 
            // messageGroupBox1
            // 
            messageGroupBox1.Controls.Add(label3);
            messageGroupBox1.Location = new Point(12, 108);
            messageGroupBox1.Name = "messageGroupBox1";
            messageGroupBox1.Size = new Size(1098, 114);
            messageGroupBox1.TabIndex = 7;
            messageGroupBox1.TabStop = false;
            messageGroupBox1.Text = "Messages";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 45);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 0;
            // 
            // SudokuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 1009);
            Controls.Add(messageGroupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outputRichTextBox);
            Controls.Add(inputRichTextBox);
            Controls.Add(importButton);
            Controls.Add(solveButton);
            Controls.Add(saveButton);
            Name = "SudokuForm";
            Text = "Sudoku Solver Playground by Firas GHRIBI";
            messageGroupBox1.ResumeLayout(false);
            messageGroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Button solveButton;
        private Button importButton;
        private RichTextBox inputRichTextBox;
        private RichTextBox outputRichTextBox;
        private Label label1;
        private Label label2;
        private GroupBox messageGroupBox1;
        private Label label3;
    }
}
