namespace Demo_KemTra_Bai6
{
    internal class Program
    {
        static List<XeTai> DSXeTai = new List<XeTai>();
        static void Main(string[] args)
        {
            int luachon = 0;
            do
            {
                Console.WriteLine("==========MENU=========");
                Console.WriteLine("1. Them ");
                Console.WriteLine("2. Hien thi");
                Console.WriteLine("3. Sua ");
                Console.WriteLine("4. Xoa");
                Console.WriteLine("5. Tim Kiem");
                Console.WriteLine("6. Sap xep");
                Console.WriteLine("7. Thoat ");
                Console.WriteLine("=======================");
                Console.Write("Nhap lua chon : ");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        Them(DSXeTai);
                        break;
                    case 2:
                        HienThi(DSXeTai);
                        break;
                    case 3:
                        Sua(DSXeTai);
                        break;
                    case 4:
                        Xoa(DSXeTai);
                        break;
                    case 5:
                        TimKiem(DSXeTai);
                        break;
                    case 6:
                        SapXep(DSXeTai);
                        break;
                    case 7:
                        Console.WriteLine("Ban da thoat chuong trinh ");
                        return;

                    default: Console.WriteLine("Nhap sai ! Nhap lai !");
                        break;
                }
                Console.WriteLine("\n");

            } while (luachon != 7);


            Console.ReadKey();
        }

        static void Them(List<XeTai> DSXeTai)
        {
            XeTai xt = new XeTai();
            Console.WriteLine("Nhap thong tin xe moi : ");
            Console.Write("Nhap so dang ky : ");
            xt.SoDangKy = Console.ReadLine();
            Console.Write("Nhap hang san xuat : ");
            xt.HangSanXuat = Console.ReadLine();
            Console.Write("Nhap nam san xuat : ");
            xt.NamSanXuat = int.Parse(Console.ReadLine());
            Console.Write("Nhap tai trong : ");
            xt.TaiTrong = double.Parse(Console.ReadLine());
            if (DSXeTai.Any(n => n.SoDangKy == xt.SoDangKy))
            {
                Console.WriteLine("Xe nay da ton tai !");
            }
            else
            {
                DSXeTai.Add(xt);
                Console.WriteLine("Them xe moi thanh cong !");
            }

        }

        static void HienThi(List<XeTai> DSXeTai)
        {
            if (DSXeTai.Count < 1)
            {
                Console.WriteLine("Chua co xe nao trong danh sach !");
                return;
            }
            else
            {
                Console.WriteLine($"{"DANH SACH XE",55}");
                Console.WriteLine($"{"So dang ky",20}{"Hang san xuat",20}{"Nam san xuat",15}{"Tai trong",15}{"Phi tai trong",15}");
                foreach (var item in DSXeTai)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        static void TimKiem(List<XeTai> DSXeTai)
        {
            if (DSXeTai.Count < 1)
            {
                Console.WriteLine("Chua co xe nao trong danh sach !");
                return;
            }
            else
            {
                Console.Write("Nhap so dang ky xe muon tim : ");
                string SoDangKy = Console.ReadLine();
                XeTai xt = DSXeTai.FirstOrDefault(n => n.SoDangKy == SoDangKy);
                if (xt != null) {
                    Console.WriteLine("Thong tin xe can tim : ");
                    Console.WriteLine($"{"So dang ky",20}{"Hang san xuat",20}{"Nam san xuat",15}{"Tai trong",15}{"Phi tai trong",15}");
                    Console.WriteLine(xt.ToString());
                }
                else
                {
                    Console.WriteLine("So dang ky khong ton tai !");
                }
            }
        }

        static void Sua(List<XeTai> DSXeTai)
        {
            if (DSXeTai.Count < 1)
            {
                Console.WriteLine("Chua co xe nao trong danh sach !");
                return;
            }
            else {
                Console.Write("Nhap so dang ky xe muon sua : ");
                string SoDangKy = Console.ReadLine();
                XeTai xt = DSXeTai.FirstOrDefault(n => n.SoDangKy == SoDangKy);
                if (xt != null)
                {
                    Console.WriteLine("Nhap thong tin moi cho xe : ");
                    Console.WriteLine("Nhap thong tin xe moi : ");
                    Console.Write("Nhap so dang ky : ");
                    xt.SoDangKy = Console.ReadLine();
                    Console.Write("Nhap hang san xuat : ");
                    xt.HangSanXuat = Console.ReadLine();
                    Console.Write("Nhap nam san xuat : ");
                    xt.NamSanXuat = int.Parse(Console.ReadLine());
                    Console.Write("Nhap tai trong : ");
                    xt.TaiTrong = double.Parse(Console.ReadLine());

                    Console.WriteLine("Sua thanh cong !!");
                }
                else
                {
                    Console.WriteLine("Khong ton tai so dang ky xe !");
                }
            }
        }

        static void Xoa(List<XeTai> DSXeTai)
        {
            if (DSXeTai.Count < 1) { 
                Console.WriteLine("Chua co xe nao trong danh sach !");
                return;
            }

            else
            {
                Console.Write("Nhap so dang ky cua xe muon sua : ");
                string SoDangKy = Console.ReadLine();
                XeTai xt = DSXeTai.FirstOrDefault(n=>n.SoDangKy==SoDangKy);
                if (xt != null)
                {
                    DSXeTai.Remove(xt);
                    Console.WriteLine("Xoa xe thanh cong !");
                }
                else
                {
                    Console.WriteLine("Khong ton tai xe co so dang ky nay !");
                }
            }
        }
        static void SapXep(List<XeTai> DSXeTai)
        {
            // Sử dụng XeTaiComparer để sắp xếp theo SoDangKy và NamSanXuat
            DSXeTai.Sort(new XeTaiComparer());

            XeTai xt = new XeTai();
            Console.WriteLine("Danh sach xe sau khi sap xep:");
            HienThi(DSXeTai);
        }

    }
    class XeTaiComparer : IComparer<XeTai>
    {
        public int Compare(XeTai x, XeTai y)
        {
            // Sắp xếp SoDangKy theo thứ tự giảm dần
            int soDangKyComparison = y.SoDangKy.CompareTo(x.SoDangKy);

            // Nếu SoDangKy giống nhau, sắp xếp NamSanXuat theo thứ tự tăng dần
            if (soDangKyComparison == 0)
            {
                return x.NamSanXuat.CompareTo(y.NamSanXuat);
            }

            return soDangKyComparison;
        }
    }



}
