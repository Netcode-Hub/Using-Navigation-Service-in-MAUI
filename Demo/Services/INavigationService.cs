
namespace Demo.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync(string ContentPageName, IDictionary<string, object> parameters = null);
    }
}
