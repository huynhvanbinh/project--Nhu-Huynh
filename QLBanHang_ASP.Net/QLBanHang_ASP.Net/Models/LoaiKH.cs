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
    
    public partial class LoaiKH
    {
        public LoaiKH()
        {
            this.KhachHangs = new HashSet<KhachHang>();
        }
    
        public int MaLoaiKH { get; set; }
        public string TenLoai { get; set; }
        public string UuDai { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}