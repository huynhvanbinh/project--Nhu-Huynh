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
    
    public partial class CTHoaDon
    {
        public int MaCTHD { get; set; }
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public string MaSize { get; set; }
        public string MaMau { get; set; }
        public string MaKM { get; set; }
        public Nullable<int> GiaBan { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
