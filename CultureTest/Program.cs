using System;
using System.Globalization;

namespace CultureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Resource1.IDS_HELLO;
            Console.WriteLine("message neutral {0}", message);

            Resource1.Culture = new CultureInfo("en-US");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'en-US' {0}", message);

            Resource1.Culture = new CultureInfo("ku-TR");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'ku-TR' {0}", message);

            Resource1.Culture = new CultureInfo("ko-KR");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'ko-KR' {0}", message);

            Resource1.Culture = new CultureInfo("ckb-IQ");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'ckb-IQ' {0}", message);

            Resource1.Culture = new CultureInfo("ku-arab-IQ");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'ku-arab-IQ' {0}", message);

            Resource1.Culture = new CultureInfo("mai-IN");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'mai-IN' {0}", message);

            Resource1.Culture = new CultureInfo("sat-IN");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'sat-IN' {0}", message);

            Resource1.Culture = new CultureInfo("tu-IN");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'tu-IN' {0}", message);

            Resource1.Culture = new CultureInfo("zzz-ZZ");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'zzz-ZZZ' {0}", message);

            Resource1.Culture = new CultureInfo("ja-JP");
            message = Resource1.IDS_HELLO;
            Console.WriteLine("message 'ja-JP' {0}", message);
        }
    }
}
