namespace CalculatorApp
{
   public partial class Calculator : Form
   {
      public Calculator()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      string CalTotal;
      int num1;
      int num2;
      string operation;
      int result;

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "7";
      }

      private void button4_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "8";
      }

      private void button3_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "9";
      }

      private void button2_Click(object sender, EventArgs e)
      {
         operation = "/";
         num1 = int.Parse(txtDisplay.Text);

         txtDisplay.Clear();
      }

      private void button1_Click_1(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "4";
      }

      private void button5_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "5";
      }

      private void button6_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "6";
      }

      private void button7_Click(object sender, EventArgs e)
      {
         operation = "*";
         num1 = int.Parse(txtDisplay.Text);

         txtDisplay.Clear();
      }

      private void button8_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "1";
      }

      private void button9_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "2";
      }

      private void button10_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "3";
      }

      private void button11_Click(object sender, EventArgs e)
      {
         operation = "-";
         num1 = int.Parse(txtDisplay.Text);

         txtDisplay.Clear();
      }

      private void button12_Click(object sender, EventArgs e)
      {
         txtDisplay.Clear();
      }

      private void button13_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = txtDisplay.Text + "0";
      }

      private void button14_Click(object sender, EventArgs e)
      {
         num2 = int.Parse(txtDisplay.Text);

         if (operation == "+")
            result = num1 + num2;

         if (operation == "-")
            result = num1 - num2;

         if (operation == "*")
            result = num1 * num2;

         if (operation == "/")
            result = num1 / num2;

         txtDisplay.Text = result + "";
      }

      private void button15_Click(object sender, EventArgs e)
      {
         operation = "+";
         num1 = int.Parse(txtDisplay.Text);

         txtDisplay.Clear();
      }
   }
}