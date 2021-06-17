namespace CSharpPractice
{
    partial class calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(18, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(309, 22);
            this.txtResult.TabIndex = 0;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(18, 63);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(57, 43);
            this.seven.TabIndex = 1;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(81, 63);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(57, 43);
            this.eight.TabIndex = 2;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(144, 63);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(57, 43);
            this.nine.TabIndex = 3;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(18, 112);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(57, 43);
            this.four.TabIndex = 4;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(81, 112);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(57, 43);
            this.five.TabIndex = 5;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(144, 112);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(57, 43);
            this.six.TabIndex = 6;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(18, 161);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(57, 43);
            this.one.TabIndex = 7;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(81, 161);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(57, 43);
            this.two.TabIndex = 8;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(144, 161);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(57, 43);
            this.three.TabIndex = 9;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(207, 112);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(57, 43);
            this.multiplication.TabIndex = 10;
            this.multiplication.TabStop = false;
            this.multiplication.Text = "X";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.operator_click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(207, 161);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(57, 43);
            this.subtraction.TabIndex = 11;
            this.subtraction.TabStop = false;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.operator_click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(207, 210);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(57, 46);
            this.addition.TabIndex = 13;
            this.addition.TabStop = false;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.operator_click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(18, 213);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(120, 43);
            this.zero.TabIndex = 15;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(207, 63);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(57, 43);
            this.division.TabIndex = 16;
            this.division.TabStop = false;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operator_click);
            // 
            // clearEntry
            // 
            this.clearEntry.Location = new System.Drawing.Point(270, 63);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(57, 43);
            this.clearEntry.TabIndex = 17;
            this.clearEntry.TabStop = false;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = true;
            this.clearEntry.Click += new System.EventHandler(this.button12_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(270, 112);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(57, 43);
            this.button17.TabIndex = 18;
            this.button17.TabStop = false;
            this.button17.Text = "C";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(270, 210);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(57, 46);
            this.equals.TabIndex = 19;
            this.equals.TabStop = false;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.button18_Click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.Color.White;
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(22, 14);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(46, 17);
            this.equation.TabIndex = 20;
            this.equation.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // decimalPoint
            // 
            this.decimalPoint.Location = new System.Drawing.Point(144, 213);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(57, 43);
            this.decimalPoint.TabIndex = 22;
            this.decimalPoint.TabStop = false;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = true;
            this.decimalPoint.Click += new System.EventHandler(this.button_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(270, 161);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(57, 43);
            this.btnBackspace.TabIndex = 23;
            this.btnBackspace.TabStop = false;
            this.btnBackspace.Text = "<<";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 291);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.division);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.equation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.Button btnBackspace;
    }
}