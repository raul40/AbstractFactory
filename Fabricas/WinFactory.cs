using AbstractFactory.Clases_Concretas;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fabricas
{
    public class WinFactory : IGUIFactory
    {
        public IButton CrearBoton()
        {
            return new WinButton();
        }

        public ICheckbox CrearCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
