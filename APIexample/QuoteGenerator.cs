using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace APIexample
{
    class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient(); //a new instance of the HttpClient class which provides a base class for sending HTTP requests and receiving HTTP responses from a resource identified by a URI.

            var kanyeURL = "https://api.kanye.rest"; //string to hold KanyeURL

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result; //response from API as string

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString(); //

            Console.WriteLine("-------------------");
            Console.WriteLine($"Kanye: {kanyeQuote}");
            Console.WriteLine("-------------------");

        }
        public static void RonQuote()
        {
          

            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("-------------------");
            Console.WriteLine($"Ron: {ronQuote}");
            Console.WriteLine("-------------------");
        }

    }
}
