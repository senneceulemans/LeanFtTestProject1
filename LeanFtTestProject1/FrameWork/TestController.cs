using HP.LFT.SDK.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanFtTestProject1.FrameWork
{
    class TestController
    {

        private TestController()
        {
         
        }

        private static TestController instance;

        public static TestController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TestController();
                }

                return instance;
            }
        }

        public ApplicationModel Model { get; set; }

        public IBrowser Browser { get; set; }

    }
}
