using CommunityToolkit.Mvvm.ComponentModel;
using Demo.Services;

namespace Demo.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        protected readonly INavigationService navigationService;
        public BaseViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
    }
}
