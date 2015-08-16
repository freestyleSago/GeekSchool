using GeekSchool.Entity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GeekSchool.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoursePeriodsPage : Page
    {
        public CoursePeriodsPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
            this.MediaPlayerControl.DownLoadEvent += uri =>
            {

            };
            this.Loaded += CoursePeriodsPage_Loaded;
        }

        private CourseEntity Course { get; set; }

        public CoursePeriodEntity SelectedCoursePeriod
        {
            get { return (CoursePeriodEntity)GetValue(SelectedCoursePeriodProperty); }
            set { SetValue(SelectedCoursePeriodProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedCoursePeriod.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedCoursePeriodProperty =
            DependencyProperty.Register("SelectedCoursePeriod", typeof(CoursePeriodEntity), typeof(CoursePeriodsPage), new PropertyMetadata(default(CoursePeriodEntity)));

        private void CoursePeriodsPage_Loaded(object sender, RoutedEventArgs e)
        {
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.Course = e.Parameter as CourseEntity;
            this.ListViewCoursePeriods.ItemsSource = this.Course.CoursePeriods;
            base.OnNavigatedTo(e);
        }

        private void ListViewCoursePeriods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.SelectedCoursePeriod = this.ListViewCoursePeriods.SelectedItem as CoursePeriodEntity;
            this.MediaPlayerControl.Source = SelectedCoursePeriod.Source;
        }
    }
}
