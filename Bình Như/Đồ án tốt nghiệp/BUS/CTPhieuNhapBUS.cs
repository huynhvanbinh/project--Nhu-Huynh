using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class CTPhieuNhapBUS
    {
        CTPhieuNhapDAO demo = new CTPhieuNhapDAO();
        public List<CTPhieuNhapDTO> LayDssp()
        {
            return demo.layDSSP();
        }


        public CTPhieuNhapDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(CTPhieuNhapDTO sp)
        {
            return demo.DKSP(sp);
        }
        public bool UpdateNV(CTPhieuNhapDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(CTPhieuNhapDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
