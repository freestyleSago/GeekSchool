using GeekSchool.Entity;
using Sago.Framework.Universal.Library.Common.Utility;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Linq;

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

            //ListView左侧点击事件
            this.ListViewCoursePeriods.LeftEdgeTapped += ListViewCoursePeriods_LeftEdgeTapped;
            this.KeyUp += CoursePeriodsPage_KeyUp;
        }

        #region Field
        private CancellationTokenSource _CancellationTokenSource = new CancellationTokenSource();

        private IDictionary<Guid, DownloadOperation> ActivelyDownload = new Dictionary<Guid, DownloadOperation>();
        #endregion

        #region Property
        /// <summary>
        /// 当前课程
        /// </summary>
        private CourseEntity Course { get; set; }

        /// <summary>
        /// 当前选中的课时
        /// </summary>
        public CoursePeriodEntity SelectedCoursePeriod { get; set; }

        /// <summary>
        /// 课时列表是否是多选状态
        /// </summary>
        public bool IsMultipleSelectionModeOfLessonsListView
        {
            get { return (bool)GetValue(IsMultipleSelectionModeOfLessonsListViewProperty); }
            set { SetValue(IsMultipleSelectionModeOfLessonsListViewProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsMultipleSelectionModeOfLessonsListView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsMultipleSelectionModeOfLessonsListViewProperty =
            DependencyProperty.Register("IsMultipleSelectionModeOfLessonsListView", typeof(bool), typeof(CoursePeriodsPage), new PropertyMetadata(default(bool)));

        /// <summary>
        /// 是否是正在下载
        /// </summary>
        public bool IsDownloadEnable
        {
            get { return (bool)GetValue(IsDownloadEnableProperty); }
            set { SetValue(IsDownloadEnableProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsDownloadEnable.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsDownloadEnableProperty =
            DependencyProperty.Register("IsDownloadEnable", typeof(bool), typeof(CoursePeriodsPage), new PropertyMetadata(true));

        /// <summary>
        /// 是否是全屏状态
        /// </summary>
        public bool IsFullScreen
        {
            get { return (bool)GetValue(IsFullScreenProperty); }
            set { SetValue(IsFullScreenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsFullScreen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsFullScreenProperty =
            DependencyProperty.Register("IsFullScreen", typeof(bool), typeof(CoursePeriodsPage), new PropertyMetadata(default(bool)));
        #endregion

        #region Method
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.Course = e.Parameter as CourseEntity;
            this.Initialize();
            base.OnNavigatedTo(e);
        }

        /// <summary>
        /// 课时列表选择切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewCoursePeriods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.ListViewCoursePeriods.SelectedItem != default(object) && this.ListViewCoursePeriods.SelectionMode == ListViewSelectionMode.Single)
            {
                this.SelectedCoursePeriod = this.ListViewCoursePeriods.SelectedItem as CoursePeriodEntity;
                this.MediaPlayerControl.Source = this.SelectedCoursePeriod.CachedSource;
            }

            if (this.ListViewCoursePeriods.SelectedItems.Count == 0)
            {
                this.ListViewCoursePeriods.SelectionMode = ListViewSelectionMode.Single;
            }

            this.ToggleCommandButtonVisibility();
        }

        /// <summary>
        /// 课时列表Item左侧边缘点击切换多选状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewCoursePeriods_LeftEdgeTapped(object sender, Sago.Framework.Universal.TemplateControls.EdgeTappedListView.EdgeTappedListViewEventArgs e)
        {
            this.ListViewCoursePeriods.SelectionMode = ListViewSelectionMode.Multiple;
        }

        /// <summary>
        /// 初始化本页的一些事情
        /// </summary>
        private void Initialize()
        {
            foreach (var lesson in this.Course.CoursePeriods)
            {
                lesson.CheckIsCacheStatus();
            }
            this.ListViewCoursePeriods.ItemsSource = this.Course.CoursePeriods;
        }

        #endregion

        #region MediaElement Event
        /// <summary>
        /// 键盘监听事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoursePeriodsPage_KeyUp(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.GoBack)
            {
                this.MediaPlayerControl.IsFullWindow = !this.MediaPlayerControl.IsFullWindow;
            }
        }

        /// <summary>
        /// MediaElement状态改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediaPlayerControl_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            switch (this.MediaPlayerControl.CurrentState)
            {
                case Windows.UI.Xaml.Media.MediaElementState.Closed:
                    break;
                case Windows.UI.Xaml.Media.MediaElementState.Opening:
                    break;
                case Windows.UI.Xaml.Media.MediaElementState.Buffering:
                    break;
                case Windows.UI.Xaml.Media.MediaElementState.Playing:
                    break;
                case Windows.UI.Xaml.Media.MediaElementState.Paused:
                    break;
                case Windows.UI.Xaml.Media.MediaElementState.Stopped:
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region BottomAppBar Event
        /// <summary>
        /// 切换CommandBar的显示状态
        /// </summary>
        private void ToggleCommandButtonVisibility()
        {
            this.IsMultipleSelectionModeOfLessonsListView = this.ListViewCoursePeriods.SelectionMode == ListViewSelectionMode.Multiple && this.ListViewCoursePeriods.SelectedItems.Count > 0;
        }

        /// <summary>
        /// 切换一些控件的启用状态
        /// </summary>
        /// <param name="isEnabled"></param>
        private void ToggleCommandButtonEnable(bool isEnabled)
        {
            this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High, () =>
             {
                 this.IsDownloadEnable = isEnabled;
             });
        }

        /// <summary>
        /// 多选切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppBarButtonSelectAll_Click(object sender, RoutedEventArgs e)
        {
            this.ListViewCoursePeriods.SelectionMode = ListViewSelectionMode.Multiple;
            this.ToggleCommandButtonVisibility();
        }

        /// <summary>
        /// 取消多选状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppBarButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ListViewCoursePeriods.SelectionMode = ListViewSelectionMode.Single;
            this.ToggleCommandButtonVisibility();
        }

        /// <summary>
        /// 下载按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AppBarButtonDownload_Click(object sender, RoutedEventArgs e)
        {
            this.ToggleCommandButtonEnable(false);
            var backgroundTransferGroup = BackgroundTransferGroup.CreateGroup(Guid.NewGuid().ToString());
            var downloadTasks = new Task[this.ListViewCoursePeriods.SelectedItems.Count];

            var i = 0;
            foreach (var item in this.ListViewCoursePeriods.SelectedItems)
            {
                var coursePeriodEntity = item as CoursePeriodEntity;

                var backgroundDownloader = new BackgroundDownloader();
                backgroundDownloader.TransferGroup = backgroundTransferGroup;

                var downloadOperation = backgroundDownloader.CreateDownload(coursePeriodEntity.Source, await this.DiscoverDestinationFile(coursePeriodEntity));
                downloadOperation.Priority = BackgroundTransferPriority.Default;

                //加入到活动下载队列中
                this.ActivelyDownload.Add(coursePeriodEntity.ID, downloadOperation);

                downloadTasks[i] = this.HandleDownloadAsync(downloadOperation);
                i++;
            }

            this.ListViewCoursePeriods.SelectionMode = ListViewSelectionMode.Single;
            this.ToggleCommandButtonVisibility();

            Task.Factory.StartNew(() =>
            {
                try
                {
                    //等待所有下载任务完成
                    Task.WaitAll(downloadTasks);
                }
                catch (AggregateException ex)
                {

                }
                finally
                {
                    this.ActivelyDownload.Clear();
                    this.ToggleCommandButtonEnable(true);
                }
            });
        }

        #endregion

        #region Download Event

        private async Task<StorageFile> DiscoverDestinationFile(CoursePeriodEntity coursePeriodEntity)
        {
            //缓存视频流的文件夹
            var downloadedLessonsFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync(App.Settings.DownloadedLessonsFolder, CreationCollisionOption.OpenIfExists);

            return await downloadedLessonsFolder.CreateFileAsync(coursePeriodEntity.ID.ToString(), CreationCollisionOption.OpenIfExists);
        }

        private async Task HandleDownloadAsync(DownloadOperation downloadOperation)
        {
            var progressCallback = new Progress<DownloadOperation>(this.DownloadProgress);

            await downloadOperation.StartAsync().AsTask(this._CancellationTokenSource.Token, progressCallback);
        }

        private async void DownloadProgress(DownloadOperation downloadOperation)
        {
            double percent = 0;
            if (downloadOperation.Progress.TotalBytesToReceive > 0)
            {
                percent = downloadOperation.Progress.BytesReceived * 100 / downloadOperation.Progress.TotalBytesToReceive;
            }

            var currentDownloadCoursePeriods = this.Course.CoursePeriods.Single<CoursePeriodEntity>(coursePeriods => coursePeriods.ID == this.ActivelyDownload.Single<KeyValuePair<Guid, DownloadOperation>>(activelyDownload => activelyDownload.Value == downloadOperation).Key);

            //只有当进度为100%时，才开始缓存文件信息
            if (percent >= 100)
            {
                #region 缓存视频信息
                var downloadedLessonDataEntityContainer = ApplicationData.Current.LocalSettings.CreateContainer(App.Settings.DownloadedLessonDataEntityContainerName, ApplicationDataCreateDisposition.Always);

                var serializeUtility = new SerializationUtility();

                //如果本地已经存在这个Key，那么表示缓存过视频，那么就需要更新视频信息及视频流
                if (downloadedLessonDataEntityContainer.Values.ContainsKey(currentDownloadCoursePeriods.ID.ToString()))
                {
                    //更新视频基本信息
                    downloadedLessonDataEntityContainer.Values[currentDownloadCoursePeriods.ID.ToString()] = serializeUtility.Serialize<CoursePeriodEntity>(currentDownloadCoursePeriods);
                }
                //如果本地不存在这个Key，那么就表示没有缓存过视频，就需要录入视频信息及视频流
                else
                {
                    //录入视频基本信息
                    downloadedLessonDataEntityContainer.Values.Add(currentDownloadCoursePeriods.ID.ToString(), serializeUtility.Serialize<CoursePeriodEntity>(currentDownloadCoursePeriods));
                }
                #endregion
            }
            await this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, new Windows.UI.Core.DispatchedHandler(() =>
             {
                 currentDownloadCoursePeriods.IsDownloading = true;
                 currentDownloadCoursePeriods.DownloadProgress = percent;
             }));
        }
        #endregion
    }
}
