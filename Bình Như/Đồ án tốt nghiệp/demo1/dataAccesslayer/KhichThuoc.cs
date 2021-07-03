namespace demo1.dataAccesslayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhichThuoc")]
    public partial class KhichThuoc
    {
        [Key]
        [StringLength(30)]
        public string MaSize { get; set; }

        [StringLength(50)]
        public string TenMau { get; set; }
    }
}
