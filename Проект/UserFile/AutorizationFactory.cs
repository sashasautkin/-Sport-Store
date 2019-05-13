using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
{
    class AutorizationFactory : IUIAbstractFactory
    {
        public ILoginAndPassword getLoginAndPassword(string login, string password)
        {
            return new AutorizationLoginAndPassword(login,password);
        }
        public IType getType()
        {
            return new AutorizationType();
        }        
    }
}
