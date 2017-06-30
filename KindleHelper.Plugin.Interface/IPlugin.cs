using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KindleHelper.Plugin.Interface
{
    public interface IPlugin
    {
        string Show();
        void ShowForm();
        void ShowFormAsDialog();
        string version();
        object getresult();
        object run();
    }
}
