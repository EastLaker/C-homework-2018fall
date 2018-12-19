using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Homework9
{
    public class Crawler
    {
        public Hashtable urls = new Hashtable();
        static private int count = 0;
        Stopwatch stopwatch = new Stopwatch();
        

        public void Crawl()
        {
            Console.WriteLine("start crawling......");
            stopwatch.Start();
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count > 1000) break;

                Console.WriteLine("Crawling " + current + " page!");
                Task.Run(()=>Download(current));

                //urls[current] = true;
                count++;
                
            }
            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.Elapsed);
            Console.WriteLine("Crawl ends.");
        }

        public void Download(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                Parse(html);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return "";
            }
        }

        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matchs = new Regex(strRef).Matches(html);
            foreach (Match match in matchs)
            {
                strRef = match.Value.Substring(match.Value.IndexOf("=") + 1)
                                                .Trim('"', '\"', '#', ',', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
