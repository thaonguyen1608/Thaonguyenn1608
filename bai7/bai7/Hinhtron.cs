using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class HinhTron
    {
        double bankinh;

        public double Bankinh
        {
            get { return bankinh; }
            set { bankinh = value; }
        }
        ToaDo tam;

        internal ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }

       

        public HinhTron()
        {

        }
        public HinhTron(ToaDo tam, double bankinh)
        {
            this.tam = tam;
            this.bankinh = bankinh;
        }
        public void xuat()
        {
            Console.WriteLine("Ban kinh hinh tron: {0}", bankinh);
            Console.WriteLine("Chu vi hinh tron la: {0} ", TinhChuVi());
            Console.WriteLine("Dien tich hinh tron la: {0}", TinhDienTich());
        }
        public double TinhChuVi()
        {
            return 2 * bankinh * Math.PI;
        }
        public double TinhDienTich()
        {
            return bankinh * bankinh * Math.PI;
        }
    }
}