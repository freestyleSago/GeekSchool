﻿using GeekSchool.Entity;
using Sago.Framework.Universal.Library.Common.Utility;
using System;
using Windows.Storage;

namespace GeekSchool.Service
{
    public class LoginService
    {
        private static LoginService _LoginService = new LoginService();

        private const string USERKEY = "USER";

        public static event Action<UserEntity> LoginIn;

        public static event Action LoginOut;

        /// <summary>
        /// 用户是否登录
        /// </summary>
        public static bool IsLogin
        {
            get
            {
                return _LoginService.GetUserSession() == default(UserEntity) ? false : true;
            }
        }

        public static void CheckLoginStatus()
        {
            var userEntity = _LoginService.GetUserSession();
            if (userEntity != default(UserEntity))
            {
                //调用登录状态委托
                if (LoginService.LoginIn != default(Action<UserEntity>))
                {
                    LoginService.LoginIn(userEntity);
                }
            }
            else
            {
                if (LoginService.LoginOut != default(Action))
                {
                    LoginService.LoginOut();
                }
            }
        }

        public UserEntity Login(string account, string password)
        {
            UserEntity user = default(UserEntity);

            //TODO：这里的逻辑要重写
            if (account.Trim().ToUpper() == "SAGO" && password.Trim().ToUpper() == "123")
            {
                user = new UserEntity()
                {
                    HeadPortrait = new Uri("ms-appx:///Assets/Images/Sago.png"),
                    NickName = "Sago",
                    Signature = "中学为体，西学为用。",
                    IsVIP = true,
                    VIPStatus = 2
                };
            }

            return user;
        }

        public void SaveUserSession(UserEntity user)
        {
            var serializationUtility = new SerializationUtility();

            var userJson = serializationUtility.Serialize<UserEntity>(user);

            //如果已经存在用户信息，那么就更新
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey(LoginService.USERKEY))
            {
                ApplicationData.Current.LocalSettings.Values[LoginService.USERKEY] = userJson;
            }
            else
            {
                ApplicationData.Current.LocalSettings.Values.Add(LoginService.USERKEY, userJson);
            }

            //调用登录状态委托
            if (LoginService.LoginIn != default(Action<UserEntity>))
            {
                LoginService.LoginIn(user);
            }
        }

        public void ClearUserSession()
        {
            //如果已经存在用户信息，那么就移除
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey(LoginService.USERKEY))
            {
                ApplicationData.Current.LocalSettings.Values.Remove(LoginService.USERKEY);

                if (LoginService.LoginOut != default(Action))
                {
                    LoginService.LoginOut();
                }
            }
        }

        public UserEntity GetUserSession()
        {
            var serializationUtility = new SerializationUtility();

            object userJson = string.Empty;

            ApplicationData.Current.LocalSettings.Values.TryGetValue(LoginService.USERKEY, out userJson);

            return serializationUtility.DeSerialize<UserEntity>(userJson == default(object) ? string.Empty : userJson.ToString());
        }
    }
}
