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
    public class DifficultyDataService : IDifficultyDataService
    {
        private Func<BinaryPuzzleDbContext> _contextCreator;

        public DifficultyDataService(Func<BinaryPuzzleDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<Difficulty> GetByIdAsync(int DifficultyId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Difficulty.AsNoTracking().SingleAsync(d => d.Id == DifficultyId);
            }
        }

       
    }
}
