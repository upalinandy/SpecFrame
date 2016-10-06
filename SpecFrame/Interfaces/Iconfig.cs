using SpecFrame.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.Interfaces
{
    interface Iconfig
    {
        BrowserType GetBrowser();
        string GetUsername();
        string GetPassword();
        string GetUrl();
        string GetSearchItem();
        string GetSelectItem();
        string GetExactItem();
        string GetExpLoginPage();
    }
}
