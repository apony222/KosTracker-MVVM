using KosTracker.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosTracker.Data.SqlOperations
{
    internal class KostenSollEntity : IDataHelper<KostenSoll>
    {
        DBContext dbContext;
        public KostenSollEntity()
        {
            dbContext = new DBContext();
        }
        public async Task AddAsync(KostenSoll table)
        {
            dbContext.kostenSoll.Add(table);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            var Item= await dbContext.kostenSoll.FindAsync(Id);
            dbContext.kostenSoll.Remove(Item);
            await dbContext.SaveChangesAsync();
        }


        public async Task<KostenSoll> FindAsync(int Id)
        {
            return await dbContext.kostenSoll.FindAsync(Id);
        }

        public async Task<List<KostenSoll>> GetAllAsync()
        {
            return await dbContext.kostenSoll.ToListAsync();
        }

        public async Task<List<KostenSoll>> SearchAsync(string Item)
        {
            return await dbContext.kostenSoll.Where
                (
                x=>Convert.ToDouble(x.Miete) == Convert.ToDouble(Item)
                || Convert.ToDouble(x.Nebenkosten) == Convert.ToDouble(Item)
                || Convert.ToDouble(x.Lebensmittel) == Convert.ToDouble(Item)
                || Convert.ToDouble(x.Gesundheit) == Convert.ToDouble(Item)
                || Convert.ToDouble(x.Versicherung) == Convert.ToDouble(Item)
                || Convert.ToDouble(x.Transport) == Convert.ToDouble(Item)
                || Convert.ToDouble(x.Bekleidung) == Convert.ToDouble(Item)
                || Convert.ToDouble(x.Unterhaltung) == Convert.ToDouble(Item)
                ).ToListAsync();
        }

        public async Task UpdateAsync(KostenSoll table)
        {
            dbContext.kostenSoll.Update(table);
            await dbContext.SaveChangesAsync();
        }
    }
}
