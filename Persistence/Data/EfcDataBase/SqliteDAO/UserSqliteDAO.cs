using System.Linq;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataBase.SqliteDAO;

public class UserSqliteDAO : IUserService
{
    private readonly Context context;
    
    public UserSqliteDAO(Context context)
    {
        this.context = context;
    }
    public async Task<IList<User>> GetAsync()
    {
        IList<User> users = await context.Users.ToListAsync();
        return users;
    }

    public async Task<User> GetUserByUsername(string username)
    {
        IQueryable<User> users = context.Users.AsQueryable();
        users = users.Where(u => u.username == username);
        ICollection<User> result = await users.ToListAsync();
        foreach (var item in result)
        {
            return item;
        }
        return null;
    }
    public async Task<User> GetUserById(int id)
    {
        User? user = await context.Users.FindAsync(id); //Works as long as the ID is a the only primary key for User
        return user;
    }
    public async Task AddUserAsync(User user)
    {
        EntityEntry<User> added = await context.AddAsync(user);
        await context.SaveChangesAsync();
        //return added.Entity; // For data about the result
    }

    public async Task DeleteAsync(int id)
    {
        User? existing = await context.Users.FindAsync(id);
        if (existing is null)
        {
            throw new Exception($"Could not find Post with id {id}. Nothing was deleted");
        }

        context.Users.Remove(existing);
        await context.SaveChangesAsync();
    }

    public Task UpdateAsync(User user)
    {
        context.Users.Update(user);
        return context.SaveChangesAsync();
    }
}