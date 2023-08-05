using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Demo.Models;
using Demo.Services;
using Demo.Views;

namespace Demo.ViewModels
{
    [QueryProperty(nameof(User), "UserDetails")]
    public partial class DetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        private User _user;
        public DetailsViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        [RelayCommand]
        public void GoHome()
        {
            navigationService.NavigateToAsync($"//{nameof(Home)}");
        }
    }
}
