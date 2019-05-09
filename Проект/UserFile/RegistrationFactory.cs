using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
{
    class RegistrationFactory : IUIAbstractFactory
    {
        public ILoginAndPassword getLoginAndPassword(string login, string password)
        {
            return new RegistrationLoginAndPassword(login,password);
        }

        public IType getType()
        {
            return new RegistrationType();
        }
    }
}
