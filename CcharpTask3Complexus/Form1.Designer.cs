namespace CcharpTask3Complexus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelTextTask = new Label();
            textRealValueA = new TextBox();
            textImaginaryValueA = new TextBox();
            textRealValueB = new TextBox();
            textImaginaryValueB = new TextBox();
            cmdOperator = new ComboBox();
            textResult = new TextBox();
            labelFirstTerm = new Label();
            labelSecondTerm = new Label();
            labelResult = new Label();
            labelOperator = new Label();
            pictureNubmers = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureNubmers).BeginInit();
            SuspendLayout();
            // 
            // labelTextTask
            // 
            labelTextTask.AutoSize = true;
            labelTextTask.Location = new Point(23, 28);
            labelTextTask.Name = "labelTextTask";
            labelTextTask.Size = new Size(278, 20);
            labelTextTask.TabIndex = 0;
            labelTextTask.Text = "Действия над комплексными чиснами";
            // 
            // textRealValueA
            // 
            textRealValueA.Location = new Point(92, 63);
            textRealValueA.Name = "textRealValueA";
            textRealValueA.Size = new Size(168, 27);
            textRealValueA.TabIndex = 1;
            textRealValueA.TextChanged += textRealValueA_TextChanged;
            // 
            // textImaginaryValueA
            // 
            textImaginaryValueA.Location = new Point(272, 63);
            textImaginaryValueA.Name = "textImaginaryValueA";
            textImaginaryValueA.Size = new Size(151, 27);
            textImaginaryValueA.TabIndex = 2;
            textImaginaryValueA.TextChanged += textImaginaryValueA_TextChanged;
            // 
            // textRealValueB
            // 
            textRealValueB.Location = new Point(92, 135);
            textRealValueB.Name = "textRealValueB";
            textRealValueB.Size = new Size(168, 27);
            textRealValueB.TabIndex = 3;
            textRealValueB.TextChanged += textRealValueB_TextChanged;
            // 
            // textImaginaryValueB
            // 
            textImaginaryValueB.Location = new Point(272, 135);
            textImaginaryValueB.Name = "textImaginaryValueB";
            textImaginaryValueB.Size = new Size(151, 27);
            textImaginaryValueB.TabIndex = 4;
            textImaginaryValueB.TextChanged += textImaginaryValueB_TextChanged;
            // 
            // cmdOperator
            // 
            cmdOperator.FormattingEnabled = true;
            cmdOperator.Items.AddRange(new object[] { "+", "-", "*", "/", "=" });
            cmdOperator.Location = new Point(109, 96);
            cmdOperator.Name = "cmdOperator";
            cmdOperator.Size = new Size(151, 28);
            cmdOperator.TabIndex = 5;
            cmdOperator.SelectedIndexChanged += cmdOperator_SelectedIndexChanged;
            // 
            // textResult
            // 
            textResult.Location = new Point(92, 252);
            textResult.Name = "textResult";
            textResult.Size = new Size(635, 27);
            textResult.TabIndex = 6;
            // 
            // labelFirstTerm
            // 
            labelFirstTerm.AutoSize = true;
            labelFirstTerm.Location = new Point(23, 66);
            labelFirstTerm.Name = "labelFirstTerm";
            labelFirstTerm.Size = new Size(26, 20);
            labelFirstTerm.TabIndex = 8;
            labelFirstTerm.Text = "Z1";
            // 
            // labelSecondTerm
            // 
            labelSecondTerm.AutoSize = true;
            labelSecondTerm.Location = new Point(23, 135);
            labelSecondTerm.Name = "labelSecondTerm";
            labelSecondTerm.Size = new Size(26, 20);
            labelSecondTerm.TabIndex = 9;
            labelSecondTerm.Text = "Z2";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(11, 255);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(75, 20);
            labelResult.TabIndex = 10;
            labelResult.Text = "Результат";
            // 
            // labelOperator
            // 
            labelOperator.AutoSize = true;
            labelOperator.Location = new Point(23, 99);
            labelOperator.Name = "labelOperator";
            labelOperator.Size = new Size(80, 20);
            labelOperator.TabIndex = 11;
            labelOperator.Text = "Операция";
            // 
            // pictureNubmers
            // 
            pictureNubmers.Image = (Image)resources.GetObject("pictureNubmers.Image");
            pictureNubmers.Location = new Point(429, 12);
            pictureNubmers.Name = "pictureNubmers";
            pictureNubmers.Size = new Size(339, 234);
            pictureNubmers.SizeMode = PictureBoxSizeMode.Zoom;
            pictureNubmers.TabIndex = 12;
            pictureNubmers.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 329);
            Controls.Add(pictureNubmers);
            Controls.Add(labelOperator);
            Controls.Add(labelResult);
            Controls.Add(labelSecondTerm);
            Controls.Add(labelFirstTerm);
            Controls.Add(textResult);
            Controls.Add(cmdOperator);
            Controls.Add(textImaginaryValueB);
            Controls.Add(textRealValueB);
            Controls.Add(textImaginaryValueA);
            Controls.Add(textRealValueA);
            Controls.Add(labelTextTask);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureNubmers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextTask;
        private TextBox textRealValueA;
        private TextBox textImaginaryValueA;
        private TextBox textRealValueB;
        private TextBox textImaginaryValueB;
        private ComboBox cmdOperator;
        private TextBox textResult;
        private Label labelFirstTerm;
        private Label labelSecondTerm;
        private Label labelResult;
        private Label labelOperator;
        private PictureBox pictureNubmers;
    }
}
