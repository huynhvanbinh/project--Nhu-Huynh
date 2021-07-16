using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO demo = new HoaDonDAO();
        public List<HoaDonDTO> LayDssp(string ngay)
        {
            return demo.layDSSP(ngay);
        }
        public List<HoaDonDTO> LayDsspall()
        {
            return demo.layDSSPall();
        }
        public HoaDonDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(HoaDonDTO sps)
        {
            return demo.DKSP(sps);
        }
        public bool UpdateNV(HoaDonDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(HoaDonDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
