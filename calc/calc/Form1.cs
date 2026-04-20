namespace calc
{
    public partial class Form1 : Form
    {
        double currentValue = 0;
        string currentOperation = "";
        bool isOperationPerformed = false;
        int divisionByZeroAttempts = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;

            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            currentValue = Double.Parse(textBox1.Text);
            currentOperation = button.Text;
            isOperationPerformed = true;
        }

        private void btnEquals(object sender, EventArgs e)
        {
            double secondValue;
            double result = 0;

            if (!Double.TryParse(textBox1.Text, out secondValue))
                return;

            if (currentOperation == "/" && secondValue == 0)
            {
                divisionByZeroAttempts++;

                if (divisionByZeroAttempts >= 3)
                {
                    
                    textBox1.Text = "На ноль делить нельзя!";
                    divisionByZeroAttempts = 0; 
                    currentValue = 0;
                    currentOperation = "";
                    isOperationPerformed = true;

                    
                    button17.Location = new Point(200, 200);
                }
                else
                {

                    MoveEqualsButtonAway();
                }
                return; 
            }

            switch (currentOperation)
            {
                case "+":
                    result = currentValue + secondValue;
                    break;
                case "-":
                    result = currentValue - secondValue;
                    break;
                case "*":
                    result = currentValue * secondValue;
                    break;
                case "/":
                    result = currentValue / secondValue;
                    break;
                default:
                    return;
            }

            textBox1.Text = result.ToString();
            currentValue = result;
            isOperationPerformed = true;
            divisionByZeroAttempts = 0;
        }
        private void MoveEqualsButtonAway()
        {

            Point mousePos = this.PointToClient(Cursor.Position);


            int maxX = this.ClientSize.Width - button17.Width - 20;
            int maxY = this.ClientSize.Height - button17.Height - 40;
            int minX = 20;
            int minY = 100;


            int newX, newY;
            int attempts = 0;

            do
            {
                newX = random.Next(minX, maxX);
                newY = random.Next(minY, maxY);
                attempts++;
            }
            while (Math.Sqrt(Math.Pow(newX - mousePos.X, 2) + Math.Pow(newY - mousePos.Y, 2)) < 80 && attempts < 50);

            button17.Location = new Point(newX, newY);
        }

        private void btnClear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            currentValue = 0;
            currentOperation = "";
            isOperationPerformed = false;
        }
    }
}
