using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_KemTra_Bai6
{
    internal class Xe
    {
        private string _soDangKy;
        private string _hangSanXuat;
        private int _namSanXuat;

        public string SoDangKy { get => _soDangKy; set => _soDangKy = value; }
        public string HangSanXuat { get => _hangSanXuat; set => _hangSanXuat = value; }
        public int NamSanXuat { get => _namSanXuat; set => _namSanXuat = value; }
    
        public Xe() { }
        public Xe(string soDangKy,string hangSanXuat,int namSanXuat)
        {
            this.SoDangKy= soDangKy;
            this.HangSanXuat=hangSanXuat;
            this.NamSanXuat=namSanXuat;
        }

        public virtual void Nhap(string soDangKy, string hangSanXuat, int namSanXuat)
        {
            this.SoDangKy = soDangKy;
            this.HangSanXuat = hangSanXuat;
            this.NamSanXuat = namSanXuat;
        }

        public virtual double TinhPhi() { return 0; }

        public override string ToString()
        {
            return $"{SoDangKy,20}{HangSanXuat,20}{NamSanXuat,15}";
        }

    }
}
