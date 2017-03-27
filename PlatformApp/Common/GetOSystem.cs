using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlatformApp.Common
{
    public class GetOSystem
    {
        private const string Windows2000 = "5.0";
        private const string WindowsXP = "5.1";
        private const string Windows2003 = "5.2";
        private const string Windows2008 = "6.0";
        private const string Windows7 = "6.1";
        private const string Windows8OrWindows81 = "6.2";
        private const string Windows10 = "10.0";

        public string OSystemName
        {
            private set; get;
        }
        public string OSystemVersion
        {
            private set; get;
        }

        public GetOSystem()
        {
            OSystemVersion = System.Environment.OSVersion.Version.Major + "." + System.Environment.OSVersion.Version.Minor;
            switch (OSystemVersion)
            {
                case Windows2000:
                    OSystemName = "Windows2000";
                    break;
                case WindowsXP:
                    OSystemName = "WindowsXP";
                    break;
                case Windows2003:
                    OSystemName = "Windows2003";
                    break;
                case Windows2008:
                    OSystemName = "Windows2008";
                    break;
                case Windows7:
                    OSystemName = "Windows7";
                    break;
                case Windows8OrWindows81:
                    OSystemName = "Windows8.OrWindows8.1";
                    break;
                case Windows10:
                    OSystemName = "Windows10";
                    break;
            }
        }
    }
}
