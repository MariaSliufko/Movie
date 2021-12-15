using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DotNetEnv;


namespace Movie


{
    public class SearchByMovieTitle
    {
        public static HttpClient client = new HttpClient();

        public static async Task<Title> SearchByTitle()  

        {
            Console.Write("Enter a title: ");
            string titleP = Console.ReadLine();

            try

            {
                Env.TraversePath().Load();
                string key = Environment.GetEnvironmentVariable("API_KEY");
                string pic = Environment.GetEnvironmentVariable($"https://image.tmdb.org/t/p/w500/");

                string uriId = $"https://api.themoviedb.org/3/search/movie?api_key={key}&query={titleP}";
                var response = await client.GetAsync(uriId);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                Title title = JsonConvert.DeserializeObject<Title>(responseContent);

                foreach (var item in title.Results)
                {
                    Console.WriteLine("{0}:{1}", title.Results.IndexOf(item), item.Original_title);
                }
                Console.WriteLine("Select an id: ");
                int id = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Homepage: {0}", title.Results[id].Homepage);
                Console.WriteLine("Id: {0}", title.Results[id].Id);
                Console.WriteLine("Original Language: {0}", title.Results[id].Original_language);
                Console.WriteLine("Title: {0}", title.Results[id].Original_title);
                Console.WriteLine("Overview: {0}", title.Results[id].Overview);
                Console.WriteLine("Posteradress: ", pic + title.Results[id].Poster_path);
                Console.WriteLine("Release date: {0}", title.Results[id].Release_date);
                Console.WriteLine("Runtime: {0}", title.Results[id].Runtime);
                Console.WriteLine("Vote Avrage: {0}", title.Results[id].Vote_avrage);
                //thisMovie.ShowMovie();

                return title;

            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
          

        
       

         
        }
    }
}
