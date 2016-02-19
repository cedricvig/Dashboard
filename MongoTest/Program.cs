using ND.BO;
using ND.DAL.MongoDB;
using ND.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MongoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //IList<MonitorResultBO> result = MonitorDal.GetByAppAndEnv("TRACA", "DEV W2008R2");
            //Console.WriteLine("Count: " + result.Count);
            ////Console.ReadLine();
            ////foreach (var res in result)
            ////{
            ////    Console.WriteLine(res.ResultDate + "-" + res.Result);
            ////}
            //Console.ReadLine();
            //foreach(var r in MonitorService.GetStatsResults("TRACA", "DEV W2008R2"))
            //{
            //    Console.WriteLine(r.Result + ":"+r.Count);
            //}
            //Console.ReadLine();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (var r in MonitorService.GetAllPaging(1, 15))
            {
                Console.WriteLine(r.MachineName);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + " ms");
            Console.ReadLine();
            sw.Reset();
            sw.Start();
            foreach (var r in MonitorService.GetAllPaging(1, 15))
            {
                Console.WriteLine(r.MachineName);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + " ms");
            Console.ReadLine();
        }
    }
}
