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
            ((System.ComponentModel.ISupportInitialize)landscapeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resolutionContainer).BeginInit();
            SuspendLayout();
            // 
            // landscapeBox
            // 
            landscapeBox.Location = new Point(12, 12);
            landscapeBox.Name = "landscapeBox";
            landscapeBox.Size = new Size(800, 800);
            landscapeBox.TabIndex = 0;
            landscapeBox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(818, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Paint";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resolutionContainer
            // 
            resolutionContainer.Location = new Point(818, 12);
            resolutionContainer.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            resolutionContainer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            resolutionContainer.Name = "resolutionContainer";
            resolutionContainer.Size = new Size(120, 23);
            resolutionContainer.TabIndex = 2;
            resolutionContainer.Value = new decimal(new int[] { 20, 0, 0, 0 });
            resolutionContainer.ValueChanged += resolutionContainer_ValueChanged;
            // 
            // consoleBox
            // 
            consoleBox.Location = new Point(818, 70);
            consoleBox.Multiline = true;
            consoleBox.Name = "consoleBox";
            consoleBox.Size = new Size(284, 255);
            consoleBox.TabIndex = 3;
            // 
            // globalTimer
            // 
            globalTimer.Interval = 500;
            globalTimer.Tick += globalTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 861);
            Controls.Add(consoleBox);
            Controls.Add(resolutionContainer);
            Controls.Add(button1);
            Controls.Add(landscapeBox);
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
    }
}