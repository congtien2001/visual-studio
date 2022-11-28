using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timerun
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        public int SoPhut { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            SoPhut = (int)numSoPhut.Value;
            DialogResult = DialogResult.OK;// gia tri bang cai dc gan,
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

        }
    }
}
