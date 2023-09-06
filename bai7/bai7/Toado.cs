using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class ToaDo
    {
        string tentd;

        public string Tentd
        {
            get { return tentd; }
            set { tentd = value; }
        }
        float x;

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        float y;

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        
        public ToaDo() : this("O", 0, 0)
        {
        }
        public ToaDo(string tentd, float x, float y)
        {
            this.tentd = tentd;
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten toa do: ");
            tentd = Console.ReadLine();
            Console.Write("Nhap x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0}({1}:{2})", tentd, x, y);
        }
    }
}