using HP.LFT.Report;
using LeanFtTestProject1.FrameWork;
using LeanFtTestProject1.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanFtTestProject1.Tasks
{
    public class SearchMenuTasks : BaseAction
    {
        public static void SearchProduct()
        {
            model.MainMenu.SearchField.SetValue("adidas België Rode Duivels Thuisshirt - Voetbalshirt - Heren");
            model.MainMenu.btn_Search.Click();
            Asserter.AreEqual(6, 5,"Validation failed for count on grid");
                 
        }
    }
}
