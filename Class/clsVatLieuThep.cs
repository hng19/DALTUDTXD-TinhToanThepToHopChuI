using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DALTUDTXDHONG.Class
{
    public class clsVatLieuThep
    {
        private string _tenVatLieu;
        private double _cuongDoChiuKeo;
        private double _moDunDanHoi;

        public double CuongDoChiuKeo
        {
            get { return _cuongDoChiuKeo; }
            set { _cuongDoChiuKeo = value; }
        }

        public double MoDunDanHoi
        {
            get { return _moDunDanHoi; }
            set { _moDunDanHoi = value; }
        }

        public string TenVatLieu
        {
            get { return _tenVatLieu; }
            set { _tenVatLieu = value; }
        }
        

        public clsVatLieuThep(string tenvatlieu, double cuongdochiukeo, double modundanhoi)
        {
            TenVatLieu = tenvatlieu;
            CuongDoChiuKeo = cuongdochiukeo;
            MoDunDanHoi = modundanhoi;
        }
    }
}
