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
    public class LookupDataService : IUserLookupDataService, IDifficultyLookupDataService
    {
        private Func<BinaryPuzzleDbContext> _contextCreator;

        public LookupDataService(Func<BinaryPuzzleDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetUserLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Players.AsNoTracking()
                                .Select(u => new LookupItem
                                {
                                    Id = u.Id,
                                    DisplayMember = u.Name + " Lvl: " + u.Level
                                })
                                .ToListAsync();

            }
        }

        public async Task<IEnumerable<LookupItem>> GetDifficultyLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Difficulty.AsNoTracking()
                                .Select(d => new LookupItem
                                {
                                    Id = d.Id,
                                    DisplayMember = d.Name 
                                })
                                .ToListAsync();

            }
        }
    }
}
