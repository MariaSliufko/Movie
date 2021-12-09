using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Movie
{
    public class SearchByMovieId
    {
        //Public Ur Homepage
        public int Id { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        //public uri Poster_patch
        public string Release_date { get; set; }
        public int Runtime { get; set; }
        public double Vote_avrage { get; set; }
        public string Key_phrase { get; set; }
        public double Popularity { get; set; }




        public SearchByMovieId()
        {
        }


        public void ShowMovie()
        {
            //Console.WriteLine("Homepage: {0}", Homepage);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Original Language: {0}", Original_language);
            Console.WriteLine("Title: {0}", Original_title);
            Console.WriteLine("Overview: {0}", Overview);
            Console.WriteLine($"Posteradress");
            Console.WriteLine("Release date: {0}", Release_date);
            Console.WriteLine("Runtime: {0}", Runtime);
            Console.WriteLine("Vote Avrage: {0}", Vote_avrage);
            Console.WriteLine("Key Phrase: {0}", Key_phrase);
            Console.WriteLine("Popularity: {0}", Popularity);


        }

    }
}
