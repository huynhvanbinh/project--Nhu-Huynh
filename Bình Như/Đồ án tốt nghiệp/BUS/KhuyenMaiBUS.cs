using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class KhuyenMaiBUS
    {
        KhuyenMaiDAO demo = new KhuyenMaiDAO();
        public List<KhuyenMaiDTO> LayDssp()
        {
            return demo.layDSSP();
        }


        public KhuyenMaiDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(KhuyenMaiDTO sp)
        {
            return demo.DKSP(sp);
        }
        public bool UpdateNV(KhuyenMaiDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(KhuyenMaiDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
