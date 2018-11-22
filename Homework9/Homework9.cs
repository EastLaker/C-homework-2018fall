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
    public class Crawler
{
    private Hashtable urls=new Hashtable();
    private int count=0;

    static void Main(string []args)
    {
        Crawler myCrawer=new Crawler();
        string startUrl ="http://cnbolgscom/dstang2000/";
        if(args.Length>=1)startUrl=args[0];

        myCrawer.urls.Add(startUrl,false); //add start page
        new Thread(myCrawer.Crawl).Start(); //start crawling
        new Thread(myCrawer.Crawl).Start();
        new Thread(myCrawer.Crawl).Start();

    }

    private void Crawl()
    {
        Console.WriteLine("start crawling......");
        while(true)
        {
            string current=null;
            foreach(string url in urls.Keys)
            {
                if((bool)urls[url])continue;
                current=url;
            }
            if(current==null||count>10)break;

            Console.WriteLine("Crawling "+current+" page!");
            string html=Download(current);

            urls[current]=true;
            count++;
            Parse(html);
        }
        Console.WriteLine("Crawl ends.");       
    }

    public string Download(string url)
    {
        try
        {
            WebClient webClient=new WebClient();
            webClient.Encoding=Encoding.UTF8;
            string html=webClient.DownloadString(url);

            string fileName=count.ToString();
            File.WriteAllText(fileName,html,Encoding.UTF8);
            return html;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "";
        }
    }

    public void Parse(string html)
    {
        string strRef =@"(href|HREF)[]* =[]*[""'][^""'#>]+[""']";
        MatchCollection matchs=new Regex(strRef).Matches(html);
        foreach(Match match in matchs)
        {
            strRef = match.Value.Substring(match.Value.IndexOf('=')+1).Trim('"','\"','#',',','>');
            if(strRef.Length==0)continue;
            if(urls[strRef]==null)urls[strRef]=false;
        }
    }
}

}
