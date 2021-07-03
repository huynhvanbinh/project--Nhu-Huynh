namespace demo1.dataAccesslayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(20)]
        public string MaKH { get; set; }

        [StringLength(10)]
        public string TongTien { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }
    }
}
