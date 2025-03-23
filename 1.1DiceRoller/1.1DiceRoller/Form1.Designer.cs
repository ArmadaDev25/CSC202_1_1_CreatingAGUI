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
            numSidesInput = new TextBox();
            label3 = new Label();
            ResultsLB = new ListBox();
            label4 = new Label();
            label5 = new Label();
            diceinfobtn = new Button();
            rollStatsBtn = new Button();
            RollOrdersBtn = new Button();
            SuspendLayout();
            // 
            // rollDicebtn
            // 
            rollDicebtn.Location = new Point(12, 192);
            rollDicebtn.Name = "rollDicebtn";
            rollDicebtn.Size = new Size(217, 36);
            rollDicebtn.TabIndex = 0;
            rollDicebtn.Text = "Roll Dice";
            rollDicebtn.UseVisualStyleBackColor = true;
            rollDicebtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 1;
            label1.Text = "Number of Dice To Roll";
            label1.Click += label1_Click;
            // 
            // numdiceInput
            // 
            numdiceInput.Location = new Point(251, 106);
            numdiceInput.Name = "numdiceInput";
            numdiceInput.Size = new Size(150, 31);
            numdiceInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 147);
            label2.Name = "label2";
            label2.Size = new Size(217, 25);
            label2.TabIndex = 3;
            label2.Text = "Number Of Sides Per Dice";
            label2.Click += label2_Click;
            // 
            // numSidesInput
            // 
            numSidesInput.Location = new Point(251, 143);
            numSidesInput.Name = "numSidesInput";
            numSidesInput.Size = new Size(150, 31);
            numSidesInput.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 6;
            label3.Text = "Roll Custom Sided Dice";
            label3.Click += label3_Click;
            // 
            // ResultsLB
            // 
            ResultsLB.FormattingEnabled = true;
            ResultsLB.ItemHeight = 25;
            ResultsLB.Location = new Point(454, 52);
            ResultsLB.Name = "ResultsLB";
            ResultsLB.Size = new Size(334, 379);
            ResultsLB.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 24);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 8;
            label4.Text = "Results";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 9;
            label5.Text = "Other Functions";
            // 
            // diceinfobtn
            // 
            diceinfobtn.Location = new Point(12, 298);
            diceinfobtn.Name = "diceinfobtn";
            diceinfobtn.Size = new Size(112, 34);
            diceinfobtn.TabIndex = 10;
            diceinfobtn.Text = "Dice Info";
            diceinfobtn.UseVisualStyleBackColor = true;
            diceinfobtn.Click += diceinfobtn_Click;
            // 
            // rollStatsBtn
            // 
            rollStatsBtn.Location = new Point(142, 298);
            rollStatsBtn.Name = "rollStatsBtn";
            rollStatsBtn.Size = new Size(139, 34);
            rollStatsBtn.TabIndex = 11;
            rollStatsBtn.Text = "Rolling Stats";
            rollStatsBtn.UseVisualStyleBackColor = true;
            rollStatsBtn.Click += rollStatsBtn_Click;
            // 
            // RollOrdersBtn
            // 
            RollOrdersBtn.Location = new Point(12, 349);
            RollOrdersBtn.Name = "RollOrdersBtn";
            RollOrdersBtn.Size = new Size(112, 34);
            RollOrdersBtn.TabIndex = 12;
            RollOrdersBtn.Text = "Roll Orders";
            RollOrdersBtn.UseVisualStyleBackColor = true;
            RollOrdersBtn.Click += RollOrdersBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RollOrdersBtn);
            Controls.Add(rollStatsBtn);
            Controls.Add(diceinfobtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ResultsLB);
            Controls.Add(label3);
            Controls.Add(numSidesInput);
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
        private TextBox numSidesInput;
        private Label label3;
        private ListBox ResultsLB;
        private Label label4;
        private Label label5;
        private Button diceinfobtn;
        private Button rollStatsBtn;
        private Button RollOrdersBtn;
    }
}
