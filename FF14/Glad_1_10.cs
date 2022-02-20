using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF14
{
    public partial class Glad_1_10 : Form
    {
        public Glad_1_10()
        {
            InitializeComponent();
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            string selected1 = this.arms.GetItemText(this.arms.SelectedItem);
            if (selected1 == "Ultimum")
            {
                Ultimum ultimum = new Ultimum();
                ultimum.Show();
                this.Hide();
            }
        }
            private void Homebtn_Click(object sender, EventArgs e)
        {
                FF14MW fF14MW = new FF14MW();
                fF14MW.Show();
                this.Hide();
            }
    }
}
