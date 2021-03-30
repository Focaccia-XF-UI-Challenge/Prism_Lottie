
using System.Diagnostics;
using Prism_Lottie.ViewModels;
using Xamarin.Forms;

namespace Prism_Lottie.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        protected override void OnSizeAllocated(double width, double height)
        {
            Debug.WriteLine($"{this.Title} 進入到 OnSizeAllocated Width:{width},height:{height}");
            base.OnSizeAllocated(width, height);
            animationView.PlayAnimation();
        }
    }
}
