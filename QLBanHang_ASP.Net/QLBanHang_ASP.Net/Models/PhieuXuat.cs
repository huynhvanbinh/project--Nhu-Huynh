//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBanHang_ASP.Net.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuat()
        {
            this.CTPhieuXuats = new HashSet<CTPhieuXuat>();
        }
    
        public string MaPX { get; set; }
        public string Ngay { get; set; }
        public string MaNV { get; set; }
        public string MaCH { get; set; }
        public string TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuXuat> CTPhieuXuats { get; set; }
        public virtual CuaHang CuaHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
