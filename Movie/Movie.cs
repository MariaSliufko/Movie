using System;
namespace Movie
{
    public class Movie
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
      



        public Movie(/*homepage*/ int id, string original_language, string overview, /* poster_patch*/ string release_date, int runtime, double vote_avrage)
        {
            /*this.homepage = homepage */
            this.Id = id;
            this.Original_language = original_language;
            this.Original_title = Original_title;
            this.Overview = overview;
            /*this.Poster.Patch = poster.patch; */
            this.Release_date = release_date;
            this.Runtime = runtime;
            this.Vote_avrage = vote_avrage;
       
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
            


        }




    }

}
