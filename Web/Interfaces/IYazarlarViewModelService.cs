using Web.Models;

namespace Web.Interfaces
{
    public interface IYazarlarViewModelService
    {
        Task<YazarlarViewModel> GetYazarlarVm();
    }
}
