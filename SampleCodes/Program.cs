
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel.Syndication;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Net;
using System.Linq;

namespace SampleCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Persons IndianCommunity = new Persons();
            for (int i = 0; i < 10; i++)
            {
                IndianCommunity.Add(new Person() { Age = i, Name = "str" + i.ToString() });
            }

            var enum1 = IndianCommunity.GetEnumerator();

            while (enum1.MoveNext())
            {
                Console.WriteLine(enum1.Current.ToString());
            }

            Console.WriteLine(IndianCommunity[2].ToString());

            List<string> strList = new List<string>() { "str1", "str2", "str3", "str4", "str5", "str6" };


            Console.WriteLine(strList.ToArray().Aggregate( (x,y) => x+=y));
            


            //Console.WriteLine("Length =" + result.Result.Length);

            Console.WriteLine("Waiting ..");
            Console.ReadLine();
        }

        private async static Task<string> AsyncMethod()
        {
            

            Task<string> thtml = new Task<string>(() =>
            {
                WebClient client = new WebClient();
                return client.DownloadString("http://msn.com");
            });

            Console.WriteLine("Finished");

            thtml.Start();
            await thtml;

            Console.WriteLine("Length =" + thtml.Result.Length);

            return string.Empty;
        }
    }
}
