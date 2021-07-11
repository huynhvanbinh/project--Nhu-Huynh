using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTPhieuXuatBUS
    {
        public CTPhieuXuatDAO demo = new CTPhieuXuatDAO();
        public List<CTPhieuXuatDTO> LayDsspdk(string ma)
        {
            return demo.layDSSPDK(ma);
        }
        public List<CTPhieuXuatDTO> LayDssp()
        {
            return demo.layDSSP();
        }

        public CTPhieuXuatDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(CTPhieuXuatDTO sp)
        {
            return demo.DKSP(sp);
        }
        public bool UpdateNV(CTPhieuXuatDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(CTPhieuXuatDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
