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
        public List<CTSanPhamDTO> LayDsctspch(string ma, string cuahang)
        {
            return demo.layDSctspch(ma,cuahang);
        }
        public List<CTSanPhamDTO> LayDsCTSP()
        {
            return demo.layDSCTSP();
        }
        public List<CTSanPhamDTO> Laydsctspmacuahang(string macuahang)
        {
            return demo.layctspmacuahang(macuahang);
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
        public bool UpdateSL(CTSanPhamDTO nv)
        {
            return demo.UpdateSL(nv);
        }
    }
}
