using System.Collections.Generic;
using System.Threading.Tasks;
using BinaryPuzzle.Model;

namespace BinaryPuzzle.UI.Data
{
    public interface IUserLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetUserLookupAsync();
    }
}