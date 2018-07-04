using HP.LFT.Report;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanFtTestProject1.Utils
{
    static class Asserter 
    {
            public static void AreEqual(object expected, object actual,string errorDescription, string errorTitle = "Assert Are Equal Failed")
            {
                try
                {
                    Assert.AreEqual(expected, actual, "Assert Are Equal failed");
                    Reporter.ReportEvent("Validate AreEqual Passed", "Validated '" + expected + "' with '" + actual + "'", Status.Passed);
                }
                catch (Exception e)
                {
                    Reporter.ReportEvent(errorTitle,  "Assert are equal failed expected ='" + expected + "' actual ='" + actual + "'; " + errorDescription , Status.Failed, e);
                    throw;
                }
        }
        }
    }

