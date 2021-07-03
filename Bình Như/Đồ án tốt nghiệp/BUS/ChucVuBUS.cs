using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChucVuBUS
    {
        ChucVuDAO demo = new ChucVuDAO();
        public List<ChucVuDTO> LayDskh()
        {
            return demo.layDSKH();
        }

        public ChucVuDTO layKH(string makh)
        {
            return demo.layKH(makh);
        }

        public bool DKKH(ChucVuDTO khs)
        {
            return demo.DKKH(khs);
        }
        public bool UpdateNV(ChucVuDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(ChucVuDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}
