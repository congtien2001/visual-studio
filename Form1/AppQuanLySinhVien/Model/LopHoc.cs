namespace AppQuanLySinhVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TenLop { get; set; }
    }
}
