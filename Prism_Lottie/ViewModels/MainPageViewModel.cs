using Lottie.Forms;
using Prism.Commands;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prism_Lottie.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ICommand _playCommand;

        public MainPageViewModel(INavigationService navigationService)
                    : base(navigationService)
        {
            Title = "Main Page";

            ClickCommand = new DelegateCommand(PopupAction);

            PlayCommand = new Command<AnimationView>((animationView) =>
            {
                animationView.PlayAnimation();
            });
        }

        public ICommand ClickCommand { get; set; }

        public ICommand PlayCommand
        {
            get { return _playCommand; }
            set { SetProperty(ref _playCommand, value); }
        }

        private async void PopupAction()
        {
            await Application.Current.MainPage.DisplayAlert("AA", "BB", "Ok");
        }
    }
}