using KosTracker.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosTracker.Data.SqlOperations
{
    public class KostenEntity : IDataHelper<Kosten>
    {
        DBContext dbContext;
        public KostenEntity()
        {
            dbContext = new DBContext();
        }
        public async Task AddAsync(Kosten table)
        {
            await dbContext.Kosten.AddAsync(table);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
           var Item= await dbContext.Kosten.FindAsync(Id); 
                dbContext.Kosten.Remove(Item);
                await dbContext.SaveChangesAsync();
            
        }

        public async Task<Kosten> FindAsync(int Id)
        {
           return await dbContext.Kosten.FindAsync(Id);
        }

        public async Task<List<Kosten>> GetAllAsync()
        {
            return await dbContext.Kosten.ToListAsync();
        }

        public Task<List<Kosten>> SearchAsync(string Item)
        {
            return dbContext.Kosten.Where
                (
                x=>x.Kategorie.Equals(Item)
                || Convert.ToDouble(x.Ausgabe) == Convert.ToDouble(Item)
                || x.Datum.Equals(Convert.ToDateTime(Item))
                ).ToListAsync();
        }

        public async Task UpdateAsync(Kosten table)
        {
            dbContext.Kosten.Update(table);
            await dbContext.SaveChangesAsync();
        }
    }
}
