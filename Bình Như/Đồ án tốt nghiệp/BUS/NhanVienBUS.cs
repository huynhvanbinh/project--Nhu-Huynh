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
        public List<NhanVienDTO> LayDsnvch(string mach)
        {
            return demo.layDSNVCH(mach);
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
