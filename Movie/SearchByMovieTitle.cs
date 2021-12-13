using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DotNetEnv;


namespace Movie


{
    public class SearchByMovieTitleP
    {
        public static HttpClient client = new HttpClient();
        public static async Task<Movie> SearchByTitelP()
        {
            Console.Write("Enter a title: ");
            string title = Console.ReadLine();

            try

            {
                Env.TraversePath().Load();
                string key = Environment.GetEnvironmentVariable("API_KEY");

                string uriTitle = $"https://api.themoviedb.org/3/search/movie?api_key={key}&query=title";
                var response = await client.GetAsync(uriTitle);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                Movie thisMovie = JsonConvert.DeserializeObject<Movie>(responseContent);

                thisMovie.ShowMovie();

            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;

        }

        public class SearchByMovieTitle
        {
            public string Homepage { get; set; }
            public int Id { get; set; }
            public string Original_language { get; set; }
            public string Original_title { get; set; }
            public string Overview { get; set; }
            public string Poster_patch { get; set; }
            public string Release_date { get; set; }
            public int Runtime { get; set; }
            public double Vote_avrage { get; set; }




            public SearchByMovieTitle()

            {
            }


            public void ShowMovie()
            {
                Console.WriteLine("Homepage: {0}", Homepage);
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
}
