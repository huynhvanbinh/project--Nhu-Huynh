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
    
    public partial class MauSac
    {
        public MauSac()
        {
            this.CTSanPhams = new HashSet<CTSanPham>();
        }
    
        public int MaMau { get; set; }
        public string TenMau { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual ICollection<CTSanPham> CTSanPhams { get; set; }
    }
}
