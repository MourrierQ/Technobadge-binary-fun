using System.Threading.Tasks;
using BinaryPuzzle.Model;

namespace BinaryPuzzle.UI.Data
{
    public interface IUserDataService
    {
        Task<Player> GetByIdAsync(int friendId);
        Task SaveAsync(Player user);
    }
}