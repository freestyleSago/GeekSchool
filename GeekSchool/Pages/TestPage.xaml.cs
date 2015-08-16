using GeekSchool.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GeekSchool.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestPage : Page
    {
        public TestPage()
        {
            this.InitializeComponent();
            //this.ListView.ItemsSource = new KnowledgeSystemDiagramService().GetEntityForKnowledgeSystemDiagram();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.MediaElement.IsFullWindow = !this.MediaElement.IsFullWindow;

            //this.MediaElement.Width = this.MediaElementContainer.Width = Window.Current.Bounds.Width;
            //this.MediaElement.Height = this.MediaElementContainer.Height = Window.Current.Bounds.Height;
        }
    }
}
