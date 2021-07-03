using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CuaHangBUS
    {
        CuaHangDAO demo = new CuaHangDAO();
        public List<CuaHangDTO> LayDsch()
        {
            return demo.layDSCH();
        }

        public CuaHangDTO layCH(string mach)
        {
            return demo.layCH(mach);
        }

        public bool DKCH(CuaHangDTO chs)
        {
            return demo.DKCH(chs);
        }
        public bool UpdateNV(CuaHangDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(CuaHangDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
