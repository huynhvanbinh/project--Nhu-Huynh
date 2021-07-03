using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class LuongNhanVienBUS
    {
        LuongNhanVienDAO demo = new LuongNhanVienDAO();
        public List<LuongNhanVienDTO> LayDskh()
        {
            return demo.layDSKH();
        }
        public List<LuongNhanVienDTO> LayDsLT(string ma, string nam)
        {
            return demo.layDSLT(ma, nam);
        }
        public List<LuongNhanVienDTO> LayDsLTMA(string ma, string nam, string manv)
        {
            return demo.layDSCV(ma, nam, manv);
        }
        public List<LuongNhanVienDTO> LayDsTK(string ma, string nam, string noidung)
        {
            return demo.layDSTK(ma, nam, noidung);
        }
        public LuongNhanVienDTO layKH(string makh)
        {
            return demo.layKH(makh);
        }

        public bool DKKH(LuongNhanVienDTO khs)
        {
            return demo.DKKH(khs);
        }
        public bool UpdateNV(LuongNhanVienDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(LuongNhanVienDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
