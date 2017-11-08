using rs12_2011.model;
using System;
using System.Collections.Generic;

namespace rs12_2011
{
    class Program
    {

        static void Main(string[] args)
        {
            var admin = new Administracija();
            try
            {
                admin.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine($"General Error: {e.Message}");
            }

            Util.GenericSerializer.Serialize("namestaj.xml", admin.GetMagacin());
        }
    }
}
