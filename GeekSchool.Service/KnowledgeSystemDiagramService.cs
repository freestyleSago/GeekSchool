using GeekSchool.Entity;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Media.Imaging;

namespace GeekSchool.Service
{
    public class KnowledgeSystemDiagramService
    {
        public IList<KnowledgeSystemDiagramEntity> GetEntityForKnowledgeSystemDiagram()
        {
            #region 初始化数据
            var knowledgeSystemDiagramEntities = new List<KnowledgeSystemDiagramEntity>()
            {
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigAndroid.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/Android.png")),
                    Title ="Android",
                    SubTitle ="月薪5K-30K，目前最火爆的职业，中高级人才缺口大",
                    Description="Android是一种基于Linux的自由及开放源代码的操作系统，主要使用于移动设备，如智能手机和平板电脑，由Google公司和开放手机联盟领导及开发。尚未有统一中文名称，中国大陆地区较多人使用“安卓”或“安致”。Android操作系统最初由Andy Rubin开发，主要支持手机。2005年8月由Google收购注资。2007年11月，Google与84家硬件制造商、软件开发商及电信营运商组建开放手机联盟共同研发改良Android系统。随后Google以Apache开源许可证的授权方式，发布了Android的源代码。第一部Android智能手机发布于2008年10月。Android逐渐扩展到平板电脑及其他领域上，如电视、数码相机、游戏机等。2011年第一季度，Android在全球的市场份额首次超过塞班系统，跃居全球第一。 2013年的第四季度，Android平台手机的全球市场份额已经达到78.1%。[1] 2013年09月24日谷歌开发的操作系统Android在迎来了5岁生日，全世界采用这款系统的设备数量已经达到10亿台。"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigArduino.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/Arduino.png")),
                    Title ="Arduino",
                    SubTitle =""
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigASP.Net.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/Asp.Net.png")),
                    Title ="Asp.Net",
                    SubTitle ="月薪5K-30K，最主流的Web框架之一，应用广泛"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigBootStrap.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BootStrap.png")),
                    Title ="BootStrap",
                    SubTitle ="简洁、直观、强悍的前段开发框架，让Web开发更迅捷、简单"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigCSharp.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/CSharp.png")),
                    Title ="C#",
                    SubTitle ="6K-20K，面向对象高级编程语言，人才需求量大"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigC.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/C.png")),
                    Title ="C",
                    SubTitle ="4K-20K，运用范围广泛，未来潜力极大"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigCocos2d-x.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/Cocos2d-x.png")),
                    Title ="Cocos2d-x",
                    SubTitle ="7K-30K，跨平台手机游戏引擎，行业前景一片大好"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigDocker.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/Docker.png")),
                    Title ="Docker",
                    SubTitle ="最火热的轻量级容器技术，最前沿的虚拟化实践"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigGUI.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/GUI.png")),
                    Title ="GUI",
                    SubTitle ="月薪6K-20K，数字时代高薪职业，有产品就有专业GUI设计师"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigJava.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/Java.png")),
                    Title ="Java",
                    SubTitle ="月薪5K-40K，拥有全球最大的开发者社群，前景广阔"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigJavaWeb.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/JavaWeb.png")),
                    Title ="Java Web",
                    SubTitle ="JavaWeb开发当前人才需求量最大的技术方向之一"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigPhp.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/php.png")),
                    Title ="PHP",
                    SubTitle ="免费、快捷、高效率、互联网市场紧缺人才"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigPython.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/Python.png")),
                    Title ="Python Web",
                    SubTitle ="互联网企业最受欢迎的编程语言之一，简洁、优雅、开发快速"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigSwift.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/swift.png")),
                    Title ="Swift",
                    SubTitle ="苹果发布的全新开发语言，简单、强大、优雅"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigUnity3D.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/Unity3D.png")),
                    Title ="Unity3D",
                    SubTitle ="从Windows、Android、IOS到Oculus Rift，跨越21个平台、目前国际最热门的3D游戏引擎。"
                },
                new KnowledgeSystemDiagramEntity()
                {
                    BigImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/BiggerImages/BigWeb.jpg")),
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/KnowledgeSystemDiagram/Web.png")),
                    Title ="Web 前段",
                    SubTitle ="高用户体验时代，用户看得见的就是前段工程师"
                },
            };

            #endregion
            return knowledgeSystemDiagramEntities;
        }
    }
}
