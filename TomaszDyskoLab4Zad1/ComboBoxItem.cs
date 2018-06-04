using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszDyskoLab4Zad1
{
    /// <summary>
    /// Klasa na podstawie źródła : https://stackoverflow.com/questions/3762981/hidden-id-with-combobox-items
    /// </summary>
    class ComboBoxItem
    {
        /// <summary>
        /// Pole do przechowywania wartości wyświetlnej
        /// </summary>
        private string displayValue;
        /// <summary>
        /// Pole do przechowywania wartości ukrytej
        /// </summary>
        private int hiddenValue;
        /// <summary>
        ///Constructor 
        /// </summary>
        public ComboBoxItem(string d, int h)
        {
            displayValue = d;
            hiddenValue = h;
        }
        /// <summary>
        /// Właściwość zwracająca ukrytą wartość
        /// </summary>
        public int HiddenValue
        {
            get
            {
                return hiddenValue;
            }
        }
        /// <summary>
        /// Nadpisanie metody ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return displayValue;
        }
    }
}
