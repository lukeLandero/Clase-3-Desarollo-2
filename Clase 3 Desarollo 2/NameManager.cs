using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3_Desarollo_2
{
    public class NameManager
    {
        private string[] names = { "Spencer", "Sally", "Doug" };

        public string GetName(int ID)
        {
            if (ID < names.Length)
                return names[ID];
            else
                return String.Empty;
        }
    }
}
