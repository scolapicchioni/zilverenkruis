using System;
using System.Collections.Generic;
using System.Text;

namespace op28.BusinessLogic {
    public class AppDrawer : App {
        public AppDrawer() : base("AppDrawer"){
            Apps = new List<IApp>();
        }
        public List<IApp> Apps { get; private set; }
        public void Install(IApp app) {
            Apps.Add(app);
            app.Install();
        }

        public TheTypeOfAppToFind Find<TheTypeOfAppToFind>()
            where TheTypeOfAppToFind : IApp {
            TheTypeOfAppToFind calc = default(TheTypeOfAppToFind);
            foreach (IApp item in Apps) {
                if (item is TheTypeOfAppToFind) {
                    calc = (TheTypeOfAppToFind)item;
                    break;
                }
            }

            return calc;
        }
        
        public override void Install() {
            Console.WriteLine("App drawer installing...");
        }

        public override void Start() {
            Console.WriteLine("App Drawer starting...");
        }
    }
}
