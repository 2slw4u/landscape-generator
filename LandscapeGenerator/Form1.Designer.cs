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
            ApplyDraughtButton = new Button();
            ApplyEarthquakeButton = new Button();
            ApplyVolcanoButton = new Button();
            label3 = new Label();
            AddGrassButton = new Button();
            AddForestButton = new Button();
            AddWaterButton = new Button();
            AddSandButton = new Button();
            AddSnowButton = new Button();
            startStopTimer = new Button();
            AddStoneButton = new Button();
            ((System.ComponentModel.ISupportInitialize)landscapeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resolutionContainer).BeginInit();
            SuspendLayout();
            // 
            // landscapeBox
            // 
            landscapeBox.Enabled = false;
            landscapeBox.Location = new Point(14, 16);
            landscapeBox.Margin = new Padding(3, 4, 3, 4);
            landscapeBox.Name = "landscapeBox";
            landscapeBox.Size = new Size(914, 1067);
            landscapeBox.TabIndex = 0;
            landscapeBox.TabStop = false;
            landscapeBox.Click += landscapeBox_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1155, 33);
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
            resolutionContainer.Location = new Point(1031, 33);
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
            label1.Location = new Point(938, 36);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "MAP SIZE:";
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
            // ApplyDraughtButton
            // 
            ApplyDraughtButton.Location = new Point(936, 180);
            ApplyDraughtButton.Margin = new Padding(3, 4, 3, 4);
            ApplyDraughtButton.Name = "ApplyDraughtButton";
            ApplyDraughtButton.Size = new Size(86, 36);
            ApplyDraughtButton.TabIndex = 6;
            ApplyDraughtButton.Text = "Draught";
            ApplyDraughtButton.UseVisualStyleBackColor = true;
            ApplyDraughtButton.Click += ApplyDraughtButton_Click;
            // 
            // ApplyEarthquakeButton
            // 
            ApplyEarthquakeButton.Location = new Point(1046, 180);
            ApplyEarthquakeButton.Margin = new Padding(3, 4, 3, 4);
            ApplyEarthquakeButton.Name = "ApplyEarthquakeButton";
            ApplyEarthquakeButton.Size = new Size(98, 36);
            ApplyEarthquakeButton.TabIndex = 7;
            ApplyEarthquakeButton.Text = "Earthquake";
            ApplyEarthquakeButton.UseVisualStyleBackColor = true;
            ApplyEarthquakeButton.Click += ApplyEarthquakeButton_Click;
            // 
            // ApplyVolcanoButton
            // 
            ApplyVolcanoButton.Location = new Point(1174, 180);
            ApplyVolcanoButton.Margin = new Padding(3, 4, 3, 4);
            ApplyVolcanoButton.Name = "ApplyVolcanoButton";
            ApplyVolcanoButton.Size = new Size(86, 36);
            ApplyVolcanoButton.TabIndex = 8;
            ApplyVolcanoButton.Text = "Volcano";
            ApplyVolcanoButton.UseVisualStyleBackColor = true;
            ApplyVolcanoButton.Click += ApplyVolcanoButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1074, 243);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 9;
            label3.Text = "ADD";
            // 
            // AddGrassButton
            // 
            AddGrassButton.Location = new Point(934, 277);
            AddGrassButton.Margin = new Padding(3, 4, 3, 4);
            AddGrassButton.Name = "AddGrassButton";
            AddGrassButton.Size = new Size(86, 40);
            AddGrassButton.TabIndex = 10;
            AddGrassButton.Text = "Grass";
            AddGrassButton.UseVisualStyleBackColor = true;
            AddGrassButton.Click += AddGrassButton_Click;
            // 
            // AddForestButton
            // 
            AddForestButton.Location = new Point(1058, 277);
            AddForestButton.Margin = new Padding(3, 4, 3, 4);
            AddForestButton.Name = "AddForestButton";
            AddForestButton.Size = new Size(86, 40);
            AddForestButton.TabIndex = 11;
            AddForestButton.Text = "Forest";
            AddForestButton.UseVisualStyleBackColor = true;
            AddForestButton.Click += AddForestButton_Click;
            // 
            // AddWaterButton
            // 
            AddWaterButton.Location = new Point(1174, 277);
            AddWaterButton.Margin = new Padding(3, 4, 3, 4);
            AddWaterButton.Name = "AddWaterButton";
            AddWaterButton.Size = new Size(86, 40);
            AddWaterButton.TabIndex = 12;
            AddWaterButton.Text = "Water";
            AddWaterButton.UseVisualStyleBackColor = true;
            AddWaterButton.Click += AddWaterButton_Click;
            // 
            // AddSandButton
            // 
            AddSandButton.Location = new Point(936, 325);
            AddSandButton.Margin = new Padding(3, 4, 3, 4);
            AddSandButton.Name = "AddSandButton";
            AddSandButton.Size = new Size(86, 40);
            AddSandButton.TabIndex = 13;
            AddSandButton.Text = "Sand";
            AddSandButton.UseVisualStyleBackColor = true;
            AddSandButton.Click += AddSandButton_Click;
            // 
            // AddSnowButton
            // 
            AddSnowButton.Location = new Point(1058, 325);
            AddSnowButton.Margin = new Padding(3, 4, 3, 4);
            AddSnowButton.Name = "AddSnowButton";
            AddSnowButton.Size = new Size(86, 40);
            AddSnowButton.TabIndex = 14;
            AddSnowButton.Text = "Snow";
            AddSnowButton.UseVisualStyleBackColor = true;
            AddSnowButton.Click += AddSnowButton_Click;
            // 
            // startStopTimer
            // 
            startStopTimer.Enabled = false;
            startStopTimer.Location = new Point(1058, 84);
            startStopTimer.Margin = new Padding(3, 4, 3, 4);
            startStopTimer.Name = "startStopTimer";
            startStopTimer.Size = new Size(86, 31);
            startStopTimer.TabIndex = 15;
            startStopTimer.Text = "Стоп";
            startStopTimer.UseVisualStyleBackColor = true;
            startStopTimer.Click += startStopTimer_Click;
            // 
            // AddStoneButton
            // 
            AddStoneButton.Location = new Point(1173, 325);
            AddStoneButton.Margin = new Padding(3, 4, 3, 4);
            AddStoneButton.Name = "AddStoneButton";
            AddStoneButton.Size = new Size(86, 40);
            AddStoneButton.TabIndex = 16;
            AddStoneButton.Text = "Stone";
            AddStoneButton.UseVisualStyleBackColor = true;
            AddStoneButton.Click += AddStoneButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 1055);
            Controls.Add(AddStoneButton);
            Controls.Add(startStopTimer);
            Controls.Add(AddSnowButton);
            Controls.Add(AddSandButton);
            Controls.Add(AddWaterButton);
            Controls.Add(AddForestButton);
            Controls.Add(AddGrassButton);
            Controls.Add(label3);
            Controls.Add(ApplyVolcanoButton);
            Controls.Add(ApplyEarthquakeButton);
            Controls.Add(ApplyDraughtButton);
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
        private Button ApplyDraughtButton;
        private Button ApplyEarthquakeButton;
        private Button ApplyVolcanoButton;
        private Label label3;
        private Button AddGrassButton;
        private Button AddForestButton;
        private Button AddWaterButton;
        private Button AddSandButton;
        private Button AddSnowButton;
        private Button startStopTimer;
        private Button AddStoneButton;
    }
}