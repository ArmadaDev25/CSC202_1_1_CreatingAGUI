namespace _1._1DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numOfDice = numdiceInput.Text; // Contains the Number of Dice to Roll
            int numOfDiceInt = 0;
            string numOfSides = numSidesInput.Text; // Contains the Number of Sides to Roll
            int numOfSidesInt = 0;
            if (!int.TryParse(numOfDice, out numOfDiceInt))
            {
                ErrorLabel.Text = "Number of Dice is Not A Whole Number";

            }
            else {
                // Checks to make sure the number of Sides in a dice is a whole number
                if (!int.TryParse(numOfSides, out numOfSidesInt))
                {
                    ErrorLabel.Text = "Number of Sides is Not A Whole Number";

                }
                else {

                    numOfSidesInt = Convert.ToInt32(numOfSides);

                    Random ran = new Random();
                    int numOutput = ran.Next(0,6);
                    string snumOutput = numOutput.ToString();
                    ErrorLabel.Text = snumOutput; 

                }
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
