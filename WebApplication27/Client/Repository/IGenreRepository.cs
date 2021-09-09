using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication27.Shared;

namespace WebApplication27.Client.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(Genre genre);
    }
}
