using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DotNetEnv;
using Movie;

namespace Movie
{


    public class SearchByMovieIdP
    {
        public static HttpClient client = new HttpClient();
        public static async Task<Movie> SearchByIdP()
        {
            Console.Write("Enter a movieid: ");
            int id = int.Parse(Console.ReadLine());

            try

            {
                Env.TraversePath().Load();
                string key = Environment.GetEnvironmentVariable("API_KEY");
                string pic = Environment.GetEnvironmentVariable($"https://image.tmdb.org/t/p/w500/");

                string uriId = $"https://api.themoviedb.org/3/movie/{id}?api_key={key}";
                var response = await client.GetAsync(uriId);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                Movie movie = JsonConvert.DeserializeObject<Movie>(responseContent);

                Console.WriteLine("Homepage: {0}", movie.Homepage);
                Console.WriteLine("Id: {0}", movie.Id);
                Console.WriteLine("Original Language: {0}", movie.Original_language);
                Console.WriteLine("Title: {0}", movie.Original_title);
                Console.WriteLine("Overview: {0}", movie.Overview);
                Console.WriteLine("Posteradress: ", pic + movie.Poster_path);
                Console.WriteLine("Release date: {0}", movie.Release_date);
                Console.WriteLine("Runtime: {0}", movie.Runtime);
                Console.WriteLine("Vote Avrage: {0}", movie.Vote_avrage);

                //thisMovie.ShowMovie();

                return movie;

            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;

        }


        /*     

     public class SearchByMovieId
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
             public string Key_phrase { get; set; }
             public double Popularity { get; set; }




             public SearchByMovieId()
             {
             }
        */



    }
}
