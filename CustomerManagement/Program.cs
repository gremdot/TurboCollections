using System;
using TurboCollections;

namespace CustomerManagement
{
    class Program
    {
        static void Main()
        {
            var turbolist = new TurboList<float>();
            turbolist.Add(3f);
            turbolist.Add(-7f);


            foreach (var item in turbolist)
            {
                Console.WriteLine(item);
            }
        }
    }
}