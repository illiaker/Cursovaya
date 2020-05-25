using FileCabinetLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    static public class User
    {
        static public UserRole Role { get; set; } = UserRole.Admin;
    }
}
