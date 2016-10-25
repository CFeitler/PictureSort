using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureSortDesktop
{
    public class FileLocations
    {
        private static FileLocations _instance;
        public string PathUp { get; set; }
        public string PathLeft { get; set; }
        public string PathRight { get; set; }

        private FileLocations()
        { }

        public static FileLocations Instance
        {
            get
            {
                if (_instance == null)
                    new FileLocations();
                return _instance;
            }
        }
    }
}
