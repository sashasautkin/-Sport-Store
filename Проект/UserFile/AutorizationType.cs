using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
{
    class AutorizationType : IType
    {
        public string Type { get; set; }
        public AutorizationType()
        {

            Type = "Autorizate";

        }
    }
}
