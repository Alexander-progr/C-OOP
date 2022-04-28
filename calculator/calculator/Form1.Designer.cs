namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clean = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.cleanall = new System.Windows.Forms.Button();
            this.rest = new System.Windows.Forms.Button();
            this.divwhole = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.Button();
            this.degree = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.invers = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clean);
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.cleanall);
            this.groupBox1.Controls.Add(this.rest);
            this.groupBox1.Controls.Add(this.divwhole);
            this.groupBox1.Controls.Add(this.random);
            this.groupBox1.Controls.Add(this.degree);
            this.groupBox1.Controls.Add(this.division);
            this.groupBox1.Controls.Add(this.multiply);
            this.groupBox1.Controls.Add(this.minus);
            this.groupBox1.Controls.Add(this.plus);
            this.groupBox1.Controls.Add(this.nine);
            this.groupBox1.Controls.Add(this.eight);
            this.groupBox1.Controls.Add(this.seven);
            this.groupBox1.Controls.Add(this.six);
            this.groupBox1.Controls.Add(this.five);
            this.groupBox1.Controls.Add(this.four);
            this.groupBox1.Controls.Add(this.three);
            this.groupBox1.Controls.Add(this.two);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.comma);
            this.groupBox1.Controls.Add(this.zero);
            this.groupBox1.Controls.Add(this.invers);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(286, 65);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(50, 47);
            this.clean.TabIndex = 12;
            this.clean.Text = "C";
            this.toolTip1.SetToolTip(this.clean, "Стереть последнюю цифру");
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(230, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(106, 47);
            this.result.TabIndex = 21;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // cleanall
            // 
            this.cleanall.Location = new System.Drawing.Point(230, 65);
            this.cleanall.Name = "cleanall";
            this.cleanall.Size = new System.Drawing.Size(50, 47);
            this.cleanall.TabIndex = 20;
            this.cleanall.Text = "CE";
            this.cleanall.UseVisualStyleBackColor = true;
            this.cleanall.Click += new System.EventHandler(this.clean_Click);
            // 
            // rest
            // 
            this.rest.Location = new System.Drawing.Point(286, 171);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(50, 47);
            this.rest.TabIndex = 19;
            this.rest.Text = "%";
            this.toolTip1.SetToolTip(this.rest, "Вычисление остатка");
            this.rest.UseVisualStyleBackColor = true;
            this.rest.Click += new System.EventHandler(this.operation_Click);
            // 
            // divwhole
            // 
            this.divwhole.Location = new System.Drawing.Point(230, 171);
            this.divwhole.Name = "divwhole";
            this.divwhole.Size = new System.Drawing.Size(50, 47);
            this.divwhole.TabIndex = 18;
            this.divwhole.Text = "//";
            this.toolTip1.SetToolTip(this.divwhole, "Деление нацело");
            this.divwhole.UseVisualStyleBackColor = true;
            this.divwhole.Click += new System.EventHandler(this.operation_Click);
            // 
            // random
            // 
            this.random.Location = new System.Drawing.Point(286, 118);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(50, 47);
            this.random.TabIndex = 17;
            this.random.Text = "RND";
            this.toolTip1.SetToolTip(this.random, "Рандомное число в диапазоне");
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.operation_Click);
            // 
            // degree
            // 
            this.degree.Location = new System.Drawing.Point(230, 118);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(50, 47);
            this.degree.TabIndex = 16;
            this.degree.Text = "^";
            this.toolTip1.SetToolTip(this.degree, "Возведение в степень");
            this.degree.UseVisualStyleBackColor = true;
            this.degree.Click += new System.EventHandler(this.operation_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(174, 171);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(50, 47);
            this.division.TabIndex = 15;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operation_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(174, 118);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(50, 47);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(174, 65);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 47);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operation_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(174, 12);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 47);
            this.plus.TabIndex = 12;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operation_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(118, 12);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(50, 47);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.number_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(62, 12);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(50, 47);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.number_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(6, 12);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(50, 47);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.number_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(118, 65);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(50, 47);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.number_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(62, 65);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(50, 47);
            this.five.TabIndex = 7;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.number_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(6, 65);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(50, 47);
            this.four.TabIndex = 6;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.number_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(118, 118);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(50, 47);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.number_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(62, 118);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 47);
            this.two.TabIndex = 4;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.number_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.number_Click);
            // 
            // comma
            // 
            this.comma.Location = new System.Drawing.Point(118, 171);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(50, 47);
            this.comma.TabIndex = 2;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.number_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(62, 171);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(50, 47);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.number_Click);
            // 
            // invers
            // 
            this.invers.Location = new System.Drawing.Point(6, 171);
            this.invers.Name = "invers";
            this.invers.Size = new System.Drawing.Size(50, 47);
            this.invers.TabIndex = 0;
            this.invers.Text = "+-";
            this.toolTip1.SetToolTip(this.invers, "Смена знака");
            this.invers.UseVisualStyleBackColor = true;
            this.invers.Click += new System.EventHandler(this.number_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 28);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(336, 20);
            this.output.TabIndex = 1;
            this.output.Text = "0";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output.WordWrap = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(397, 303);
            this.Controls.Add(this.output);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button invers;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button cleanall;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.Button divwhole;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Button degree;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

