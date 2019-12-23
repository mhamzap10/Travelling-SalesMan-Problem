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
            this.Boy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "House #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Area";
            // 
            // output
            // 
            this.output.EnableAutoDragDrop = true;
            this.output.Location = new System.Drawing.Point(40, 224);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(341, 165);
            this.output.TabIndex = 4;
            this.output.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(102, 77);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(145, 20);
            this.Area.TabIndex = 3;
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(102, 43);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(145, 20);
            this.House.TabIndex = 1;
            this.House.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(316, 33);
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            this.Input.Size = new System.Drawing.Size(371, 162);
            this.Input.TabIndex = 7;
            this.Input.Text = "";
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(517, 224);
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Size = new System.Drawing.Size(170, 20);
            this.Distance.TabIndex = 8;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(517, 277);
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Size = new System.Drawing.Size(170, 20);
            this.Time.TabIndex = 9;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(517, 323);
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Size = new System.Drawing.Size(170, 20);
            this.Cost.TabIndex = 10;
            // 
            // Boy
            // 
            this.Boy.Location = new System.Drawing.Point(517, 373);
            this.Boy.Name = "Boy";
            this.Boy.ReadOnly = true;
            this.Boy.Size = new System.Drawing.Size(170, 20);
            this.Boy.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Expected Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Expected Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Delivery Boy";
            // 
            // ShortestPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Boy);
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
            this.Name = "ShortestPath";
            this.Text = "ShortestPath";
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
        private System.Windows.Forms.TextBox Boy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}