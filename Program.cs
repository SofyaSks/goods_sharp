using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace goods_sharp
{
	
   public class Grocery
    {
        public Grocery(string n, int p, double w)
        {
            name = n;
            price = p;
            weight = w;
        }
        protected string name;
        protected int price;
        protected double weight;

        public override string ToString()
        {
            return $"{name} {weight} {price} ";
        }
    }

   public class Products : Grocery
    {
        public Products(string n, int p, double w, int t) : base(n,p,w)
        {
            time = t;
        }
        protected int time;

        public override string ToString()
        {
            return $"{base.ToString()} {time} ";
        }
    }

    public class Chemistry : Grocery
    {
        public Chemistry(string n, int p, double w, int t) : base(n, p, w)
        {
            time = t;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {time} ";
        }

        protected int time;
    }

    public class Bread : Products
    {
        public Bread(string n, int p, double w, int t, string ty) : base(n, p, w,t)
        {
            type = ty;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {type} ";
        }
        private string type;
    }

    public class Milk : Products
    {
        public Milk(string n, int p, double w, int t, string ty) : base(n, p, w, t)
        {
            type = ty;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {type} ";
        }
        private string type;
    }

    public class Cheese : Products
    {
        public Cheese(string n, int p, double w, int t, string ty) : base(n, p, w, t)
        {
            type = ty;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {type} ";
        }
        private string type;
    }

    public class Soap : Chemistry
    {
        public Soap(string n, int p, double w, int t, string s) : base(n, p, w,t)
        {
            smell = s;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {smell} ";
        }
        string smell;
    }

    public class Powder : Chemistry
    {
        public Powder(string n, int p, double w, int t, string s) : base(n, p, w, t)
        {
            smell = s;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {smell} ";
        }
        string smell;
    }

    public class AirFreshener : Chemistry
    {
        public AirFreshener(string n, int p, double w, int t, string s) : base(n, p, w, t)
        {
            smell = s;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {smell} ";
        }
        string smell;
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Products cheese = new Cheese("Cheese", 500, 300, 15, "Gauda");
            Grocery[] groceries = {cheese,
                new Milk ("Milk", 50, 1000, 15, "Selskoye" ),
                new Bread("Bread", 30, 700, 10, "Borodinskiy"),
                new Soap("Soap", 389, 15, 150, "Lemon" ),
                new Powder ("Powder", 5000, 300, 155, "Lavand" ),
                new AirFreshener ("AirFreshner", 350, 500, 135, "Sea" )
            };

            foreach (Grocery item in groceries)
            {
                WriteLine(item);
            }
            
        }
    }
}
