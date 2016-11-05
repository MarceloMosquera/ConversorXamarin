using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorXamarin.Shared.Models
{
    public class Conversor 
    {
        public double kilometros { get; set; }
        public double millas { get; set; }

        public void Convertir()
        {
            millas = kilometros * 0.621371;
        }
    }
}
