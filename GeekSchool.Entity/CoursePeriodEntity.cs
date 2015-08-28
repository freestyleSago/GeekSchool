using Sago.Framework.Universal.Library.Common.BaseEntity;
using Sago.Framework.Universal.Library.Common.Utility;
using System;
using Windows.Storage;

namespace GeekSchool.Entity
{
    /// <summary>
    /// 课时
    /// </summary>
    public class CoursePeriodEntity : NotificationEntityBase
    {
        private SettingEntity _SettingEntity = new SettingEntity();
        private ResourceUtility _ResourceUtility = new ResourceUtility();

        /// <summary>
        /// 用于区分文件的唯一标识
        /// </summary>
        public Guid ID { get; set; } = Guid.NewGuid();

        public int Index
        {
            get; set;
        }

        /// <summary>
        /// 课时时常
        /// </summary>
        public TimeSpan Minutes
        {
            get; set;
        }

        /// <summary>
        /// 课时名称
        /// </summary>
        public string Title
        {
            get; set;
        }

        /// <summary>
        /// 课时描述
        /// </summary>
        public string Description
        {
            get; set;
        }

        /// <summary>
        /// 课程地址
        /// </summary>
        public Uri Source
        {
            get; set;
        }

        public Uri CachedSource { get; set; }

        private bool _IsCached;
        /// <summary>
        /// 是否已经缓存过
        /// </summary>
        public bool IsCached
        {
            get
            {
                return this._IsCached;
            }
            set
            {
                this._IsCached = value;
                base.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// 缓存状态描述
        /// </summary>
        public string CacheStatus
        {
            get
            {
                return this.IsCached ? _ResourceUtility.GetString("CoursePeriodEntity_CacheStatus_Cached") : _ResourceUtility.GetString("CoursePeriodEntity_CacheStatus_UnCached");
            }
        }

        private bool _IsDownloading;
        public bool IsDownloading
        {
            get
            {
                return this._IsDownloading;
            }
            set
            {
                this._IsDownloading = value;
                base.NotifyPropertyChanged();
            }
        }

        private double _DownloadProgress = 0;
        /// <summary>
        /// 下载进度
        /// </summary>
        public double DownloadProgress
        {
            get
            {
                return this._DownloadProgress;
            }
            set
            {
                if (value >= 100)
                {
                    this.IsCached = true;
                    this.IsDownloading = false;
                }
                else
                {
                    this.IsDownloading = true;
                }
                this._DownloadProgress = value;
                base.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// 检测是否是已缓存设备
        /// </summary>
        public async void CheckIsCacheStatus()
        {
            this.IsCached = ApplicationData.Current.LocalSettings.CreateContainer(this._SettingEntity.DownloadedLessonDataEntityContainerName, ApplicationDataCreateDisposition.Always).Values.ContainsKey(this.ID.ToString());

            //已缓存的情况，就从本地读取视频
            if (this.IsCached)
            {
                this.CachedSource = null;
                //缓存视频流的文件夹
                var downloadedLessonsFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync(this._SettingEntity.DownloadedLessonsFolder, CreationCollisionOption.OpenIfExists);

                var cachedFile = await downloadedLessonsFolder.CreateFileAsync(this.ID.ToString(), CreationCollisionOption.OpenIfExists);
                this.CachedSource = new Uri(cachedFile.Path);
            }
            else
            {
                this.CachedSource = this.Source;
            }
        }
    }
}
