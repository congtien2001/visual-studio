using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppQuanLySinhVien.ViewModel
{
    public class LopHocVienModel
    {
        public int ID { get; set; }
        public string String TenLop  { get; set; }

    ///
    ///
    ///
    ///
    public static List<LopHocVienModel> GetList()
    {
        var db = new AppDBContext();
                            
    }



