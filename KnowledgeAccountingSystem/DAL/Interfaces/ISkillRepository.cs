using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISkillRepository
    {
        Task<KnowledgeSkill> GetByIdWithDetailsAsync(int id);
        IQueryable<KnowledgeSkill> FindAllWithDetails();

        Task<KnowledgeSkill> AddAsync(KnowledgeSkill entity);
        Task<bool> Update(KnowledgeSkill entity);

        Task<bool> DeleteByIdAsync(int id);
    }
}
