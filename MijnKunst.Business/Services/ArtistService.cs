using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MijnKunst.Business.Services.IServices;
using MijnKunst.Models;
using MijnKunst.web.Data;

namespace MijnKunst.Business.Services
{
    public class ArtistService : IArtistService
    {
        private readonly ApplicationDbContext _context;
        public ArtistService(ApplicationDbContext context)
        {
            _context = context  ;
        }

        public async Task<IEnumerable<Artist>> GetAllArtistsAsync()
        {
            return await _context.Artists.ToListAsync();
        }

        public async Task<Artist?> GetArtistByIdAsync(int id)
        {
            return await _context.Artists.FindAsync(id);
        }

        public async Task<Artist> CreateArtistAsync(Artist artist)
        {
            _context.Artists.Add(artist);
            await _context.SaveChangesAsync();
            return artist;
        }

        public async Task DeleteArtistAsync(int id)
        {
            var artist = _context.Artists.Find(id);
            if (artist == null)
            {
                throw new KeyNotFoundException($"Artist with id {id} not found.");
            }
            _context.Artists.Remove(artist);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateArtistAsync(Artist artist)
        {
            _context.Artists.Update(artist);
            await _context.SaveChangesAsync();
        }
    }
}
