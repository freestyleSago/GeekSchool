using System.Collections.Generic;

namespace GeekSchool.Entity
{
    public class PersonalCenterEntity
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        public UserEntity User { get; set; }

        /// <summary>
        /// 学习记录
        /// </summary>
        public IList<CourseEntity> LearningRecordEntities { get; set; }

        /// <summary>
        /// 收藏课程
        /// </summary>
        public List<CourseEntity> FavoritesCourseEntities { get; set; }
    }
}
