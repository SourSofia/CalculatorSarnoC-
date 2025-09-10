namespace SarnoCalculatorC_
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Evaluate()
        {
            if (operationPending && currentInput != "")
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        else
                        {
                            textBox1.Text = "Error";
                            currentInput = "";
                            operationPending = false;
                            return;
                        }
                        break;
                }

                textBox1.Text = result.ToString();
                currentInput = "";
            }
        }

        // number buttons
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        // operator buttons
        private void button12_Click(object sender, EventArgs e) // +
        {
            if (operationPending && currentInput != "")
            {
                Evaluate();
            }
            else if (currentInput != "")
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }

            Button button = (Button)sender;
            operation = button.Text;
            operationPending = true;
        }

        private void button11_Click(object sender, EventArgs e) // 0
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button10_Click(object sender, EventArgs e) // -
        {
            if (operationPending && currentInput != "")
            {
                Evaluate();
            }
            else if (currentInput != "")
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }

            Button button = (Button)sender;
            operation = button.Text;
            operationPending = true;
        }

        private void button16_Click(object sender, EventArgs e) // *
        {
            if (operationPending && currentInput != "")
            {
                Evaluate();
            }
            else if (currentInput != "")
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }

            Button button = (Button)sender;
            operation = button.Text;
            operationPending = true;
        }

        private void button15_Click(object sender, EventArgs e) // /
        {
            if (operationPending && currentInput != "")
            {
                Evaluate();
            }
            else if (currentInput != "")
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }

            Button button = (Button)sender;
            operation = button.Text;
            operationPending = true;
        }

        private void button13_Click(object sender, EventArgs e) // =
        {
            Evaluate();
            operation = "";
            operationPending = false;
        }

        private void button14_Click(object sender, EventArgs e) // clear
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

