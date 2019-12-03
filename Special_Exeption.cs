using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepcion_Especial
{
    class Special_Exeption:ApplicationException
    {
        public Special_Exeption()
        {

        }
        public Special_Exeption(string Msg):base(Msg)
        {


        }

    }
}
