using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTHoaDonBUS
    {
        CTHoaDonDAO demo = new CTHoaDonDAO();
        public List<CTHoaDonDTO> LayDssp(string ma)
        {
            return demo.layDSSP(ma);
        }
       
        public CTHoaDonDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }
        public bool DKSP(CTHoaDonDTO sp)
        {
            return demo.DKSP(sp);
        }
        public bool UpdateNV(CTHoaDonDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(CTHoaDonDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
