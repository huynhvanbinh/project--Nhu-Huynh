namespace demo1.dataAccesslayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHoaDon")]
    public partial class CTHoaDon
    {
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(10)]
        public string MaSize { get; set; }

        [StringLength(10)]
        public string MaMau { get; set; }

        [StringLength(10)]
        public string MaCH { get; set; }

        [StringLength(10)]
        public string GiaBan { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        [StringLength(10)]
        public string MaKM { get; set; }

        [Key]
        [StringLength(20)]
        public string MaCTHD { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }
    }
}
