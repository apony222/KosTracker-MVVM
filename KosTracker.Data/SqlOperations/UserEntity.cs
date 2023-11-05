using KosTracker.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosTracker.Data.SqlOperations
{
    public class UserEntity : IDataHelper<User>
    {
        DBContext dbContext;
        public UserEntity()
        {
            dbContext = new DBContext();
        }
        public async Task AddAsync(User table)
        {
            dbContext.Users.Add(table);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
           var Item= await dbContext.Users.FindAsync(Id);
            dbContext.Users.Remove(Item);
            await dbContext.SaveChangesAsync();
        }

        public async Task<User> FindAsync(int Id)
        {
            return await dbContext.Users.FindAsync(Id);
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await dbContext.Users.ToListAsync();
        }

        public Task<List<User>> SearchAsync(string Item)
        {
            return dbContext.Users.Where
                (
                x=>x.Id == Convert.ToInt32(Item)
                || x.Name.Contains(Item)
                || x.UserName.Contains(Item)
                ).ToListAsync();
        }

        public async Task UpdateAsync(User table)
        {
            dbContext.Users.Update(table);
            await dbContext.SaveChangesAsync();
        }
    }
}
