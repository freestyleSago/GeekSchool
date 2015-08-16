using GeekSchool.Entity;
using System;
using System.Collections.Generic;

namespace GeekSchool.Service
{
    public class CourseService
    {
        public IList<CourseEntity> GetCoursesByCourseCategory(string categroy)
        {
            #region 这里我生成Android的课程信息
            //TODO: 这里以后需要动态的查询课程数据信息

            var courses = new List<CourseEntity>()
            {
                #region Java基础课程
                #region 1
                new CourseEntity()
                {
                    Title ="变量与数据类型",
                    SubTitle="Java编程基础知识入门:变量与数据类型",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "Java基础",
                        GroupIndex = 1,
                        Description ="Java是Android开发的主要语言，所以掌握Java语言基础非常重要，本阶段讲解了Java的基本语法，要深入掌握Java语言，可以通过Java学习路径图学习。"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Index =1,
                            Title ="数据类型初阶",
                            Description ="本课学习Java中基本的变量类型和变量在堆栈中的分布特点。",
                            Minutes = TimeSpan.FromMinutes(4),
                            Source = new Uri("ms-appx:///Assets/Medias/UK_Gateshead_ShutterstockRF_6899947_1080_HD_ZH-CN.mp4")
                        },
                        new CoursePeriodEntity()
                        {
                            Index =2,
                            Title ="变量的定义和变量使用的原因",
                            Description ="本课学习变量的定义和变量使用的原因。",
                            Minutes = TimeSpan.FromMinutes(6),
                            Source = new Uri("ms-appx:///Assets/Medias/AntelopeCanyon_shutterstockRF_4152388_1080_HD_ZH-CN.mp4")
                        },
                        new CoursePeriodEntity()
                        {
                            Index =3,
                            Title ="变量的命名、定义和初始化",
                            Description ="本课时学习变量命名规范、语法和初始化赋值。。",
                            Minutes = TimeSpan.FromMinutes(5)
                        },
                        new CoursePeriodEntity()
                        {
                            Index =4,
                            Title ="用变量简化计算 ",
                            Description ="使用变量简化计算和代码编写复杂度",
                            Minutes = TimeSpan.FromMinutes(5)
                        },
                        new CoursePeriodEntity()
                        {
                            Index =5,
                            Title ="用变量保存多种类型的数据  ",
                            Description ="使用不同类型的变量保存不同类型数据",
                            Minutes = TimeSpan.FromMinutes(5)
                        }
                    }
                }
                #endregion
                #region 2
                ,new CourseEntity()
                {
                    Title ="Switch语句详解",
                    SubTitle="Java语言Switch语句详解",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "Java基础",
                        GroupIndex = 2,
                        Description ="Java是Android开发的主要语言，所以掌握Java语言基础非常重要，本阶段讲解了Java的基本语法，要深入掌握Java语言，可以通过Java学习路径图学习。"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="Java Switch语句概述",
                            Description ="Java Switch语句概述基础视频教程,主讲switch语句,switch语句用法,java switch case语句,java switch语句,switch语句例子,switch用法,了解switch语句概念及使用场合。",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="Java Switch语句应用案例1 判断int类型的数据",
                            Description ="Java Switch语句应用案例1 判断int类型的数据视频教程,通过Switch语句应用案例,讲解switch用法,switch语句用法,java switch case语句,java switch语句,switch语句例子,switch语句,学习从键盘接受输入的整数并进行判断。",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="Java Switch语句应用案例2 switch语句的“贯穿”现象 ",
                            Description ="Java Switch语句应用案例2 switch语句的“贯穿”现象视频教程,以switch语句的“贯穿”现象为实例,讲解switch语句例子,switch用法,switch语句用法,java switch case语句,java switch语句,switch语句的用法",
                            Minutes = TimeSpan.FromMinutes(5)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="Java Switch语句应用案例3 键盘输入字符串并进行判断",
                            Description ="Java Switch语句应用案例3 键盘输入字符串并进行判断视频教程,通过switch实例讲解,switch语句例子,switch用法,switch语句用法,java switch case语句,掌握键盘输入字符串并进行判断的方法",
                            Minutes = TimeSpan.FromMinutes(5)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="Java Switch语句应用案例4 显示指定月的天数",
                            Description ="Java Switch语句应用案例4 显示指定月的天数视频教程,以switch实例讲解,通过代码实现显示指定月份的天数,掌握java switch case语句,java switch语句,switch语句用法",
                            Minutes = TimeSpan.FromMinutes(5)
                        }
                    }
                }
                #endregion
                #region 3
                ,new CourseEntity()
                {
                    Title ="判断与关系运算",
                    SubTitle="Java判断与关系运算",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "Java基础",
                        GroupIndex = 3,
                        Description ="Java是Android开发的主要语言，所以掌握Java语言基础非常重要，本阶段讲解了Java的基本语法，要深入掌握Java语言，可以通过Java学习路径图学习。"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="Java关系运算的种类",
                            Description ="Java关系运算的种类视频教程,主讲java 运算,java中运算符,等于运算符,java 不等于,java不等于符号,java大于号,java大于等Java关系运算种类的应用",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="Java实例讲解关系运算中判断语句和流程控制作用",
                            Description ="Java实例讲解关系运算中判断语句和流程控制作用视频教程,主讲Java关系运算中java判断语句,java 判断语句,java判断语句if,java中if语句,java中的判断语句,流程控制,java流程控制,java流程控制语句中的作用及用法",
                            Minutes = TimeSpan.FromMinutes(6)
                        }
                    }
                }
                #endregion
                #endregion
                #region 环境搭建
                #region 1
                ,new CourseEntity()
                {
                    Title ="Android 集成开发环境搭建",
                    SubTitle="",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "环境搭建",
                        GroupIndex = 1,
                        Description ="环境搭建是Android开发最基础技能，必须完全掌握"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="在 Mac 平台搭建 Android 集成开发环境",
                            Description ="课讲解如何在 Mac 平台搭建 Android Studio 集成开发环境，内容包括下载 Android Studio、配置 Android Studio 以及创建一个 HelloWorld 示例。",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="在 Windows 平台搭建 Android 集成开发环境",
                            Description ="本课讲解如何在 Windows平台搭建 Android Studio 集成开发环境，内容包括下载 Android Studio、配置 Android Studio 以及创建一个 HelloWorld 示例。",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="在 Linux 平台搭建 Android 集成开发环境 ",
                            Description ="本课讲解如何在 Linux 平台搭建 Android Studio 集成开发环境，内容包括下载 Android Studio、配置 Android Studio 以及创建一个 HelloWorld 示例。",
                            Minutes = TimeSpan.FromMinutes(5)
                        }
                    }
                }
                #endregion
                #region 2
                ,new CourseEntity()
                {
                    Title ="离线搭建 Android 集成开发环境",
                    SubTitle="",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "环境搭建",
                        GroupIndex = 2,
                        Description ="环境搭建是Android开发最基础技能，必须完全掌握"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="在 Windows 平台离线搭建 Android 集成开发环境 ",
                            Description ="本课介绍如何在 Windows 平台离线搭建 Android 集成开发环境，内容包括如何安装 JDK、如何安装 IDEA、如何配置离线 Android SDK、如何创建并运行一个 Android 项目。",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="在 Mac 平台离线搭建 Android 集成开发环境 ",
                            Description ="本课介绍如何在 Mac 平台离线搭建 Android 集成开发环境，内容包括如何安装 JDK、如何安装 IDEA、如何配置离线 Android SDK、如何创建并运行一个 Android 项目",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="在 Linux 平台离线搭建 Android 集成开发环境 ",
                            Description ="本课介绍如何在 Linux 平台离线搭建 Android 集成开发环境，内容包括如何安装 JDK、如何安装 IDEA、如何配置离线 Android SDK、如何创建并运行一个 Android 项目",
                            Minutes = TimeSpan.FromMinutes(5)
                        }
                    }
                }
                #endregion
                #endregion
                #region Android基础知识
                #region 1
                ,new CourseEntity()
                {
                    Title ="认识 Android 中的 Activity 组件",
                    SubTitle="本课将对 Intent 进行详细的讲解，内容包括隐式 Intent，显式 Intent，IntentFilter 的配置，从浏览器启动应",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "Android基础知识",
                        GroupIndex = 1,
                        Description ="本阶段包含Android 理论知识，是 Android 应用开发的根基<br /> 要想以后有更长足的提高，这部分的知识需要耐心学习实践,在这里你将渐渐熟悉 Android 的方方面面~"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="Activity 是什么 ",
                            Description ="本课时讲解什么是 Activity，以及对界面进行简单的修改。",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="Activity绑定自定义视图",
                            Description ="本课时讲解如何创建视图资源文件，并且给 Activity 绑定自定义的视图方便与用户进行交互。",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="启动另一个 Activity ",
                            Description ="本课讲解如何创建一个 Activity，如何在 Manifest 文件中对Activity进行配置，以及如何使用 startActivity 函数启动一个 Activity。",
                            Minutes = TimeSpan.FromMinutes(5)
                        }
                    }
                }
                #endregion
                #region 2
                ,new CourseEntity()
                {
                    Title ="Activity 生命周期",
                    SubTitle="本课深入讲解 Activity 的生命周期，内容包括如何查看帮助文档、Activity 生命周期详解、在 Activity 跳转过程",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "Android基础知识",
                        GroupIndex = 2,
                        Description ="本阶段包含Android 理论知识，是 Android 应用开发的根基<br /> 要想以后有更长足的提高，这部分的知识需要耐心学习实践,在这里你将渐渐熟悉 Android 的方方面面~"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="学会查看帮助文档 ",
                            Description ="本课时讲解如何查看 Google 官方所提供的 Android 开发参考文档，以参考文档做为指导进行开发工作。",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="认识 Activity 的生命周期",
                            Description ="本课时详细讲解 Activity 生命周期相关知识，以及在各个生命阶段都发生哪些事情。",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="在 Activity 跳转过程中的生命周期",
                            Description ="本课讲解在 Activity 跳转过程中所发生的生命周期依次有哪些，对此问题理解深入有助于开发出更好的程序。",
                            Minutes = TimeSpan.FromMinutes(5)
                        }
                    }
                }
                #endregion
                #region 3
                ,new CourseEntity()
                {
                    Title ="在 Activity 之间传递参数",
                    SubTitle="本课讲解在 Activity 之间传递参数，内容包括传递简单数据、传递复杂数据、传递值对象、接受被启动的 ",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "Android基础知识",
                        GroupIndex = 3,
                        Description ="本阶段包含Android 理论知识，是 Android 应用开发的根基<br /> 要想以后有更长足的提高，这部分的知识需要耐心学习实践,在这里你将渐渐熟悉 Android 的方方面面~"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="传递简单数据 ",
                            Description ="本课讲解在 Activity 跳转时如何传递简单数据。",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="传递数据 包Bundle ",
                            Description ="J本课讲解在 Activity 跳转时如何传递复杂的数据。",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="传递值对象 ",
                            Description ="本课讲解在 Activity 跳转时如何传递自定义的值对象。",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="获取 Activity 的返回参数 ",
                            Description ="本课讲解如何获取被启动的Activity传回的数据。",
                            Minutes = TimeSpan.FromMinutes(6)
                        }
                    }
                }
                #endregion
                #endregion
                #region 用户界面优化
                #region 1
                ,new CourseEntity()
                {
                    Title ="Android Fragment",
                    SubTitle="本课讲解在 Android 中Fragment的用法，内容包括使用Fragment、Fragment的生命周期、带侧栏的",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "用户界面优化",
                        GroupIndex = 1,
                        Description ="优化用户界面，可以让应用对用户更加友好，并增强用户体验"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="使用 Fragment ",
                            Description ="本课讲解如何创建和使用 Fragment。",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="Fragment 的生命周期",
                            Description ="本课讲解 Fragment 的生命周期以及相关的实际应用。",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="带侧边栏的 Activity",
                            Description ="本课讲解如何创建一个带侧边栏的 Activity 以及如何使用它。",
                            Minutes = TimeSpan.FromMinutes(5)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="Tabbed Activity ",
                            Description ="本课讲解如何创建一个 Tabbed Activity 并使用它。",
                            Minutes = TimeSpan.FromMinutes(5)
                        }
                    }
                }
                #endregion
                #region 2
                ,new CourseEntity()
                {
                    Title ="Android 基本布局",
                    SubTitle="本课讲解在 Android 中常用的几种基本布局的理解与使用细节，内容包括 LinearLayout (线性布局)、",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "用户界面优化",
                        GroupIndex = 2,
                        Description ="优化用户界面，可以让应用对用户更加友好，并增强用户体验"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="FrameLayout ",
                            Description ="本课讲解 FrameLayout 的意义并以实例演示如何使用",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="LinearLayout",
                            Description ="本课介绍线性布局的定义与使用，并介绍在线性布局中weight属性的意义与使用方式",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="用代码控制子对象",
                            Description ="本课介绍如何使用代码控制布局子对象的添加与删除",
                            Minutes = TimeSpan.FromMinutes(5)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="RelativeLayout",
                            Description ="本课介绍如何定义与使用相对布局",
                            Minutes = TimeSpan.FromMinutes(5)
                        }
                    }
                }
                #endregion
                #region 3
                ,new CourseEntity()
                {
                    Title ="Android RecyclerView",
                    SubTitle="本课讲解 Android RecyclerView 的用法，内容包括使用 RecyclerView、使用资源文件自定义列表项、",
                    CourseGroupEntity = new CourseGroupEntity()
                    {
                        GroupName = "用户界面优化",
                        GroupIndex = 3,
                        Description ="优化用户界面，可以让应用对用户更加友好，并增强用户体验"
                    },
                    CoursePeriods = new List<CoursePeriodEntity>()
                    {
                        new CoursePeriodEntity()
                        {
                            Title ="使用RecyclerView",
                            Description ="本课讲解如何创建RecyclerView、如何为RecyclerView适配数据源",
                            Minutes = TimeSpan.FromMinutes(4)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="使用资源文件自定义列表项",
                            Description ="本课讲解如何创建列表项资源以及如何解析列表项资源并应用在列表中",
                            Minutes = TimeSpan.FromMinutes(6)
                        },
                        new CoursePeriodEntity()
                        {
                            Title ="RecyclerView的布局样式",
                            Description ="本课讲解如何为列表RecyclerView适配样式，并演示适配样式后的结果",
                            Minutes = TimeSpan.FromMinutes(6)
                        }
                    }
                }
                #endregion
                #endregion
            };

            return courses;

            #endregion
        }
    }
}
