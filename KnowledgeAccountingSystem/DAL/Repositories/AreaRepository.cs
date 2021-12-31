using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AreaRepository : IAreaRepository
    {
        private readonly AccountingSystemDbContext _db;
        public AreaRepository(AccountingSystemDbContext accountingSystemDbContext)
        {
            _db = accountingSystemDbContext;
        }
        public async Task<KnowledgeArea> AddAsync(KnowledgeArea entity)
        {
            await _db.Areas.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var item = await _db.Areas.FindAsync(id);
            var result = item != null;

            if (result) {
                _db.Remove(item);
                await _db.SaveChangesAsync();
            }
            return result;
        }

        public IQueryable<KnowledgeArea> FindAllWithDetails()
        {
            return _db.Areas.Include(x=>x.Skills);
        }

        public async Task<KnowledgeArea> GetByIdWithDetailsAsync(int id)
        {
            return await _db.Areas.Include(x=>x.Skills).Where(x=>x.Id==id).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateAsync(KnowledgeArea entity)
        {
            var item = _db.Areas.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return item != null;
        }
    }
}
