using BinaryPuzzle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.UI.Data
{
    public interface IDifficultyLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetDifficultyLookupAsync();
    }
}
