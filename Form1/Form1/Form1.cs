using Form1.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        private object selectedGiangVien;

        public Form1()
        {
            InitializeComponent();
            NapDsKhoa();
        }
        void NapDsKhoa()
        {
            var ds = new KhoaViewModel.getList();
            cbbKhoa.DataSource = ds;
            cbbKhoa.DisplayMember = "TenKhoa";
        }
        void NapDsSachGiangVien()
        {
            if (selectedKhoa != null)
            {
                var list = GiangVienViewModel.getByKhoa(selectedKhoa.MaKhoa);
                gridGiangVien.DataSource = list;
                gridGiangVien.DataSource = bdGiangVien;
            }
        }
        public KhoaViewModel selectedKhoa
        {
            get
            {
                return cbbKhoa.SelectedItem as KhoaViewModel;
            }
            
        }
        public 

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            NapDsSachGiangVien();

        }

        private void btnThongTinGiangVien_Click(object sender, EventArgs e)
        {
            if (selectedGiangVien != null)
                MessageBox.Show($"Xin chào, {(selectedGiangVien.GioiTinh ? "thầy" : "cô")} {selectedGiangVien.HoVaTen}");
        }
    }
}
