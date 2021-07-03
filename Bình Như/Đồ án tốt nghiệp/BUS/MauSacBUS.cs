using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class MauSacBUS
    {
        MauSacDAO demo = new MauSacDAO();
        public List<MauSacDTO> LayDsmau()
        {
            return demo.layDSMau();
        }

        public MauSacDTO layMau(string mamau)
        {
            return demo.layMau(mamau);
        }

        public bool DKKH(MauSacDTO mau)
        {
            return demo.DKMau(mau);
        }
        public bool UpdateNV(MauSacDTO nv)
        {
            return demo.UpdateHD(nv);
        }
        public bool DELETENV(MauSacDTO nv)
        {
            return demo.DELETEHD(nv);
        }
    }
}

