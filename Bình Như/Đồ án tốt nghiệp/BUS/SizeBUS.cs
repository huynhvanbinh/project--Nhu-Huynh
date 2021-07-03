using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SizeBUS
    {
        SizeDAO demo = new SizeDAO();
        public List<SizeDTO> LayDskt()
        {
            return demo.layDSKT();
        }

        public SizeDTO layKT(string makt)
        {
            return demo.layKT(makt);
        }

        public bool DKKT(SizeDTO kts)
        {
            return demo.DKKT(kts);
        }

        public bool UpdateNV(SizeDTO kt)
        {
            return demo.UpdateHD(kt);
        }
        public bool DELETENV(SizeDTO kt)
        {
            return demo.DELETEHD(kt);
        }
    }
}
