using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
     public  class NhanVienBUS
    {
         NhanVienDAO demo = new NhanVienDAO();
         public List<NhanVienDTO> LayDskh()
         {
             return demo.layDSKH();
         }
        public List<NhanVienDTO> LayDskhNgay(string manhanvien, string manhanvien1, string manhanvien2, string manhanvien3, string manhanvien4
          , string manhanvien5, string manhanvien6, string manhanvien7, string manhanvien8, string manhanvien9, string manhanvien10,
            string manhanvien11, string manhanvien12, string manhanvien13, string manhanvien14, string manhanvien15, string manhanvien16,
            string manhanvien17, string manhanvien18, string manhanvien19, string manhanvien20)
        {
            return demo.layDSKHNgay(manhanvien, manhanvien1, manhanvien2, manhanvien3, manhanvien4, manhanvien5, manhanvien6, manhanvien7,
                manhanvien8, manhanvien9, manhanvien10, manhanvien11, manhanvien12, manhanvien13, manhanvien14, manhanvien15, manhanvien16,
                manhanvien17, manhanvien18, manhanvien19, manhanvien20);
        }
        public NhanVienDTO layKH(string makh)
         {
             return demo.layKH(makh);
         }
        public bool DKKH(NhanVienDTO kh)
         {
             return demo.DKKH(kh);
         }
        public bool UpdateNV(NhanVienDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(NhanVienDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
