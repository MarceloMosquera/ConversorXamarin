using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using ConversorXamarin.Shared.Models;

namespace ConversorXamarin.Shared.ViewModels
{
    public class ConversorViewModel : INotifyPropertyChanged
    {
        private Conversor conversor = new Conversor();
        public event PropertyChangedEventHandler PropertyChanged;
        public string Kilometros
        {
            get { return conversor.kilometros.ToString(); }
            set
            {
                if (conversor.kilometros.ToString() != value)
                {
                    double kms;
                    if (Double.TryParse(value, out kms))
                    {
                        conversor.kilometros = kms;
                        conversor.Convertir();
                        if (PropertyChanged != null)
                        {
                            PropertyChanged(this, new PropertyChangedEventArgs("Millas"));
                        }
                    }
                }
            }
        }

        public string Millas
        {
            get { return conversor.millas.ToString(); }
        }


    }
}
