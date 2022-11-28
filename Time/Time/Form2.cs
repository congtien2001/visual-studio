using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class SetMinute : Form
    {
        public int SoPhut;

        public SetMinute()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoPhut = (int)numericUpDown1.Value;
            //this.Close();
            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
