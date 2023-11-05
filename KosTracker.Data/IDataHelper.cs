using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosTracker.Data
{
    public interface IDataHelper<Table>
    {
        //Read
        Task<List<Table>> GetAllAsync();
        Task<List<Table>> SearchAsync(string Item);
        Task<Table> FindAsync(int Id);
        //Write
        Task AddAsync(Table table);
        Task UpdateAsync(Table table);
        Task DeleteAsync(int Id);

    }
}
