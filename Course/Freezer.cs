using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
   public abstract class Freezer:HRD
    {
       int noiseLevel;
       public int NoiseLevel
       {
           get { return noiseLevel; }
           set { if (value <= 0) value = 35; noiseLevel = value; }
       }
       public Freezer(Dimensions d, string color, double weight, int prise, string producingCountry, string title,
            double percent, int noiseLevel)
           : base(d, color, weight, prise, producingCountry, title, percent)
        {
            this.noiseLevel = noiseLevel;
          
        }
       public Freezer()
       {}
       public override List<string> HRDChar()
       {

           List<string> s = base.HRDChar();
           s.Add(Convert.ToString(noiseLevel));
           return s;
       }
    }
}
