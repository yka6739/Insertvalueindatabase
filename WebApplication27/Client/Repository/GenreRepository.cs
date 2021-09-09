using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication27.Client.Helpers;
using WebApplication27.Shared;

namespace WebApplication27.Client.Repository
{
   
    public class GenreRepository:IGenreRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/genre";

        public GenreRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateGenre(Genre genre)
        {
            var response = await httpService.Post(url, genre);
            if(!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

        }
    }
}
