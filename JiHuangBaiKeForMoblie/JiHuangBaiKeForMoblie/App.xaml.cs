using JiHuangBaiKeForMobile.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JiHuangBaiKeForMobile
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();
		    MainPage = new MainPage();

//            SetMainPage();
		}
//
//		public static void SetMainPage()
//		{
//            Current.MainPage = new TabbedPage
//            {
//                Children =
//                {
//                    new NavigationPage(new ItemsPage())
//                    {
//                        Title = "Browse",
//                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
//                    },
//                    new NavigationPage(new AboutPage())
//                    {
//                        Title = "About",
//                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
//                    },
//                }
//            };
//        }

	    protected override void OnStart()
	    {
	        // Handle when your app starts
	    }

	    protected override void OnSleep()
	    {
	        // Handle when your app sleeps
	    }

	    protected override void OnResume()
	    {
	        // Handle when your app resumes
	    }
    }
}
