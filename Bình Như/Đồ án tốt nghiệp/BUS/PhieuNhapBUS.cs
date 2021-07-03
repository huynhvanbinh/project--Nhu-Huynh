using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class PhieuNhapBUS
    {
        PhieuNhapDAO demo = new PhieuNhapDAO();
        public List<PhieuNhapDTO> LayDssp()
        {
            return demo.layDSSP();
        }


        public PhieuNhapDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(PhieuNhapDTO sp)
        {
            return demo.DKSP(sp);
        }
        public bool UpdateNV(PhieuNhapDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(PhieuNhapDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
