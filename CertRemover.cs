using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace CertRemover
{
    class CertRemover
    {
        public static void Main()
        {
            X509Store store = new X509Store("My", StoreLocation.CurrentUser); 
            store.Open(OpenFlags.ReadWrite);
            X509Certificate2Collection storeCollection = (X509Certificate2Collection)store.Certificates;
            foreach (X509Certificate2 x509 in storeCollection)
            {
                if(x509.FriendlyName.Contains("ID - "))
                {
                    Console.WriteLine("certificate name: {0}", x509.FriendlyName);
                    store.Remove (x509);
                }
            }
            store.Close();
        }
    }
}
