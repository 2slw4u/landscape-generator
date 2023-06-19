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
            startButton = new Button();
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
            landscapeBox.Location = new Point(12, 12);
            landscapeBox.Name = "landscapeBox";
            landscapeBox.Size = new Size(800, 800);
            landscapeBox.TabIndex = 0;
            landscapeBox.TabStop = false;
            landscapeBox.Click += landscapeBox_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(1011, 25);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 21);
            startButton.TabIndex = 1;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // resolutionContainer
            // 
            resolutionContainer.Location = new Point(902, 25);
            resolutionContainer.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            resolutionContainer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            resolutionContainer.Name = "resolutionContainer";
            resolutionContainer.Size = new Size(75, 23);
            resolutionContainer.TabIndex = 2;
            resolutionContainer.Value = new decimal(new int[] { 20, 0, 0, 0 });
            resolutionContainer.ValueChanged += resolutionContainer_ValueChanged;
            // 
            // consoleBox
            // 
            consoleBox.Location = new Point(819, 369);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(821, 27);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "MAP SIZE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(926, 98);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "DISASTER";
            // 
            // ApplyDraughtButton
            // 
            ApplyDraughtButton.Location = new Point(819, 135);
            ApplyDraughtButton.Name = "ApplyDraughtButton";
            ApplyDraughtButton.Size = new Size(75, 27);
            ApplyDraughtButton.TabIndex = 6;
            ApplyDraughtButton.Text = "Draught";
            ApplyDraughtButton.UseVisualStyleBackColor = true;
            ApplyDraughtButton.Click += ApplyDraughtButton_Click;
            // 
            // ApplyEarthquakeButton
            // 
            ApplyEarthquakeButton.Location = new Point(915, 135);
            ApplyEarthquakeButton.Name = "ApplyEarthquakeButton";
            ApplyEarthquakeButton.Size = new Size(86, 27);
            ApplyEarthquakeButton.TabIndex = 7;
            ApplyEarthquakeButton.Text = "Earthquake";
            ApplyEarthquakeButton.UseVisualStyleBackColor = true;
            ApplyEarthquakeButton.Click += ApplyEarthquakeButton_Click;
            // 
            // ApplyVolcanoButton
            // 
            ApplyVolcanoButton.Location = new Point(1027, 135);
            ApplyVolcanoButton.Name = "ApplyVolcanoButton";
            ApplyVolcanoButton.Size = new Size(75, 27);
            ApplyVolcanoButton.TabIndex = 8;
            ApplyVolcanoButton.Text = "Volcano";
            ApplyVolcanoButton.UseVisualStyleBackColor = true;
            ApplyVolcanoButton.Click += ApplyVolcanoButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(940, 182);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "ADD";
            // 
            // AddGrassButton
            // 
            AddGrassButton.Location = new Point(817, 208);
            AddGrassButton.Name = "AddGrassButton";
            AddGrassButton.Size = new Size(75, 30);
            AddGrassButton.TabIndex = 10;
            AddGrassButton.Text = "Grass";
            AddGrassButton.UseVisualStyleBackColor = true;
            AddGrassButton.Click += AddGrassButton_Click;
            // 
            // AddForestButton
            // 
            AddForestButton.Location = new Point(926, 208);
            AddForestButton.Name = "AddForestButton";
            AddForestButton.Size = new Size(75, 30);
            AddForestButton.TabIndex = 11;
            AddForestButton.Text = "Forest";
            AddForestButton.UseVisualStyleBackColor = true;
            AddForestButton.Click += AddForestButton_Click;
            // 
            // AddWaterButton
            // 
            AddWaterButton.Location = new Point(1027, 208);
            AddWaterButton.Name = "AddWaterButton";
            AddWaterButton.Size = new Size(75, 30);
            AddWaterButton.TabIndex = 12;
            AddWaterButton.Text = "Water";
            AddWaterButton.UseVisualStyleBackColor = true;
            AddWaterButton.Click += AddWaterButton_Click;
            // 
            // AddSandButton
            // 
            AddSandButton.Location = new Point(819, 244);
            AddSandButton.Name = "AddSandButton";
            AddSandButton.Size = new Size(75, 30);
            AddSandButton.TabIndex = 13;
            AddSandButton.Text = "Sand";
            AddSandButton.UseVisualStyleBackColor = true;
            AddSandButton.Click += AddSandButton_Click;
            // 
            // AddSnowButton
            // 
            AddSnowButton.Location = new Point(926, 244);
            AddSnowButton.Name = "AddSnowButton";
            AddSnowButton.Size = new Size(75, 30);
            AddSnowButton.TabIndex = 14;
            AddSnowButton.Text = "Snow";
            AddSnowButton.UseVisualStyleBackColor = true;
            AddSnowButton.Click += AddSnowButton_Click;
            // 
            // startStopTimer
            // 
            startStopTimer.Enabled = false;
            startStopTimer.Location = new Point(926, 63);
            startStopTimer.Name = "startStopTimer";
            startStopTimer.Size = new Size(75, 23);
            startStopTimer.TabIndex = 15;
            startStopTimer.Text = "Стоп";
            startStopTimer.UseVisualStyleBackColor = true;
            startStopTimer.Click += startStopTimer_Click;
            // 
            // AddStoneButton
            // 
            AddStoneButton.Location = new Point(1026, 244);
            AddStoneButton.Name = "AddStoneButton";
            AddStoneButton.Size = new Size(75, 30);
            AddStoneButton.TabIndex = 16;
            AddStoneButton.Text = "Stone";
            AddStoneButton.UseVisualStyleBackColor = true;
            AddStoneButton.Click += AddStoneButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 791);
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
            Controls.Add(startButton);
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
        private Button startButton;
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