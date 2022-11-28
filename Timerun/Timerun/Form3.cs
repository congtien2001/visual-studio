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
    public partial class DongHo : Form
    {
        public DongHo()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        int soPhut = 0;
        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            var f = new SettingForm();//name SettingForm
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                soPhut = f.SoPhut;
                lblDongHo.Text = convert(soPhut * 60);//cai text 00:00
            }
        }
        string convert(int soGiay)
        {
            int p = soGiay / 60;
            int s = soGiay % 60;
            return $"{p:0#}:{s:0#}";
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            lblDongHo.Text = convert(convert);
        }
    }
}
