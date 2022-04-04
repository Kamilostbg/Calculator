namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }
                
        private void Button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
        }


        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {                
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
            value = Int32.Parse(result.Text);
            operation = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}