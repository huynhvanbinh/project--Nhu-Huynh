using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO demo = new NhaCungCapDAO();
        public List<NhaCungCapDTO> LayDsch()
        {
            return demo.layDSCH();
        }

        public NhaCungCapDTO layCH(string mach)
        {
            return demo.layCH(mach);
        }

        public bool DKCH(NhaCungCapDTO chs)
        {
            return demo.DKCH(chs);
        }
        public bool UpdateNV(NhaCungCapDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(NhaCungCapDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
