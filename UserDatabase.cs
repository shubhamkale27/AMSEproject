using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace prototype
{
    public class UserDatabase
    {
        readonly SQLiteAsyncConnection database;

        public UserDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUsersAsync()
        {
            return database.Table<User>().ToListAsync();
        }

        public Task<User> GetUserAsync(int id)
        {
            return database.Table<User>().Where(i => i.UserId == id ).FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User item)
        {
            if(item.UserId != 0)
            {
                return database.UpdateAsync(item);
            } else{
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteUserAsync(User item)
        {
            return database.DeleteAsync(item);
        }
    }
}
