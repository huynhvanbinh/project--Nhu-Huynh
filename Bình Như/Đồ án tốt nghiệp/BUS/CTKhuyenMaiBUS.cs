using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTKhuyenMaiBUS
    {
        public CTKhuyenMaiDAO demo = new CTKhuyenMaiDAO();
        public List<CTKhuyenMaiDTO> LayDsspdk(string ma)
        {
            return demo.layDSSPDK(ma);
        }
        public List<CTKhuyenMaiDTO> LayDssp()
        {
            return demo.layDSSP();
        }

        public CTKhuyenMaiDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(CTKhuyenMaiDTO sp)
        {
            return demo.DKSP(sp);
        }
        public bool UpdateNV(CTKhuyenMaiDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(CTKhuyenMaiDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
