using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using HP.LFT.SDK.Web;
using LeanFtTestProject1.FrameWork;

namespace LeanFtTestProject1.Tasks
{
    static class ApplicationTasks
    {
        public static void LaunchApplication()
        {
            IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);
            TestController.Instance.Browser = browser;
            browser.Navigate("http://www.bol.com/nl");
            TestController.Instance.Model = new ApplicationModel(browser);
        }


        public static void CloseApplication()
        {
            TestController.Instance.Browser.CloseAllTabs();           
        }

    }
}
