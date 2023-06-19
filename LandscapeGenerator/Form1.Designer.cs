namespace LandscapeGenerator
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            landscapeBox = new PictureBox();
            button1 = new Button();
            resolutionContainer = new NumericUpDown();
            consoleBox = new TextBox();
            globalTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)landscapeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resolutionContainer).BeginInit();
            SuspendLayout();
            // 
            // landscapeBox
            // 
            landscapeBox.Location = new Point(14, 16);
            landscapeBox.Margin = new Padding(3, 4, 3, 4);
            landscapeBox.Name = "landscapeBox";
            landscapeBox.Size = new Size(914, 1067);
            landscapeBox.TabIndex = 0;
            landscapeBox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(1153, 61);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 1;
            button1.Text = "Paint";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resolutionContainer
            // 
            resolutionContainer.Location = new Point(1029, 62);
            resolutionContainer.Margin = new Padding(3, 4, 3, 4);
            resolutionContainer.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            resolutionContainer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            resolutionContainer.Name = "resolutionContainer";
            resolutionContainer.Size = new Size(86, 27);
            resolutionContainer.TabIndex = 2;
            resolutionContainer.Value = new decimal(new int[] { 20, 0, 0, 0 });
            resolutionContainer.ValueChanged += resolutionContainer_ValueChanged;
            // 
            // consoleBox
            // 
            consoleBox.Location = new Point(936, 492);
            consoleBox.Margin = new Padding(3, 4, 3, 4);
            consoleBox.Multiline = true;
            consoleBox.Name = "consoleBox";
            consoleBox.Size = new Size(324, 339);
            consoleBox.TabIndex = 3;
            // 
            // globalTimer
            // 
            globalTimer.Interval = 1000;
            globalTimer.Tick += globalTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(936, 64);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "MAP SIZE:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1058, 131);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "DISASTER";
            // 
            // button2
            // 
            button2.Location = new Point(936, 180);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 36);
            button2.TabIndex = 6;
            button2.Text = "Draught";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1046, 180);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(98, 36);
            button3.TabIndex = 7;
            button3.Text = "Earthquake";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1174, 180);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 36);
            button4.TabIndex = 8;
            button4.Text = "Tornado";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1074, 242);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 9;
            label3.Text = "ADD";
            label3.Click += label3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(934, 278);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 40);
            button5.TabIndex = 10;
            button5.Text = "Grass";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1058, 278);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 40);
            button6.TabIndex = 11;
            button6.Text = "Forest";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(1174, 278);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 40);
            button7.TabIndex = 12;
            button7.Text = "Water";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(996, 326);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 40);
            button8.TabIndex = 13;
            button8.Text = "Sand";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(1118, 326);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(86, 40);
            button9.TabIndex = 14;
            button9.Text = "Snow";
            button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 1055);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(consoleBox);
            Controls.Add(resolutionContainer);
            Controls.Add(button1);
            Controls.Add(landscapeBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)landscapeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)resolutionContainer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox landscapeBox;
        private Button button1;
        private NumericUpDown resolutionContainer;
        private TextBox consoleBox;
        private System.Windows.Forms.Timer globalTimer;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}