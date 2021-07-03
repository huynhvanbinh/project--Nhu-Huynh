namespace demo1.dataAccesslayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTKhuyenMai")]
    public partial class CTKhuyenMai
    {
        [StringLength(10)]
        public string MaKM { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(20)]
        public string MaCH { get; set; }

        [StringLength(10)]
        public string GiamGia { get; set; }

        [StringLength(20)]
        public string MaKH { get; set; }

        [Key]
        [StringLength(20)]
        public string MaCTKM { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }
    }
}
