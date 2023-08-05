
namespace Demo.Services
{
    public class NavigationService : INavigationService
    {
        public Task NavigateToAsync(string ContentPageName, IDictionary<string, object> parameters = null)
        {
           if (parameters == null)
                return Shell.Current.GoToAsync(ContentPageName);
           else
                return Shell.Current.GoToAsync(ContentPageName, parameters);
        }
    }
}
