using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Cert
{
    class Program
    {
        public static void Main(string[] args)
        {
            X509Store store = new X509Store("My", StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadWrite);
            X509Certificate2 certificate = new X509Certificate2();
            X509Certificate2Collection storecollection2 = (X509Certificate2Collection)store.Certificates;
            int certCount = 0;
            foreach (X509Certificate2 x509 in storecollection2)
            {
                if(x509.FriendlyName.Contains("ID - "))
                {
                    certCount++;
                    Console.WriteLine("Attempting to remove certificate: {0}", x509.FriendlyName);
                    store.Remove (x509);
                }
            }
            if (certCount == 0)
            {
                System.Console.WriteLine("No ID Cert found");
            }
            store.Close();
            System.Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
