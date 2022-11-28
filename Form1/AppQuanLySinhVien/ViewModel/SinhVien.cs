namespace AppQuanLySinhVien.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaSinhVien { get; set; }

        [StringLength(50)]
        public string HoDem { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }

        [StringLength(10)]
        public string QueQuan { get; set; }

        [StringLength(10)]
        public string IDLopHoc { get; set; }
    }
}
