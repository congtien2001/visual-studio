﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.ViewModel
{
    public class GiangVienViewModel
    {
        public string MaGiangVien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string HoVaTen
        {
            get
            {
                return $"{Ho} {Ten}";
            }
        }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string GioiTinhStr
        {
            get
            {
                return GioiTinh ? "Nam" : "Nữ";
            }
        }
        public string QueQuan { get; set; }
        public int MaKhoa { get; set; }

        public static List<GiangVienViewModel> getAll()
        {
            var list = new List<GiangVienViewModel>();
            var lsKhoa = KhoaViewModel.GetList();
            list.Add(new GiangVienViewModel { });
            Random r = new Random();
            foreach (var khoa in lsKhoa)                                    
            {
                for (int i = 0; i < 10; i++)
                {
                    var random = r.Next(2);
                    list.Add(new GiangVienViewModel
                    {
                        MaGiangVien = $"{khoa.MaKhoa}{i}",
                        Ho = "Nguyễn",
                        Ten = $"{khoa.TenKhoa}_{i}",
                        GioiTinh = (random == 0 ? true : false),
                        NgaySinh = DateTime.Now,
                        MaKhoa = khoa.MaKhoa,
                        QueQuan = "TT Huế"
                    });

                }
            }

            return list;
        }
        public static List<GiangVienViewModel> getByKhoa(int maKhoa)
        {
            var list = getAll();
            var result = list.Where(t => t.MaKhoa == maKhoa).ToList();
            return result;
        }
    }
}
