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
            int numOfDiceInt = 0; // contains the Inputted number of dice as an Int
            string numOfSides = numSidesInput.Text; // Contains the Number of Sides to Roll
            int numOfSidesInt = 0;// Contains the number if sides as an int
            // Checks to make sure the user input a number in the number of dice section
            if (!int.TryParse(numOfDice, out numOfDiceInt))
            {
                ErrorLabel.Text = "Number of Dice is Not A Whole Number";

            }
            else
            {
                // Converts the numOfDice to an int
                numOfDiceInt = Convert.ToInt32(numOfDice);
                // Checks to make sure the user inputs the number 1
                if (numOfDiceInt != 1)
                {

                    ErrorLabel.Text = "You can only Roll 1 dice";

                }
                else {
                    // Checks to make sure the number of Sides in a dice is a whole number
                    if (!int.TryParse(numOfSides, out numOfSidesInt))
                    {
                        ErrorLabel.Text = "Number of Sides is Not A Whole Number";

                    }
                    else
                    {
                        // Takes the number of Sides entered by the user anc converts it to an integer
                        numOfSidesInt = Convert.ToInt32(numOfSides);
                        // Object Refrence for the Random number to be generated.
                        // I got an error for missing object refrence and this fixed it.
                        Random ran = new Random();
                        //Generates a random number based on user input and sets numOutputInt to it.
                        int numOutputInt = ran.Next(0, numOfSidesInt);
                        // Generates a string by converting the Int value of numOutputIn to a String
                        string snumOutput = numOutputInt.ToString();
                        // Displays the results of the Dice roll to the user
                        ErrorLabel.Text = snumOutput;

                    }
                }
                

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
