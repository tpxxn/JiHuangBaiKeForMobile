using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JiHuangBaiKeForMobile.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JiHuangBaiKeForMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        // 向 MainPage 传递控件
        public ListView primaryListView { get { return PrimaryListView; } }
        public ListView secondaryListView { get { return SecondaryListView; } }

        public MasterPage()
        {
            InitializeComponent();

            // 设置不同平台的字体路径
            string fontFamily;
            switch (Device.RuntimePlatform)
            {
                case "Android":
                    fontFamily = "JiHuangBaiKeFont.ttf#JiHuangBaiKeIco";
                    break;

                case "iOS":
                    fontFamily = "Segoe MDL2 Assets";
                    break;

                case "Windows":
                    fontFamily = "/Assets/segmdl2.ttf#Segoe MDL2 Assets";
                    break;

                case "WinPhone":
                    fontFamily = "/Assets/segmdl2.ttf#Segoe MDL2 Assets";
                    break;

                default:
                    fontFamily = "JiHuangBaiKeFont.ttf#JiHuangBaiKeIcon";
                    break;
            }

            // 列表项
            var primaryItems = new List<MasterPageItem>() {
                new MasterPageItem
                {
                    Title = "人物",
                    FontFamily = fontFamily,
                    Icon = " \x4E0C",
                    Color = Color.DeepSkyBlue,
                    Selected = true,
                    DestPage = typeof(Page1)
                },
                new MasterPageItem
                {
                    Title = "食物",
                    FontFamily = fontFamily,
                    Icon = " \x4E01;",
                    Color = Color.Black,
                    Selected = false,
                    DestPage = typeof(Page2)
                },
                new MasterPageItem
                {
                    Title = "模拟",
                    FontFamily = fontFamily,
                    Icon = " \x4E02",
                    Color = Color.Black,
                    Selected = false,
                    DestPage = typeof(Page2)
                },
                new MasterPageItem
                {
                    Title = "科技",
                    FontFamily = fontFamily,
                    Icon = " \x4E03",
                    Color = Color.Black,
                    Selected = false,
                    DestPage = typeof(Page2)
                },
                new MasterPageItem
                {
                    Title = "生物",
                    FontFamily = fontFamily,
                    Icon = " \x4E04",
                    Color = Color.Black,
                    Selected = false,
                    DestPage = typeof(Page2)
                },
                new MasterPageItem
                {
                    Title = "自然",
                    FontFamily = fontFamily,
                    Icon = " \x4E05",
                    Color = Color.Black,
                    Selected = false,
                    DestPage = typeof(Page2)
                },
                new MasterPageItem
                {
                    Title = "物品",
                    FontFamily = fontFamily,
                    Icon = " \x4E06",
                    Color = Color.Black,
                    Selected = false,
                    DestPage = typeof(Page2)
                }
            };

            var secondaryItems = new List<MasterPageItem>() {
                new MasterPageItem
                {
                    Title = "设置",
                    FontFamily = fontFamily,
                    Icon = " \x4E0A",
                    Color = Color.Black,
                    Selected = false,
                    DestPage = typeof(SettingPage)
                },
                new MasterPageItem
                {
                    Title = "关于",
                    FontFamily = fontFamily,
                    Icon = " \x4E0B",
                    Color = Color.Black,
                    Selected = false,
                    DestPage = typeof(AboutPage)
                }
            };

            // ListView 数据绑定
            PrimaryListView.ItemsSource = primaryItems;
            SecondaryListView.ItemsSource = secondaryItems;

            // 设置二级菜单高度
            SecondaryListView.HeightRequest = 48 * secondaryItems.Count;
        }
    }
}