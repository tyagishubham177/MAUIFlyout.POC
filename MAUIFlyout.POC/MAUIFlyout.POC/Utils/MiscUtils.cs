using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIFlyout.POC.Utils
{
    public static class MiscUtils
    {
        public static void SetFlyoutItem(string page)
        {
            var appShell = Application.Current.MainPage as AppShell;
            var flyouItem = appShell?.Items.FirstOrDefault(item => item.Title == page);
            if (flyouItem != null)
            {
                Shell.Current.CurrentItem = flyouItem;
                Shell.Current.FlyoutIsPresented = false;
            }
        }
    }
}
