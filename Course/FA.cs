﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
    public class FA:Freezer
    {
        public string TypeOfEnergy { get; set; }
        public override string Info()
        {
            return "Морозильна камера " + title + Environment.NewLine +
                "абсорбційнa с характеристиками:" + Environment.NewLine +
                "колір: " + color + Environment.NewLine +
                "габарити: " + dimensions.a + "x" + dimensions.b + "x" + dimensions.c + Environment.NewLine +
                "вага: " + weight + Environment.NewLine +
                "тип енергії: " + TypeOfEnergy + Environment.NewLine +
                 "рівень шуму: " + NoiseLevel + Environment.NewLine +
                "країна виробник: " + producingCountry + Environment.NewLine +
                "ціна: " + SellingPrice() + Environment.NewLine;
        }
        public FA(Dimensions d, string color, double weight, int prise, string producingCountry, string title,
            double percent, int noiseLevel, string TypeOfEnergy)
           : base(d, color, weight, prise, producingCountry, title, percent,noiseLevel)
        {
            this.TypeOfEnergy= TypeOfEnergy;
          
        }
        public FA(string[] mas)
       {
           title = mas[0];
           color = mas[1];
           d = new Dimensions();
           d.a = Convert.ToInt32(mas[2]);
           d.b = Convert.ToInt32(mas[3]);
           d.c = Convert.ToInt32(mas[4]);
           weight = Convert.ToInt32(mas[5]);
           TypeOfEnergy = mas[6];
            NoiseLevel=Convert.ToInt32(mas[7]);
           producingCountry = mas[8];
           Prise = Convert.ToInt32(mas[9]);
           Percent = Convert.ToDouble(mas[10]);
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
                +TypeOfEnergy+ "*" + Convert.ToString(NoiseLevel) + "*"
                + producingCountry + "*" + Convert.ToString(Prise) + "*" + Convert.ToString(Percent);
        }
    }
}
