using GeekSchool.Pages;
using GeekSchool.Service;
using Sago.Framework.Universal.Library.Common.Utility;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GeekSchool
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            App.OnHardwareButtonsBackPressed += () => NavigationUtility.GoBack();

            NavigationUtility.SetFrame(this.MainNavigationFrame);

            this.DataContext = this;

            LoginService.LoginIn += userEntity => this.IsLogin = true;
            LoginService.LoginOut += () => this.IsLogin = false;
            LoginService.CheckLoginStatus();
        }

        #region

        public bool IsLogin
        {
            get { return (bool)GetValue(IsLoginProperty); }
            set { SetValue(IsLoginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsLogin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsLoginProperty =
            DependencyProperty.Register("IsLogin", typeof(bool), typeof(MainPage), new PropertyMetadata(default(bool)));

        #endregion

        private void MainListViewForContrlButtons_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedItem = e.ClickedItem as Grid;

            switch (selectedItem.Tag.ToString())
            {
                case "KnowledgeSystemDiagram":
                    this.MainFrameNavigate(typeof(KnowledgeSystemDiagramPage));
                    break;
                case "HotNews":
                    this.MainFrameNavigate(typeof(HotNewsPage));
                    break;
                case "PersonalCenter":
                    this.MainFrameNavigate(typeof(PersonalCenterPage));
                    break;
                case "LoginIn":
                    this.MainFrameNavigate(typeof(LoginPage));
                    break;
                case "LoginOut":
                    new LoginService().ClearUserSession();
                    break;
                case "Test":
                    this.Frame.Navigate(typeof(TestPage));
                    break;
                default:
                    break;
            }
        }

        private void MainFrameNavigate(Type pageType, object parameters = default(object))
        {
            this.MainNavigationFrame.Navigate(pageType, parameters);
        }

        private void ToggleButtonNavigation_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            NavigationUtility.GoBack();
        }

        private void ToggleButtonSplitViewPane_Click(object arg1, Sago.Framework.Universal.TemplateControls.ToggleButton.ToggleButtonRoutedEventArgs arg2)
        {
            this.Splitter.IsPaneOpen = !Splitter.IsPaneOpen;
        }

        private void Splitter_PaneClosing(SplitView sender, SplitViewPaneClosingEventArgs args)
        {
            //是展开状态时，才触发切换状态的方法
            if (!ToggleButtonSplitViewPane.IsVisualStateOne)
                this.ToggleButtonSplitViewPane.ToggleVisualState();
        }
    }
}
