namespace demo1.dataAccesslayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuNhap")]
    public partial class CTPhieuNhap
    {
        [Key]
        [StringLength(20)]
        public string MaCTPN { get; set; }

        [StringLength(20)]
        public string MaPhieuNhap { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(20)]
        public string MaCH { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        [StringLength(10)]
        public string GiaNhap { get; set; }

        [StringLength(10)]
        public string TongTien { get; set; }

        [StringLength(20)]
        public string MaMau { get; set; }

        [StringLength(20)]
        public string MaSize { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual CuaHang CuaHang { get; set; }

        public virtual MauSac MauSac { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }

        public virtual Size Size { get; set; }
    }
}
