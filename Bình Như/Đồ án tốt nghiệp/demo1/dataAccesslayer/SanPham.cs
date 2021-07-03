namespace demo1.dataAccesslayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(30)]
        public string TenSP { get; set; }

        [StringLength(10)]
        public string DonGia { get; set; }

        [StringLength(10)]
        public string MaLoai { get; set; }

        [StringLength(10)]
        public string GiaNhap { get; set; }

        [StringLength(10)]
        public string SoLuongTon { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }

        [Column(TypeName = "text")]
        public string HinhAnh { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
