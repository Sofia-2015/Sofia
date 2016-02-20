using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class logs
    {
        public DateTime rundt;
        public String appname;
        public String status;
        public String log;

        public logs ( String appname1, String Status, String Log )
        {
            this.rundt = DateTime.Now;
            this.appname = appname1;
            this.status = Status;
            this.log = Log;
        }

    }
}
