using CommunityToolkit.Mvvm.Input;
using Demo.Models;
using Demo.Services;
using Demo.Views;
using System.Collections.ObjectModel;

namespace Demo.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<User> Users { get; set; } = new();
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            AddUsers();
        }

        private void AddUsers()
        {
            Users.Add(new User() { Id = 1, Name = "Frank Hughes", Email = "Frank@mail.com", Country = "GH"});
            Users.Add(new User() { Id = 2, Name = "Rosemond Hughes", Email = "Rosemond@mail.com", Country = "USA" });
            Users.Add(new User() { Id = 3, Name = "Casper Hughes", Email = "Casper@mail.com", Country = "UK" });
            Users.Add(new User() { Id = 4, Name = "Cook Hughes", Email = "Cook@mail.com", Country = "NG" });
            Users.Add(new User() { Id = 5, Name = "Hanson Hughes", Email = "Hanson@mail.com", Country = "SA" });
            Users.Add(new User() { Id = 6, Name = "Healthy Hughes", Email = "Healthy@mail.com", Country = "NZ" });
            Users.Add(new User() { Id = 7, Name = "Mike Hughes", Email = "Mike@mail.com", Country = "SL" });
            Users.Add(new User() { Id = 8, Name = "Job Hughes", Email = "Job@mail.com", Country = "BE" });
            Users.Add(new User() { Id = 9, Name = "Richmond Hughes", Email = "Richmond@mail.com", Country = "IV" });
            Users.Add(new User() { Id = 10, Name = "Hubert Hughes", Email = "Hubert@mail.com", Country = "MR" });
        }

        [RelayCommand]
        public void UserTapped(User user)
        {
            navigationService.NavigateToAsync(nameof(Details), new Dictionary<string, object>
            {
                {"UserDetails", user }
            });
        }
    }
}
