using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    interface ISort
    {
        event EventHandler SearchEvent;

        event EventHandler NationalityChangedEvent;
        BindingSource CBS { get; set; }
    }
}
