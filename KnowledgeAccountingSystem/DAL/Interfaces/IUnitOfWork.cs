using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {

        IAreaRepository AreaRepository { get; }
       Task<int> SaveAsync();
        
    }
}
