using MVVMTest.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.Model
{
    public class Zipcode : IZipcode
    {
        public string Code { get; set; }    // repræsenterer postnummeret
        public string City { get; set; }    // repræsenterer bynavnet

        // Opretter et tom objekt, hvor både postnummer og bynavn er blanke.
        public Zipcode()
        {
            Code = "";
            City = "";
        }

        // Opretter et objekt initialiseret med værdier for både postnummer og bynavn.
        public Zipcode(string code, string city)
        {
            Code = code;
            City = city;
        }


        public override string ToString()
        {
            return string.Format("{0} {1}", Code, City);
        }


    }

}
