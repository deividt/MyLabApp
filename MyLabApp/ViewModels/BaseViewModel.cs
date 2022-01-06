using Prism.Navigation;

namespace MyLabApp.ViewModels
{
    public class BaseViewModel
    {
        protected readonly INavigationService Navigation;

        public BaseViewModel(INavigationService navigationService)
        {
            Navigation = navigationService;
        }
        
        public BaseViewModel()
        {
        }
    }
}