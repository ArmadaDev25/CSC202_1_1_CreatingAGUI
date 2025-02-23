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
            string numOfDice = numdiceInput.Text;
            int numOfDiceInt = 0;
            if (!int.TryParse(numOfDice, out numOfDiceInt)) {
                ErrorLabel.Text = "Please Input a Whole Number";
            
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
