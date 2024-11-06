using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_KemTra_Bai6
{
    internal class XeTai : Xe
    {
        private double _taiTrong;

        public double TaiTrong { get => _taiTrong; set => _taiTrong = value; }
        public XeTai() { }
        public XeTai(string soDangKy,string hangSanXuat,int namSanXuat,double taiTrong) : base(soDangKy, hangSanXuat, namSanXuat)
        {
            this.TaiTrong = taiTrong;
        }

        public override void Nhap(string soDangKy,string hangSanXuat,int namSanXuat) { }
        public void Nhap(string soDangKy, string hangSanXuat, int namSanXuat,double taiTrong) {
            base.Nhap(soDangKy, hangSanXuat, namSanXuat);
            this.TaiTrong = taiTrong;
        }
        
        public override double TinhPhi() {
            if (TaiTrong < 8) return 1000000;
            else if (TaiTrong >= 8 && TaiTrong <= 13) return 2000000;
            else return 3000000;
        }

        public override string ToString()
        {
            return $"{SoDangKy,20}{HangSanXuat,20}{NamSanXuat,15}{TaiTrong,15}{TinhPhi(),15}";
        }

        public override bool Equals(object obj)
        {
            XeTai x = (XeTai)obj;
            return this.SoDangKy.Equals(x.SoDangKy);
        }
        
        public override int GetHashCode()
        {
            return SoDangKy.GetHashCode();
        }

    }
}
