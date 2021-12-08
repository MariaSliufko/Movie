using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Movie
{
    public class SearchByMovieId
    {
        public static HttpClient client = new HttpClient();

        public static async Task<Movie> SearchById(int id)
        {

            Console.WriteLine("Enter movie id: ");
            int id = Convert.ToInt32(Console.ReadLine());


            try
            {
                string uriId = $"https://api.themoviedb.org/3/movie{id}/550?api_key=df22cd8ec8f6663e3f49f5a84a1070ef";
                var response = await client.GetAsync(uriId);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                    Movie thismovie = JsonConvert.DeserializeObject<Movie>(responseContent);

                return thismovie;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }



        }



        public SearchByMovieId()
        {
        }
    }
}
