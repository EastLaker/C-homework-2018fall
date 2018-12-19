using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler myCrawer = new Crawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];

            myCrawer.urls.Add(startUrl, false); //add start page
            Thread thread1 = new Thread(new ThreadStart(myCrawer.Crawl)); //start crawling
            thread1.Start();
            thread1.Name = "1";
            //Thread thread2 = new Thread(new ThreadStart(myCrawer.Crawl)); //start crawling
            //thread2.Start();
            //thread2.Name = "2";

            Console.Read();
        }
    }

}
