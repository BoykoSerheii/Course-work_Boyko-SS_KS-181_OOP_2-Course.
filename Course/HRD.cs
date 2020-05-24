using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Course
{
    
    public abstract class HRD
    {
        protected Dimensions d;
        public string color { get; set; }
        protected double weight;
        protected int prise;
        public string producingCountry { get; set;}
        public string title { get; set; }
        protected double percent;

        public HRD(Dimensions d, string color, double weight, int prise, string producingCountry, string title,double percent)
        {
            this.d = d;
            this.color = color;
            this.weight = weight;
            this.prise = prise;
            this.producingCountry = producingCountry;
            this.title = title;
            this.percent = percent;
        }
        public HRD()
        { }
        public Dimensions dimensions
        {
            get 
            {
                return d;
            }
            set 
            {
                if (value.a < 0)
                    value.a = 100;
                if (value.b < 0)
                    value.b = 60;
                if (value.c < 0)
                    value.c = 200;
                d = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set { if (value <= 0) value = 100; weight = value; }
        }
        public double Percent
        {
            get { return percent; }
            set { if (value <= 0) value = 1; percent = value; }
        }
        public int Prise
        {
            get { return prise; }
            set { if (value <= 0) value = 1000; prise = value; }
        }

        public double SellingPrice()
        {
            return Prise * percent;
        }

        public abstract string Info();
        public virtual List <string> HRDChar()
        {

            List<string> s = new List<string>();
            s.Add(title);
            s.Add(color);
            s.Add(Convert.ToString(weight));
            s.Add(Convert.ToString(d.a));
            s.Add(Convert.ToString(d.b));
            s.Add(Convert.ToString(d.c));
            s.Add(producingCountry);
            s.Add(Convert.ToString(prise));
            s.Add(Convert.ToString(percent));
            return s;
        }
        public abstract string FileInfo();
                 
    }
}
