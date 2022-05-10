namespace zadanko
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

       
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.ButtonLevelTextBox = new System.Windows.Forms.TextBox();
            this.A1UpgradeAmmount = new System.Windows.Forms.Button();
            this.A1UpgradeInterval = new System.Windows.Forms.Button();
            this.A1Label = new System.Windows.Forms.Label();
            this.A1ammountTextBox = new System.Windows.Forms.TextBox();
            this.A1IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1Timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hit Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kasa: 0$";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // upgradeButton
            // 
            this.upgradeButton.Location = new System.Drawing.Point(498, 356);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(135, 61);
            this.upgradeButton.TabIndex = 2;
            this.upgradeButton.Text = "Upgrade Level";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // ButtonLevelTextBox
            // 
            this.ButtonLevelTextBox.Location = new System.Drawing.Point(511, 327);
            this.ButtonLevelTextBox.Name = "ButtonLevelTextBox";
            this.ButtonLevelTextBox.Size = new System.Drawing.Size(122, 23);
            this.ButtonLevelTextBox.TabIndex = 3;
            // 
            // A1UpgradeAmmount
            // 
            this.A1UpgradeAmmount.Location = new System.Drawing.Point(208, 6);
            this.A1UpgradeAmmount.Name = "A1UpgradeAmmount";
            this.A1UpgradeAmmount.Size = new System.Drawing.Size(111, 44);
            this.A1UpgradeAmmount.TabIndex = 4;
            this.A1UpgradeAmmount.Text = "Ulepsz ilość";
            this.A1UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A1UpgradeAmmount.Click += new System.EventHandler(this.A1UpgradeAmmount_Click);
            // 
            // A1UpgradeInterval
            // 
            this.A1UpgradeInterval.Location = new System.Drawing.Point(431, 6);
            this.A1UpgradeInterval.Name = "A1UpgradeInterval";
            this.A1UpgradeInterval.Size = new System.Drawing.Size(125, 44);
            this.A1UpgradeInterval.TabIndex = 5;
            this.A1UpgradeInterval.Text = "Ulepsz częstotliwość";
            this.A1UpgradeInterval.UseVisualStyleBackColor = true;
            this.A1UpgradeInterval.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // A1Label
            // 
            this.A1Label.AutoSize = true;
            this.A1Label.Location = new System.Drawing.Point(12, 19);
            this.A1Label.Name = "A1Label";
            this.A1Label.Size = new System.Drawing.Size(78, 15);
            this.A1Label.TabIndex = 6;
            this.A1Label.Text = "AutoUpgrade";
            this.A1Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // A1ammountTextBox
            // 
            this.A1ammountTextBox.Location = new System.Drawing.Point(102, 16);
            this.A1ammountTextBox.Name = "A1ammountTextBox";
            this.A1ammountTextBox.ReadOnly = true;
            this.A1ammountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1ammountTextBox.TabIndex = 7;
            this.A1ammountTextBox.Text = "0";
            this.A1ammountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A1ammountTextBox.TextChanged += new System.EventHandler(this.A1LevelTextBox_TextChanged);
            // 
            // A1IntervalTextBox
            // 
            this.A1IntervalTextBox.Location = new System.Drawing.Point(325, 16);
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            this.A1IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1IntervalTextBox.TabIndex = 8;
            this.A1IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A1IntervalTextBox.TextChanged += new System.EventHandler(this.A1IntervalTextBox_TextChanged);
            // 
            // A1Timer
            // 
            this.A1Timer.Tick += new System.EventHandler(this.A1Timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "/min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A1IntervalTextBox);
            this.Controls.Add(this.A1ammountTextBox);
            this.Controls.Add(this.A1Label);
            this.Controls.Add(this.A1UpgradeInterval);
            this.Controls.Add(this.A1UpgradeAmmount);
            this.Controls.Add(this.ButtonLevelTextBox);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button upgradeButton;
        private TextBox ButtonLevelTextBox;
        private Button A1UpgradeAmmount;
        private Button A1UpgradeInterval;
        private Label A1Label;
        private TextBox A1ammountTextBox;
        private TextBox A1IntervalTextBox;
        private System.Windows.Forms.Timer A1Timer;
        private Label label2;
    }
}