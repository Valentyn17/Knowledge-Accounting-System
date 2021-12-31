using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAreaRepository
    {
        Task<KnowledgeArea> GetByIdWithDetailsAsync(int id);
        IQueryable<KnowledgeArea> FindAllWithDetails();

        Task<KnowledgeArea> AddAsync(KnowledgeArea entity);
        Task<bool> UpdateAsync(KnowledgeArea entity);

        Task<bool> DeleteByIdAsync(int id);
    }
}
