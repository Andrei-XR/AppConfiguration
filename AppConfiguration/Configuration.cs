using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfiguration
{
    public class Configuration
    {
        public string Device { get; set; } = "";
        public string System { get; set; } = "";
        public string Version { get; set; } = "";
        public int Theme { get; set; } = 0;
        public string PathDownloads { get; set; } = "";
        public bool RememberPassword { get; set; } = false;
    }
}
