using Sago.Framework.Universal.Library.Common.Utility;
using System;

namespace GeekSchool.Entity
{
    public class UserEntity
    {
        private ResourceUtility _ResourceUtility = new ResourceUtility();

        /// <summary>
        /// 头像
        /// </summary>
        public Uri HeadPortrait { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 个性签名
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// 是否是VIP
        /// </summary>
        public bool IsVIP { get; set; }

        /// <summary>
        /// VIP状态
        /// </summary>
        public int VIPStatus { get; set; }

        /// <summary>
        /// VIP状态对应的文字描述
        /// </summary>
        public string VIPStatusString
        {
            get
            {
                switch (this.VIPStatus)
                {
                    case 1:
                        return string.Empty;
                    case 2:
                        return this._ResourceUtility.GetString("PersonalCenterEntity_UserEntity_VIPStatusString_Expire");
                    default:
                        return this._ResourceUtility.GetString("PersonalCenterEntity_UserEntity_VIPStatusString_Expire");
                }
            }
        }
    }
}
