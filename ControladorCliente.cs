using AbstractFactory.Fabricas;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ControladorCliente
    {
        public void Main()
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new WinFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new MacFactory());

            Console.ReadLine();
        }

        private void ClientMethod(IGUIFactory winFactory)
        {
            var Button = winFactory.CrearBoton();
            var Checkbox = winFactory.CrearCheckbox();

            Console.WriteLine(Checkbox.UsefulFunctionCheckbox());
            Console.WriteLine(Checkbox.AnotherUsefulFunctionCheckbox(Button));
        }
    }
}
