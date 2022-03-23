namespace zadanko
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonLevel;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonLevel = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(10, buttonLevel-1);
            label1.Text = "Kasa: $"+ cash.ToString();
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if(cash >= upgradeCost)
            {
                buttonLevel++;
                ButtonLevelTextBox.Text = buttonLevel.ToString();
                cash -= upgradeCost;
                label1.Text = "Kasa: $" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                upgradeButton.Text = "Upgrade\n" + nextUpgradeCost;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}