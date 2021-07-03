using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class LoaiSanPhamBUS
    {
        LoaiSanPhamDAO demo = new LoaiSanPhamDAO();
        public List<LoaiSanPhamDTO> LayDssp()
        {
            return demo.layDSSP();
        }

        public LoaiSanPhamDTO laySP(string masp)
        {
            return demo.laySP(masp);
        }

        public bool DKSP(LoaiSanPhamDTO sps)
        {
            return demo.DKSP(sps);
        }
        public bool UpdateNV(LoaiSanPhamDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(LoaiSanPhamDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
