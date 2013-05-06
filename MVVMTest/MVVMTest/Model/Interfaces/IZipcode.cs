using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.Model.Interfaces
{
    interface IZipcode
    {
         string Code { get; set; }
         string City { get; set; }

         string ToString();
        // Zipcode(string code, string city);
    }
}
