namespace CalculatorApp
{
   partial class Calculator
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
         txtDisplay = new TextBox();
         btn7 = new Button();
         btn4 = new Button();
         btn_division = new Button();
         btn9 = new Button();
         btn8 = new Button();
         btn5 = new Button();
         btn6 = new Button();
         btn_mul = new Button();
         btn1 = new Button();
         btn2 = new Button();
         btn3 = new Button();
         btn_minus = new Button();
         btn_C = new Button();
         btn0 = new Button();
         btn_equal = new Button();
         btn_plus = new Button();
         SuspendLayout();
         // 
         // txtDisplay
         // 
         txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         txtDisplay.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
         txtDisplay.Location = new Point(12, 31);
         txtDisplay.Multiline = true;
         txtDisplay.Name = "txtDisplay";
         txtDisplay.Size = new Size(344, 97);
         txtDisplay.TabIndex = 0;
         txtDisplay.TextAlign = HorizontalAlignment.Right;
         txtDisplay.TextChanged += textBox1_TextChanged;
         // 
         // btn7
         // 
         btn7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn7.BackColor = Color.WhiteSmoke;
         btn7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn7.ForeColor = Color.Black;
         btn7.Location = new Point(12, 176);
         btn7.Name = "btn7";
         btn7.Size = new Size(65, 65);
         btn7.TabIndex = 1;
         btn7.Text = "7";
         btn7.UseVisualStyleBackColor = false;
         btn7.Click += button1_Click;
         // 
         // btn4
         // 
         btn4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn4.BackColor = Color.WhiteSmoke;
         btn4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn4.ForeColor = Color.Black;
         btn4.Location = new Point(12, 251);
         btn4.Name = "btn4";
         btn4.Size = new Size(65, 65);
         btn4.TabIndex = 2;
         btn4.Text = "4";
         btn4.UseVisualStyleBackColor = false;
         btn4.Click += button1_Click_1;
         // 
         // btn_division
         // 
         btn_division.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn_division.BackColor = Color.WhiteSmoke;
         btn_division.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
         btn_division.ForeColor = Color.FromArgb(255, 128, 0);
         btn_division.Location = new Point(288, 176);
         btn_division.Name = "btn_division";
         btn_division.Size = new Size(65, 65);
         btn_division.TabIndex = 3;
         btn_division.Text = "/";
         btn_division.UseVisualStyleBackColor = false;
         btn_division.Click += button2_Click;
         // 
         // btn9
         // 
         btn9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn9.BackColor = Color.WhiteSmoke;
         btn9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn9.ForeColor = Color.Black;
         btn9.Location = new Point(196, 176);
         btn9.Name = "btn9";
         btn9.Size = new Size(65, 65);
         btn9.TabIndex = 4;
         btn9.Text = "9";
         btn9.UseVisualStyleBackColor = false;
         btn9.Click += button3_Click;
         // 
         // btn8
         // 
         btn8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn8.BackColor = Color.WhiteSmoke;
         btn8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn8.ForeColor = Color.Black;
         btn8.Location = new Point(102, 176);
         btn8.Name = "btn8";
         btn8.Size = new Size(65, 65);
         btn8.TabIndex = 5;
         btn8.Text = "8";
         btn8.UseVisualStyleBackColor = false;
         btn8.Click += button4_Click;
         // 
         // btn5
         // 
         btn5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn5.BackColor = Color.WhiteSmoke;
         btn5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn5.ForeColor = Color.Black;
         btn5.Location = new Point(102, 251);
         btn5.Name = "btn5";
         btn5.Size = new Size(65, 65);
         btn5.TabIndex = 6;
         btn5.Text = "5";
         btn5.UseVisualStyleBackColor = false;
         btn5.Click += button5_Click;
         // 
         // btn6
         // 
         btn6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn6.BackColor = Color.WhiteSmoke;
         btn6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn6.ForeColor = Color.Black;
         btn6.Location = new Point(196, 251);
         btn6.Name = "btn6";
         btn6.Size = new Size(65, 65);
         btn6.TabIndex = 7;
         btn6.Text = "6";
         btn6.UseVisualStyleBackColor = false;
         btn6.Click += button6_Click;
         // 
         // btn_mul
         // 
         btn_mul.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn_mul.BackColor = Color.WhiteSmoke;
         btn_mul.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
         btn_mul.ForeColor = Color.FromArgb(255, 128, 0);
         btn_mul.Location = new Point(288, 251);
         btn_mul.Name = "btn_mul";
         btn_mul.Size = new Size(65, 65);
         btn_mul.TabIndex = 8;
         btn_mul.Text = "*";
         btn_mul.UseVisualStyleBackColor = false;
         btn_mul.Click += button7_Click;
         // 
         // btn1
         // 
         btn1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn1.BackColor = Color.WhiteSmoke;
         btn1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn1.ForeColor = Color.Black;
         btn1.Location = new Point(12, 327);
         btn1.Name = "btn1";
         btn1.Size = new Size(65, 65);
         btn1.TabIndex = 9;
         btn1.Text = "1";
         btn1.UseVisualStyleBackColor = false;
         btn1.Click += button8_Click;
         // 
         // btn2
         // 
         btn2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn2.BackColor = Color.WhiteSmoke;
         btn2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn2.ForeColor = Color.Black;
         btn2.Location = new Point(102, 327);
         btn2.Name = "btn2";
         btn2.Size = new Size(65, 65);
         btn2.TabIndex = 10;
         btn2.Text = "2";
         btn2.UseVisualStyleBackColor = false;
         btn2.Click += button9_Click;
         // 
         // btn3
         // 
         btn3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn3.BackColor = Color.WhiteSmoke;
         btn3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn3.ForeColor = Color.Black;
         btn3.Location = new Point(196, 327);
         btn3.Name = "btn3";
         btn3.Size = new Size(65, 65);
         btn3.TabIndex = 11;
         btn3.Text = "3";
         btn3.UseVisualStyleBackColor = false;
         btn3.Click += button10_Click;
         // 
         // btn_minus
         // 
         btn_minus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn_minus.BackColor = Color.WhiteSmoke;
         btn_minus.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
         btn_minus.ForeColor = Color.FromArgb(255, 128, 0);
         btn_minus.Location = new Point(288, 327);
         btn_minus.Name = "btn_minus";
         btn_minus.Size = new Size(65, 65);
         btn_minus.TabIndex = 12;
         btn_minus.Text = "-";
         btn_minus.UseVisualStyleBackColor = false;
         btn_minus.Click += button11_Click;
         // 
         // btn_C
         // 
         btn_C.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn_C.BackColor = Color.WhiteSmoke;
         btn_C.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn_C.ForeColor = Color.FromArgb(255, 128, 0);
         btn_C.Location = new Point(102, 403);
         btn_C.Name = "btn_C";
         btn_C.Size = new Size(65, 65);
         btn_C.TabIndex = 13;
         btn_C.Text = "C";
         btn_C.UseVisualStyleBackColor = false;
         btn_C.Click += button12_Click;
         // 
         // btn0
         // 
         btn0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn0.BackColor = Color.WhiteSmoke;
         btn0.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btn0.ForeColor = Color.Black;
         btn0.Location = new Point(12, 403);
         btn0.Name = "btn0";
         btn0.Size = new Size(65, 65);
         btn0.TabIndex = 14;
         btn0.Text = "0";
         btn0.UseVisualStyleBackColor = false;
         btn0.Click += button13_Click;
         // 
         // btn_equal
         // 
         btn_equal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn_equal.BackColor = Color.WhiteSmoke;
         btn_equal.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
         btn_equal.ForeColor = Color.FromArgb(255, 128, 0);
         btn_equal.Location = new Point(196, 403);
         btn_equal.Name = "btn_equal";
         btn_equal.Size = new Size(65, 65);
         btn_equal.TabIndex = 15;
         btn_equal.Text = "=";
         btn_equal.UseVisualStyleBackColor = false;
         btn_equal.Click += button14_Click;
         // 
         // btn_plus
         // 
         btn_plus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         btn_plus.BackColor = Color.WhiteSmoke;
         btn_plus.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
         btn_plus.ForeColor = Color.FromArgb(255, 128, 0);
         btn_plus.Location = new Point(288, 403);
         btn_plus.Name = "btn_plus";
         btn_plus.Size = new Size(65, 65);
         btn_plus.TabIndex = 16;
         btn_plus.Text = "+";
         btn_plus.UseVisualStyleBackColor = false;
         btn_plus.Click += button15_Click;
         // 
         // Calculator
         // 
         AutoScaleDimensions = new SizeF(10F, 25F);
         AutoScaleMode = AutoScaleMode.Font;
         BackColor = Color.White;
         ClientSize = new Size(368, 494);
         Controls.Add(btn_plus);
         Controls.Add(btn_equal);
         Controls.Add(btn0);
         Controls.Add(btn_C);
         Controls.Add(btn_minus);
         Controls.Add(btn3);
         Controls.Add(btn2);
         Controls.Add(btn1);
         Controls.Add(btn_mul);
         Controls.Add(btn6);
         Controls.Add(btn5);
         Controls.Add(btn8);
         Controls.Add(btn9);
         Controls.Add(btn_division);
         Controls.Add(btn4);
         Controls.Add(btn7);
         Controls.Add(txtDisplay);
         ForeColor = SystemColors.ActiveCaptionText;
         MaximizeBox = false;
         Name = "Calculator";
         ShowIcon = false;
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Calculator";
         Load += Form1_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private TextBox txtDisplay;
      private Button btn7;
      private Button btn4;
      private Button btn_division;
      private Button btn9;
      private Button btn8;
      private Button btn5;
      private Button btn6;
      private Button btn_mul;
      private Button btn1;
      private Button btn2;
      private Button btn3;
      private Button btn_minus;
      private Button btn_C;
      private Button btn0;
      private Button btn_equal;
      private Button btn_plus;
   }
}
