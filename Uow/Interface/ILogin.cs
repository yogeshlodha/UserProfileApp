using System;
using System.Collections.Generic;
using System.Text;

namespace Uow.Interface
{
    interface ILogin
    {
        bool CheckLogin(LoginModel model);
    }
}
