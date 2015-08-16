using GeekSchool.Service;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GeekSchool.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HotNewsPage : Page
    {
        public HotNewsPage()
        {
            this.InitializeComponent();
            this.CarouselControl.ItemsSource = this._CarouselControlService.GetImagesForCarouselControl();
        }

        private CarouselControlService _CarouselControlService = new CarouselControlService();
    }
}
