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
        public List<SanPhamDTO> LayDssphd(string masp, string masp1, string masp2, string masp3, string masp4, string masp5, string masp6,
            string masp7, string masp8, string masp9, string masp10, string masp11, string masp12, string masp13, string masp14, string masp15,
            string masp16, string masp17, string masp18, string masp19, string masp20, string macuahang)
        {
            return demo.layDSSPHD(masp, masp1, masp2, masp3, masp4, masp5, masp6, masp7, masp8, masp9, masp10, masp11, masp12, masp13,
                masp14, masp15, masp16, masp17, masp18, masp19, masp20, macuahang);
        }
        public List<SanPhamDTO> LayDsspkm(string masp, string masp1, string masp2, string masp3, string masp4, string masp5, string masp6,
            string masp7, string masp8, string masp9, string masp10, string masp11, string masp12, string masp13, string masp14, string masp15,
            string masp16, string masp17, string masp18, string masp19, string masp20)
        {
            return demo.layDSSPKM(masp, masp1, masp2, masp3, masp4, masp5, masp6, masp7, masp8, masp9, masp10, masp11, masp12, masp13,
                masp14, masp15, masp16, masp17, masp18, masp19, masp20);
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
