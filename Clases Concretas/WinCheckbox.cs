using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clases_Concretas
{
    public class WinCheckbox : ICheckbox
    {
        public string UsefulFunctionCheckbox()
        {
            return "The result of the product Windows Checkbox";
        }

        public string AnotherUsefulFunctionCheckbox(IButton _Button)
        {
            var result = _Button.UsefullFunctionButton();

            return $"The result of the WinCheckbox with the ({result})";
        }
    }
}
