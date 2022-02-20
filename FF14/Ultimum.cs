using Newtonsoft.Json;
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


    public partial class Ultimum : Form
    {
        public Ultimum()
        {
            InitializeComponent();
        }

        public class Weapon1
        {
            public string Name { get; set; }
        }

        public class Weapon2
        {
            public string Name { get; set; }
        }

        public class Root
        {
            public Weapon1 weapon1 { get; set; }
            public Weapon2 weapon2 { get; set; }
        }

        Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Glad_1_10)
    }
}
