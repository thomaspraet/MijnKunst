using MijnKunst.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MijnKunst.Business.Services.IServices
{
    public interface IArtistService
    {
        Task<Artist?> GetArtistByIdAsync(int id);
        Task<IEnumerable<Artist>> GetAllArtistsAsync();
        Task<Artist> CreateArtistAsync(Artist artist);
        Task UpdateArtistAsync(Artist artist);
        Task DeleteArtistAsync(int id);
    }
}
