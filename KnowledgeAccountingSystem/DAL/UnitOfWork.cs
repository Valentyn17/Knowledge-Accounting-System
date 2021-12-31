using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AccountingSystemDbContext _db;
        private IAreaRepository _areaRepository; 
        public UnitOfWork(AccountingSystemDbContext accountigSystemDbContext)
        {
            _db = accountigSystemDbContext;
        }

        public IAreaRepository AreaRepository
        {
            get
            {
                if (_areaRepository == null)
                    _areaRepository = new AreaRepository(_db);
                return _areaRepository;
            }
        }


        public async  Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }
    }
}
