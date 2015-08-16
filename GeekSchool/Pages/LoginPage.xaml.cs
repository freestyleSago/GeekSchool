using GeekSchool.Entity;
using GeekSchool.Service;
using Sago.Framework.Universal.Library.Common.Utility;
using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GeekSchool.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
            this.SizeChanged += (sender, e) => this.HorizontalOffsetX = this.MainStackPanel.ActualWidth - 50;

            Window.Current.Content.KeyUp += LoginPage_KeyUp;

            this.DataContext = this;
        }

        private void LoginPage_KeyUp(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                this.ToggleButtonLoginIn.ToggleVisualState();
                this.Login();
                e.Handled = true;
            }
        }

        private LoginService _LoginService = new LoginService();

        private string Account
        {
            get
            {
                return this.TextBoxAccount.Text.Trim();
            }
        }

        private string Password
        {
            get
            {
                return this.PasswordBoxPassword.Password.Trim();
            }
        }

        public double HorizontalOffsetX
        {
            get { return (double)GetValue(HorizontalOffsetXProperty); }
            set { SetValue(HorizontalOffsetXProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HorizontalOffsetX.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HorizontalOffsetXProperty =
            DependencyProperty.Register("HorizontalOffsetX", typeof(double), typeof(LoginPage), new PropertyMetadata(default(double)));

        public double CurrentHorizontalOffsetX
        {
            get { return (double)GetValue(CurrentHorizontalOffsetXProperty); }
            set { SetValue(CurrentHorizontalOffsetXProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentHorizontalOffsetX.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentHorizontalOffsetXProperty =
            DependencyProperty.Register("CurrentHorizontalOffsetX", typeof(double), typeof(LoginPage), new PropertyMetadata(default(double)));

        private void ToggleButtonLoginIn_Click(object arg1, Sago.Framework.Universal.TemplateControls.ToggleButton.ToggleButtonRoutedEventArgs arg2)
        {
            this.Login();
        }

        private bool Validate()
        {
            var flag = true;
            return flag;
        }

        private void Login()
        {
            if (!this.Validate())
            {
                this.LoginFailure();
                return;
            }

            var userEntity = this._LoginService.Login(this.Account, this.Password);

            if (userEntity == default(UserEntity))
            {
                this.LoginFailure();
                return;
            }

            //login success
            this.LoginSuccess(userEntity);
        }

        private async void LoginFailure()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            //this.ToggleButtonLoginIn.StopAnimation();

            ((DoubleAnimation)this.ToggleButtonLoginIn.VisualStateOne.Children[0]).From = this.TextBlockLoginInTranslateTransform.X;

            this.ToggleButtonLoginIn.ToggleVisualState();
        }

        private void LoginSuccess(UserEntity userEntity)
        {
            NavigationUtility.Navigate(typeof(HotNewsPage));
            NavigationUtility.RemoveBackStackEntry(typeof(LoginPage));
            _LoginService.SaveUserSession(userEntity);
        }
    }
}
