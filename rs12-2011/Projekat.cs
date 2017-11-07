using rs12_2011.model;
using rs12_2011.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs12_2011
{
    public class Projekat
    {
        public static Projekat Instance { get; } = new Projekat();

        public List<Namestaj> Namestaj
        {
            get
            {
                this.Namestaj = GenericSerializer.Deserialize<namestaj>("namestaj.xml");
                return this.Namestaj;
            }
            set
            {
                this.Namestaj = value;
                GenericSerializer.Serialize<Namestaj>("namestaj.xml", Namestaj);
            }
        }
    }
}
