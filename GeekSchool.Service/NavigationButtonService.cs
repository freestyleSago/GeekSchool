using GeekSchool.Entity;
using Sago.Framework.Universal.Library.Common.Utility;
using System.Collections.Generic;

namespace GeekSchool.Service
{
    public class NavigationButtonService
    {
        private ResourceUtility _ResourceUtility = new ResourceUtility();

        public IList<NavigationButtonEntity> GetNavigationButtonsForMainPage()
        {
            var navigationButtonEntities = new List<NavigationButtonEntity>()
            {
                new NavigationButtonEntity()
                {
                    Tag = "KnowledgeSystemDiagram",
                    IconResource = this._ResourceUtility.GetString("MainPage_TextBlock_KnowledgeSystemDiagram_Icon"),
                    LabelResource = this._ResourceUtility.GetString("MainPage_TextBlock_KnowledgeSystemDiagram_Label")
                },
                new NavigationButtonEntity()
                {
                    Tag = "HotNews",
                    IconResource = this._ResourceUtility.GetString("MainPage_TextBlock_HotNews_Icon"),
                    LabelResource = this._ResourceUtility.GetString("MainPage_TextBlock_HotNews_Label")
                },
                new NavigationButtonEntity()
                {
                    Tag = "Courses",
                    IconResource = this._ResourceUtility.GetString("MainPage_TextBlock_Courses_Icon"),
                    LabelResource =this._ResourceUtility.GetString("MainPage_TextBlock_Courses_Label")
                },
                new NavigationButtonEntity()
                {
                    Tag = "PersonalCenter",
                    IconResource = this._ResourceUtility.GetString("MainPage_TextBlock_PersonalCenter_Icon"),
                    LabelResource = this._ResourceUtility.GetString("MainPage_TextBlock_PersonalCenter_Label")
                },
                new NavigationButtonEntity()
                {
                    Tag = "Download",
                    IconResource = this._ResourceUtility.GetString("MainPage_TextBlock_Download_Icon"),
                    LabelResource = this._ResourceUtility.GetString("MainPage_TextBlock_Download_Label")
                }
            };

            return navigationButtonEntities;
        }
    }
}
