using BinaryPuzzle.DataAccess;
using BinaryPuzzle.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.UI.Data
{
    public class UserDataService : IUserDataService
    {
        private Func<BinaryPuzzleDbContext> _contextCreator;

        public UserDataService(Func<BinaryPuzzleDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<Player> GetByIdAsync(int friendId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Players.AsNoTracking().SingleAsync(f => f.Id == friendId);
            }
        }

        public async Task SaveAsync(Player user)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Players.Attach(user);
                ctx.Entry(user).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }
        }
    }
}
