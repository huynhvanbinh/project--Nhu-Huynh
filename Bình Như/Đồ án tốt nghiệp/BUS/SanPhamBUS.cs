using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class SanPhamBUS
    {
        SanPhamDAO demo = new SanPhamDAO();
        public List<SanPhamDTO> LayDssp()
        {
            return demo.layDSSP();
        }
        public List<SanPhamDTO> LayDsspcuahang(string mach)
        {
            return demo.layDSMaCH(mach);
        }
        public List<SanPhamDTO> LayDsspbancham()
        {
            return demo.layDSSPbancham();
        }
 
        public SanPhamDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(SanPhamDTO sp)
        {
            return demo.DKSP(sp);
        }
        public bool UpdateNV(SanPhamDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(SanPhamDTO nv)
        {
            return demo.DELETEHD(nv);
        }
        public bool UpdateSL(SanPhamDTO nv)
        {
            return demo.UpdateSL(nv);
        }
    }
}
