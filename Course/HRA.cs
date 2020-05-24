using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
    public class HRA:HR
    {
        public string TypeOfEnergy { get; set; }
        public override string Info()
        {
            return "Холодильник " + title + Environment.NewLine +
                "абсорбційний с характеристиками:" + Environment.NewLine +
                "колір: " + color + Environment.NewLine +
                "габарити: " + dimensions.a + "x" + dimensions.b + "x" + dimensions.c + Environment.NewLine +
                "вага: " + weight + Environment.NewLine +
                "тип енергії: " + TypeOfEnergy + Environment.NewLine +
                "кількість камер: " + NumberOfCameras + Environment.NewLine +
                "розташування морозильної камери: " + freezerLocation + Environment.NewLine +
                "об'єм морозильної камери: " + FreezerVolume + Environment.NewLine +
                "країна виробник: " + producingCountry + Environment.NewLine +
                "ціна: " + SellingPrice() + Environment.NewLine;
        }
         public HRA(Dimensions d, string color, double weight, int prise, string producingCountry, string title,
            double percent, int numberOfCameras, int freezerVolume, string freezerLocation, string TypeOfEnergy)
            : base(d, color, weight, prise, producingCountry, title, percent,numberOfCameras,freezerVolume,freezerLocation)
        {
            this.TypeOfEnergy = TypeOfEnergy;
        }
        public HRA(string[] mas)
       {
           title = mas[0];
           color = mas[1];
           d = new Dimensions();
           d.a = Convert.ToInt32(mas[2]);
           d.b = Convert.ToInt32(mas[3]);
           d.c = Convert.ToInt32(mas[4]);
           weight = Convert.ToInt32(mas[5]);
           numberOfCameras = Convert.ToInt32(mas[6]);
           TypeOfEnergy=mas[7];
           freezerLocation = mas[8];
           freezerVolume = Convert.ToInt32(mas[9]);
           producingCountry = mas[10];
           Prise = Convert.ToInt32(mas[11]);
           Percent = Convert.ToDouble(mas[12]);
       }
        public override List<string> HRDChar()
        {

            List<string> s = base.HRDChar();
            s.Add(TypeOfEnergy);
            return s;
        }
        public override string FileInfo()
        {
            return title + "*" + color + "*" + Convert.ToString(d.a) + "*" + Convert.ToString(d.b) + "*"
                + Convert.ToString(d.c) + "*" + Convert.ToString(weight) + "*"
                + Convert.ToString(numberOfCameras) + "*" + TypeOfEnergy + "*"
                + freezerLocation + "*" + Convert.ToString(FreezerVolume) + "*"
                + producingCountry + "*" + Convert.ToString(Prise) + "*" + Convert.ToString(Percent);
        }
    }
}
