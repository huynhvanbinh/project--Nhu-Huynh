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
    
    public partial class GioHang
    {
        public string MaGH { get; set; }
        public string MaKH { get; set; }
        public string MaSP { get; set; }
        public string MaMau { get; set; }
        public string MaSize { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string TrinhTrangDonHang { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
    }
}
