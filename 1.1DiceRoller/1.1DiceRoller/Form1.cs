namespace _1._1DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Example Data that contains how many times each of the sides has been rolled on a d6
        int[] arrRollStats = { 3, 1, 0, 2, 3, 6 };
        // 2d Array that stores info on the dice, IE what game system they are used in
        string[,] diceInfo = {
            {"D20", "Dungeons And Dragons"},
            {"D6", "Warhammer 40k Tabletop"},
            {"D8", "Dungeons And Dragons"},
            {"D10", "Liars Dice"},
            {"Order Dice", "Bolt Action" }

        };
        // Stores the possible outcomes for an Order Dice
        string[] orderDice = { "Fire", "Advance", "Run", "Ambush", "Rally", "Down" };


        private void button1_Click(object sender, EventArgs e)
        {
            string numOfDice = numdiceInput.Text; // Contains the Number of Dice to Roll
            int numOfDiceInt = 0; // contains the Inputted number of dice as an Int
            string numOfSides = numSidesInput.Text; // Contains the Number of Sides to Roll
            int numOfSidesInt = 0;// Contains the number if sides as an int
            // Checks to make sure the user input a number in the number of dice section
            if (!int.TryParse(numOfDice, out numOfDiceInt))
            {
                ResultsLB.Items.Add("Number of Dice is Not A Whole Number");

            }
            else
            {
                // Converts the numOfDice to an int
                numOfDiceInt = Convert.ToInt32(numOfDice);
                // Checks to make sure the user inputs the number 1
                if (numOfDiceInt != 1)
                {

                    ResultsLB.Items.Add("Number of Dice is Not A Whole Number");

                }
                else
                {
                    // Checks to make sure the number of Sides in a dice is a whole number
                    if (!int.TryParse(numOfSides, out numOfSidesInt))
                    {
                        ResultsLB.Items.Add("Number of Dice is Not A Whole Number");

                    }
                    else
                    {
                        // Takes the number of Sides entered by the user and converts it to an integer
                        numOfSidesInt = Convert.ToInt32(numOfSides);
                        // Object Refrence for the Random number to be generated.
                        // I got an error for missing object refrence and this fixed it.
                        Random ran = new Random();
                        //Generates a random number based on user input and sets numOutputInt to it.
                        int numOutputInt = ran.Next(0, numOfSidesInt);
                        // Generates a string by converting the Int value of numOutputIn to a String
                        string snumOutput = numOutputInt.ToString();
                        // Displays the results of the Dice roll to the user
                        ResultsLB.Items.Add(snumOutput);

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void diceinfobtn_Click(object sender, EventArgs e)
        {
            // Loops through the dice info array, the number of times the array loops is 5 which is the number of indexes in the array
            for (int i = 0; i < 5; i++)
            {
                // Adds the item within the array with the corresponding index into the list box
                ResultsLB.Items.Add(diceInfo[i, 0] + " Used In " + diceInfo[i, 1]);

            }

        }

        private void rollStatsBtn_Click(object sender, EventArgs e)
        {
            // For loop that loops through the , the length of the array determines how many times it will run
            for (int i = 0; i < arrRollStats.Length; i++)
            {
                // Adds the item within the array with the corresponding index into the list box
                ResultsLB.Items.Add(arrRollStats[i]);

            }
        }

        // Button that allows the user to roll an orders dice
        private void RollOrdersBtn_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            //Generates a random number between that is any where from 0 to 5
            int numOutputInt = ran.Next(0, 6);
            // The generated number is used as the index for the orderDice array
            // The result is then added to the Results list box
            ResultsLB.Items.Add(orderDice[numOutputInt]);
        }
    }
}
