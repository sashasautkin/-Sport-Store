using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
{
    interface IUIAbstractFactory
    {
        ILoginAndPassword getLoginAndPassword(string login,string password);
        IType getType();       
    }
}
