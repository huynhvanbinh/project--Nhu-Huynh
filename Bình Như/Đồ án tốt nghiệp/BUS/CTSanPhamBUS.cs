using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class CTSanPhamBUS
    {
        CTSanPhamDAO demo = new CTSanPhamDAO();
        public List<CTSanPhamDTO> LayDsmau(string ma)
        {
            return demo.layDSMau(ma);
        }
        public List<CTSanPhamDTO> LayDsCTSP()
        {
            return demo.layDSCTSP();
        }
        public CTSanPhamDTO layMau(string mamau)
        {
            return demo.layMau(mamau);
        }

        public bool DKKH(CTSanPhamDTO mau)
        {
            return demo.DKMau(mau);
        }
        public bool UpdateNV(CTSanPhamDTO nv)
        {
            return demo.UpdateHD(nv);
        }
    }
}
