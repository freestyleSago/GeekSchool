using Sago.Framework.Universal.Library.Common.BaseEntity;
using System;

namespace GeekSchool.Entity
{
    /// <summary>
    /// 课时
    /// </summary>
    public class CoursePeriodEntity : NotificationEntityBase
    {
        private int _Index;

        public int Index
        {
            get { return this._Index; }
            set { this._Index = value; base.NotifyPropertyChanged(); }
        }

        private TimeSpan _Minutes;
        /// <summary>
        /// 课时时常
        /// </summary>
        public TimeSpan Minutes
        {
            get { return this._Minutes; }
            set { this._Minutes = value; base.NotifyPropertyChanged(); }
        }

        private string _Title;
        /// <summary>
        /// 课时名称
        /// </summary>
        public string Title
        {
            get { return this._Title; }
            set { this._Title = value; base.NotifyPropertyChanged(); }
        }

        private string _Description;
        /// <summary>
        /// 课时描述
        /// </summary>
        public string Description
        {
            get { return this._Description; }
            set { this._Description = value; base.NotifyPropertyChanged(); }
        }

        private Uri _Source;
        /// <summary>
        /// 课程地址
        /// </summary>
        public Uri Source
        {
            get { return this._Source; }
            set { this._Source = value; base.NotifyPropertyChanged(); }
        }
    }
}
