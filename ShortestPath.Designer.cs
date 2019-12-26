namespace Travelling_SalesMan_Problem
{
    partial class ShortestPath
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.TextBox();
            this.House = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Distance = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.DBoy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.RouteTimer = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "House #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Area";
            // 
            // output
            // 
            this.output.EnableAutoDragDrop = true;
            this.output.Location = new System.Drawing.Point(60, 276);
            this.output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(510, 202);
            this.output.TabIndex = 4;
            this.output.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(153, 95);
            this.Area.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(216, 22);
            this.Area.TabIndex = 3;
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(153, 53);
            this.House.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(216, 22);
            this.House.TabIndex = 1;
            this.House.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 212);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(474, 41);
            this.Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            this.Input.Size = new System.Drawing.Size(554, 198);
            this.Input.TabIndex = 7;
            this.Input.Text = "";
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(776, 276);
            this.Distance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Size = new System.Drawing.Size(253, 22);
            this.Distance.TabIndex = 8;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(776, 341);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Size = new System.Drawing.Size(253, 22);
            this.Time.TabIndex = 9;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(776, 398);
            this.Cost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Size = new System.Drawing.Size(253, 22);
            this.Cost.TabIndex = 10;
            // 
            // DBoy
            // 
            this.DBoy.Location = new System.Drawing.Point(776, 459);
            this.DBoy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBoy.Name = "DBoy";
            this.DBoy.ReadOnly = true;
            this.DBoy.Size = new System.Drawing.Size(253, 22);
            this.DBoy.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Expected Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 406);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Expected Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 463);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Delivery Boy";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 519);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 48);
            this.button3.TabIndex = 16;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 519);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 48);
            this.button4.TabIndex = 17;
            this.button4.Text = "Add Delivery Boy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(624, 519);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 48);
            this.button5.TabIndex = 18;
            this.button5.Text = "Send Email";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(538, 14);
            this.second.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.second.Name = "second";
            this.second.ReadOnly = true;
            this.second.Size = new System.Drawing.Size(96, 22);
            this.second.TabIndex = 19;
            this.second.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Seconds";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick_1);
            // 
            // RouteTimer
            // 
            this.RouteTimer.Interval = 60000;
            this.RouteTimer.Tick += new System.EventHandler(this.RouteTimer_Tick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(898, 519);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 48);
            this.button6.TabIndex = 22;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(754, 10);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 28);
            this.button7.TabIndex = 23;
            this.button7.Text = "Start";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(916, 10);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 28);
            this.button8.TabIndex = 24;
            this.button8.Text = "Stop";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(347, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Home Delivery Management System";
            // 
            // ShortestPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 582);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.second);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DBoy);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.House);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShortestPath";
            this.Text = "Smart Home Delivery";
            this.Load += new System.EventHandler(this.ShortestPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.TextBox House;
        public System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.TextBox Distance;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox DBoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer RouteTimer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
    }
}