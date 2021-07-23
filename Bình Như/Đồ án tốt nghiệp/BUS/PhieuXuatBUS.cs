using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class PhieuXuatBUS
    {
        PhieuXuatDAO demo = new PhieuXuatDAO();
        public List<PhieuXuatDTO> LayDssp()
        {
            return demo.layDSSP();
        }
        public List<PhieuXuatDTO> LayDsspngay(string ngay)
        {
            return demo.layDSSPNgay(ngay);
        }
        public List<PhieuXuatDTO> LayDsspkhongtrangthai()
        {
            return demo.layDSSPkhongtrangthai();
        }

        public PhieuXuatDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(PhieuXuatDTO sp)
        {
            return demo.DKSP(sp);
        }
        public bool UpdateNV(PhieuXuatDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(PhieuXuatDTO nv)
        {
            return demo.DELETEHD(nv);
        }
        public bool UpdateSL(PhieuXuatDTO nv)
        {
            return demo.UpdateSL(nv);
        }
    }
}
