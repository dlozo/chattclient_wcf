using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattClient_WCF
{
    class QuoteService : IQuoteService
    {
        public string Get()
        {
            List<string> quotes = new List<string>();
            quotes.Add("You complete me. -Jerry Maguire, 1996");
            quotes.Add("You're gonna need a bigger boat. -Jaws, 1975");
            quotes.Add("May the Force be with you. -Star Wars, 1977");
            quotes.Add("I'm going to make him an offer he can't refuse. -The Godfather, 1972");
            quotes.Add("You talkin' to me? -Taxi Driver, 1976");
            quotes.Add("Why so serious?, -The Dark Knight, 2008");
            quotes.Add("Bond. James Bond. -Dr. No, 1962");
            quotes.Add("To infinity and beyond! -Toy Story, 1995");
            quotes.Add("Say hello to my little friend! -Scarface, 1983");
            quotes.Add("Keep your friends close, but your enemies closer. -The Godfather, Part II, 1974");
            quotes.Add("I'm not your friend, I am your brother my friend. -pashaBiceps");
            quotes.Add("Wax on, wax off. -The Karate Kid, 1984");
            quotes.Add("Yo, Adrian! -Rocky, 1976");

            Random random = new Random();
            int indexNumber = random.Next(quotes.Count);

            var randomizedQuote = quotes[indexNumber];

            return randomizedQuote;
        }
    }
}
