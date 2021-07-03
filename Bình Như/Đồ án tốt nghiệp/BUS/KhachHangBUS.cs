using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO demo = new KhachHangDAO();
        public List<KhachHangDTO> LayDssp()
        {
            return demo.layDSSP();
        }

        public KhachHangDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(KhachHangDTO sps)
        {
            return demo.DKSP(sps);
        }
        public bool UpdateNV(KhachHangDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(KhachHangDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
