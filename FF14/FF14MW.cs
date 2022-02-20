namespace FF14
{
    public partial class FF14MW : Form
    {
        public FF14MW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected1 = this.Items.GetItemText(this.Items.SelectedItem);
            string selected2 = this.Arms_Classes.GetItemText(this.Arms_Classes.SelectedItem);
            string selected3 = this.Levels.GetItemText(this.Levels.SelectedItem);
            if (selected1 == "Arms" && selected2 == "Gladiator" && selected3 == "1-10")
            {
                Glad_1_10 glad_1_10 = new Glad_1_10();
                glad_1_10.Show();
                this.Hide();
            }
        }
    }
}