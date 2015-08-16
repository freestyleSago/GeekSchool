using System;
using System.Collections.Generic;
using System.Linq;
using Sago.Framework.Universal.Library.Common.ExtensionMethods;

namespace GeekSchool.Entity
{
    /// <summary>
    /// 课程
    /// </summary>
    public class CourseEntity
    {
        public CourseEntity()
        {
            this.CourseGroupEntity = new CourseGroupEntity();
            this.CoursePeriods = new List<CoursePeriodEntity>();
        }

        /// <summary>
        /// 课程分组
        /// </summary>
        public CourseGroupEntity CourseGroupEntity { get; set; }

        /// <summary>
        /// 课时
        /// </summary>
        public List<CoursePeriodEntity> CoursePeriods { get; set; }

        /// <summary>
        /// 总课时个数
        /// </summary>
        public int TotalCoursePeriods
        {
            get
            {
                return this.CoursePeriods.Count;
            }
        }

        /// <summary>
        /// 总课程时常
        /// </summary>
        public TimeSpan MinutesOfCoursePeriods
        {
            get
            {
                return this.CoursePeriods.Sum<CoursePeriodEntity>(coursePeriods => coursePeriods.Minutes);
            }
        }

        /// <summary>
        /// 课程Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 课程SubTitle
        /// </summary>
        public string SubTitle { get; set; }

        /// <summary>
        /// 学习此课程人数
        /// </summary>
        public int NumberOfPeople { get; set; }

        /// <summary>
        /// 课程图标
        /// </summary>
        public Uri ImageSource { get; set; }
    }
}
