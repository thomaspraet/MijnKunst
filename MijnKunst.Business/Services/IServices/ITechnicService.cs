using MijnKunst.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MijnKunst.Business.Services.IServices
{
    public interface ITechnicService
    {
        Task<Technic?> GetTechnicByIdAsync(int id);
        Task<IEnumerable<Technic>> GetAllTechnicsAsync();
        Task<Technic> CreateTechnicAsync(Technic technic);
        Task UpdateTechnicAsync(Technic technic);
        Task DeleteTechnicAsync(int id);
    }
}
