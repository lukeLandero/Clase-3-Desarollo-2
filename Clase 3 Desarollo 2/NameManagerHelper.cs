using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3_Desarollo_2
{
    public static class NameManagerHelper
    {
        public static void DisplayNames()
        {
            NameManager manager = new NameManager();
            int id = 1; // Example ID
            string nameFromManager = manager.GetName(id);
            Console.WriteLine($"The name at ID {id} is: {nameFromManager}");
        }
    }
}
