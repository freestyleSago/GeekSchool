using GeekSchool.Entity;
using GeekSchool.Service;
using Sago.Framework.Universal.Library.Common.Utility;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GeekSchool.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PersonalCenterPage : Page
    {
        public PersonalCenterPage()
        {
            this.InitializeComponent();
            this.DataContext = PersonalCenterEntity = new PersonalCenterService().GetPersonalCenterEntity();
            this.SizeChanged += PersonalCenterPage_SizeChanged;
        }

        public PersonalCenterEntity PersonalCenterEntity
        {
            get { return (PersonalCenterEntity)GetValue(PersonalCenterEntityProperty); }
            set { SetValue(PersonalCenterEntityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PersonalCenterEntity.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PersonalCenterEntityProperty =
            DependencyProperty.Register("PersonalCenterEntity", typeof(PersonalCenterEntity), typeof(PersonalCenterEntity), new PropertyMetadata(default(PersonalCenterEntity)));

        private void PersonalCenterPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //宽屏设备最小宽度
            var minWindowWidthOfWideView = double.Parse(Application.Current.Resources["MinWindowWidthOfWide"].ToString());

            //宽屏
            if (Window.Current.Bounds.Width >= minWindowWidthOfWideView)
            {
                #region InitializeGridView
                #region 学习记录
                var gridViewForLearningRecord = new GridView()
                {
                    Name = "GridViewLearningRecord",
                    ItemsSource = this.PersonalCenterEntity.LearningRecordEntities,
                    Style = this.Resources["GridViewCourses"] as Style
                };
                gridViewForLearningRecord.SelectionChanged += ListViewOrGridView_SelectionChanged;
                this.PivotItemLearningRecord.Content = gridViewForLearningRecord;
                #endregion

                #region 收藏课程
                var gridViewForFavoritesCourse = new GridView()
                {
                    Name = "GridViewFavoritesCourse",
                    ItemsSource = this.PersonalCenterEntity.FavoritesCourseEntities,
                    Style = this.Resources["GridViewCourses"] as Style
                };
                gridViewForFavoritesCourse.SelectionChanged += ListViewOrGridView_SelectionChanged;
                this.PivotItemFavorites.Content = gridViewForFavoritesCourse;
                #endregion

                #endregion
            }
            //窄屏
            else
            {
                #region InitializeListView
                #region 学习记录
                var listViewForLearningRecord = new ListView()
                {
                    Name = "ListViewLearningRecord",
                    ItemsSource = this.PersonalCenterEntity.LearningRecordEntities,
                    Style = this.Resources["ListViewLearningRecord"] as Style
                };
                listViewForLearningRecord.SelectionChanged += ListViewOrGridView_SelectionChanged;
                this.PivotItemLearningRecord.Content = listViewForLearningRecord;
                #endregion

                #region 收藏课程
                var listViewForFavoritesCourse = new ListView()
                {
                    Name = "ListViewFavoritesCourse",
                    ItemsSource = this.PersonalCenterEntity.FavoritesCourseEntities,
                    Style = this.Resources["ListViewLearningRecord"] as Style
                };
                listViewForFavoritesCourse.SelectionChanged += ListViewOrGridView_SelectionChanged;
                this.PivotItemFavorites.Content = listViewForFavoritesCourse;
                #endregion

                #endregion
            }
        }

        /// <summary>
        /// 学习记录的GirdView或ListView的选择项改变事件处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewOrGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var courseEntity = (sender as ListViewBase).SelectedItem as CourseEntity;
            if (courseEntity != default(CourseEntity))
            {
                NavigationUtility.Navigate(typeof(CoursePeriodsPage), courseEntity);
            }
        }
    }
}
