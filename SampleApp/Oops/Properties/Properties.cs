using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Oops.Properties
{
    class Properties
    {
        public string Name { get; set; }
    }


    class PropertiesHandler
    {
        public static void PropertiesMethod()
        {
            Properties newobj = new Properties();
            newobj.Name = "SaiSrinu";
            Console.WriteLine(newobj.Name);
        }

    }
}



