using GeekSchool.Service;
using GeekSchool.Entity;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GeekSchool.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KnowledgeSystemDiagramPage : Page
    {
        public KnowledgeSystemDiagramPage()
        {
            this.InitializeComponent();

            this.ListViewKnowledgeSystemDiagram.ItemsSource = this._KnowledgeSystemDiagramEntities = new ObservableCollection<KnowledgeSystemDiagramEntity>(_KnowledgeSystemDiagramService.GetEntityForKnowledgeSystemDiagram());
        }

        private KnowledgeSystemDiagramService _KnowledgeSystemDiagramService = new KnowledgeSystemDiagramService();

        private ObservableCollection<KnowledgeSystemDiagramEntity> _KnowledgeSystemDiagramEntities = null;

        private void ListViewKnowledgeSystemDiagram_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //如果本页的知识体系详情页被隐藏，那么表示此时是窄屏
            if (KnowledgeSystemDiagramDetailControl.Visibility == Visibility.Collapsed)
            {
                this.Frame.Navigate(typeof(KnowledgeSystemDiagramDetailPage), this.ListViewKnowledgeSystemDiagram.SelectedItem);
            }
            else
            {
                //宽屏时，直接在右侧展现详情
                this.KnowledgeSystemDiagramDetailControl.SetItemSource(this.ListViewKnowledgeSystemDiagram.SelectedItem as KnowledgeSystemDiagramEntity);
            }
        }

        //private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        //{
        //}

        //private void ListViewKnowledgeSystemDiagram_Loaded(object sender, RoutedEventArgs e)
        //{
        //    var scrollViewer = VisualTreeUtility.FindControl<ScrollViewer>(this.ListViewKnowledgeSystemDiagram, control => control as ScrollViewer);

        //    if (scrollViewer != default(ScrollViewer))
        //    {
        //        scrollViewer.ViewChanged += ScrollViewer_ViewChanged;
        //    }
        //}
    }
}
