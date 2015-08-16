using GeekSchool.Entity;
using GeekSchool.Pages;
using GeekSchool.Service;
using Sago.Framework.Universal.Library.Common.Utility;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace GeekSchool.TemplateControls
{
    public sealed class KnowledgeSystemDiagramDetailControl : Control
    {
        public KnowledgeSystemDiagramDetailControl()
        {
            this.DefaultStyleKey = typeof(KnowledgeSystemDiagramDetailControl);
        }

        public KnowledgeSystemDiagramEntity KnowledgeSystemDiagramEntity { get; set; }

        public ListView TimeLineDetailView
        {
            get
            {
                return this.GetTemplateChild("TimeLineDetailView") as ListView;
            }
        }

        public GridView TimeLineTitleView
        {
            get
            {
                return this.GetTemplateChild("TimeLineTitleView") as GridView;
            }
        }

        /// <summary>
        /// 准备分组数据
        /// </summary>
        /// <returns></returns>
        private CollectionViewSource PrepareGroupedData()
        {
            var returnCollectionViewSource = new CollectionViewSource() { IsSourceGrouped = true, ItemsPath = new PropertyPath("Courses") };

            var courses = new CourseService().GetCoursesByCourseCategory(this.KnowledgeSystemDiagramEntity.Title);

            var retunrGroupedCourses = (from course in courses
                                        group course by course.CourseGroupEntity.GroupName into groupedCourses
                                        //orderby groupedCourses.Key.GroupIndex ascending
                                        select new CourseGroupEntity()
                                        {
                                            GroupName = groupedCourses.Key,
                                            //Description = course.CourseGroupEntity.Description,
                                            //GroupIndex = groupedCourses.Key.GroupIndex,
                                            Courses = (from course in groupedCourses select course).ToList<CourseEntity>()
                                        }).ToList<CourseGroupEntity>();

            returnCollectionViewSource.Source = retunrGroupedCourses;

            return returnCollectionViewSource;
        }

        protected override void OnApplyTemplate()
        {
            this.SetItemSource(this.KnowledgeSystemDiagramEntity);

            this.TimeLineDetailView.SelectionChanged += TimeLineDetailView_SelectionChanged;

            base.OnApplyTemplate();
        }

        private void TimeLineDetailView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationUtility.Navigate(typeof(CoursePeriodsPage), this.TimeLineDetailView.SelectedItem);
        }

        public void SetDataContext(KnowledgeSystemDiagramEntity knowledgeSystemDiagramEntity)
        {
            this.DataContext = this.KnowledgeSystemDiagramEntity = knowledgeSystemDiagramEntity;
        }

        public void SetItemSource(KnowledgeSystemDiagramEntity knowledgeSystemDiagramEntity)
        {
            if (knowledgeSystemDiagramEntity == default(KnowledgeSystemDiagramEntity))
                return;

            this.SetDataContext(knowledgeSystemDiagramEntity);

            var collectionViewSource = this.PrepareGroupedData();

            if (this.TimeLineDetailView != default(ListView) && TimeLineTitleView != default(GridView))
            {
                this.TimeLineDetailView.ItemsSource = collectionViewSource.View;
                this.TimeLineTitleView.ItemsSource = collectionViewSource.View.CollectionGroups;
            }
        }
    }
}
