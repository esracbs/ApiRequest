// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
class Program
{

    static void Main(string[] args)
    {
        GetCoinValues();
    }


    static void GetCoinValues()
    {
        string[] Veriler;
        using (WebClient wc=new WebClient()) { 
            var url= wc.DownloadString("https://holidayapi.com/v1/holidays?key=19599a41-6302-4d06-992d-953b3518231b&country='TR'&year=2021"); 
            Veriler=url.ToString().Split('{');
        }
        for (int i=0; i<Veriler.Length; i++) {


            if (Veriler[i] == "}")
            {
                Console.WriteLine("\n");
            }
            else { Console.WriteLine(Veriler[i]); }
        }
    }


}
