namespace demo1.dataAccesslayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [Column("TaiKhoan")]
        [StringLength(20)]
        public string TaiKhoan1 { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(100)]
        public string MatKhau { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
