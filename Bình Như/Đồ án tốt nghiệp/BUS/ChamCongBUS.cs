using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChamCongBUS
    {
        ChamCongDAO demo = new ChamCongDAO();
        public List<ChamCongDTO> LayDssp(string ngay)
        {
            return demo.layDSSP(ngay);
        }
        public List<ChamCongDTO> LayCCCH(string ngay, string mach)
        {
            return demo.layDSCCCH(ngay, mach);
        }
        public List<ChamCongDTO> LayDsspdk()
        {
            return demo.layDSSPdk();
        }

        public ChamCongDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(ChamCongDTO sps)
        {
            return demo.DKSP(sps);
        }
        public bool UpdateNV(ChamCongDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(ChamCongDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
