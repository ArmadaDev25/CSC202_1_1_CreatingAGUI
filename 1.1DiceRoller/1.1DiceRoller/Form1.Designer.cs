namespace _1._1DiceRoller
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
            rollDicebtn = new Button();
            label1 = new Label();
            numdiceInput = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            ErrorLabel = new Label();
            SuspendLayout();
            // 
            // rollDicebtn
            // 
            rollDicebtn.Location = new Point(25, 128);
            rollDicebtn.Name = "rollDicebtn";
            rollDicebtn.Size = new Size(389, 36);
            rollDicebtn.TabIndex = 0;
            rollDicebtn.Text = "Roll Dice";
            rollDicebtn.UseVisualStyleBackColor = true;
            rollDicebtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 45);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 1;
            label1.Text = "Number of Dice To Roll";
            label1.Click += label1_Click;
            // 
            // numdiceInput
            // 
            numdiceInput.Location = new Point(264, 42);
            numdiceInput.Name = "numdiceInput";
            numdiceInput.Size = new Size(150, 31);
            numdiceInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 83);
            label2.Name = "label2";
            label2.Size = new Size(217, 25);
            label2.TabIndex = 3;
            label2.Text = "Number Of Sides Per Dice";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(503, 41);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(59, 25);
            ErrorLabel.TabIndex = 5;
            ErrorLabel.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrorLabel);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(numdiceInput);
            Controls.Add(label1);
            Controls.Add(rollDicebtn);
            Name = "Form1";
            Text = "Dice Roller";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rollDicebtn;
        private Label label1;
        private TextBox numdiceInput;
        private Label label2;
        private TextBox textBox2;
        private Label ErrorLabel;
    }
}
