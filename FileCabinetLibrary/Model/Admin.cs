﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    //Класс Admin в якому зберігається логін та пароль адміна
    public class Admin
    {
        public string Login { get; } = "admin";
        public string Password { get; } = "123456";
    }
}
