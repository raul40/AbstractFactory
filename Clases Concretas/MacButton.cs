﻿using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clases_Concretas
{
    public class MacButton : IButton
    {
        public string UsefullFunctionButton()
        {
            return "The result of the product Mac Button";
        }
    }
}
