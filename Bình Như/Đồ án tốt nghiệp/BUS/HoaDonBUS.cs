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
        public List<HoaDonDTO> LayDssp(string ngay, string macuahang)
        {
            return demo.layDSSP(ngay,macuahang);
        }
        public List<HoaDonDTO> LayDsspall()
        {
            return demo.layDSSPall();
        }
        public List<HoaDonDTO> LayDssNam(string nam)
        {
            return demo.layDSSNam(nam);
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
