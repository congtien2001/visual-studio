using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.ViewModel
{
    public class KhoaViewModel
    {
        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public static List<KhoaViewModel> GetList()
        {
            var list = new List<KhoaViewModel>();
            list.Add(new KhoaViewModel { MaKhoa = 1, TenKhoa = "CNTT" });
            list.Add(new KhoaViewModel { MaKhoa = 2, TenKhoa = "DTVT" });
            list.Add(new KhoaViewModel { MaKhoa = 3, TenKhoa = "Van" });
            list.Add(new KhoaViewModel { MaKhoa = 4, TenKhoa = "Bao Chi" });
            list.Add(new KhoaViewModel { MaKhoa = 5, TenKhoa = "Moi Truong" });
            list.Add(new KhoaViewModel { MaKhoa = 6, TenKhoa = "Hoa Hoc" });
            return list;
        }

        internal class getList
        {
            public getList()
            {
            }
        }
    }
}
