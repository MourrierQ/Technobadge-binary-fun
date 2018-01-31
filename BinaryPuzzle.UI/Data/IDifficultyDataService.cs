using System.Threading.Tasks;
using BinaryPuzzle.Model;

namespace BinaryPuzzle.UI.Data
{
    public interface IDifficultyDataService
    {
        Task<Difficulty> GetByIdAsync(int DifficultyId);
    }
}