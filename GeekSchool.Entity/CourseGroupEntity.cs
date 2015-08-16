using System;
using System.Collections.Generic;
using System.Linq;
using Sago.Framework.Universal.Library.Common.ExtensionMethods;

namespace GeekSchool.Entity
{
    /// <summary>
    /// 课程分组
    /// </summary>
    public class CourseGroupEntity
    {
        public CourseGroupEntity()
        {
            this.Courses = new List<CourseEntity>();
        }

        public string GroupName { get; set; }

        public int GroupIndex { get; set; }

        public string Description { get; set; }

        public IList<CourseEntity> Courses { get; set; }

        public TimeSpan MinutesOfCourses
        {
            get
            {
                return this.Courses.Sum<CourseEntity>(courseEntity => courseEntity.MinutesOfCoursePeriods);
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return this.Courses.Sum<CourseEntity>(courseEntity => courseEntity.NumberOfPeople);
            }
        }
    }
}
