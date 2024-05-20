namespace mobilewakala
{

    public partial class MainPage : ContentPage
    {
        // private LoginModel? loggedInUser;
        //private CustomerLoginModel? loggedInCustomer;

        public MainPage()
        {
            InitializeComponent();
            // this.Loaded += MainPage_Loaded;

         }
       

        //        private void MainPage_Loaded(object sender, EventArgs e)
        //        {
        //#if ANDROID
        //        if (!Platforms.Android.AndroidServiceManager.IsRunning)
        //        {
        //            Platforms.Android.AndroidServiceManager.StartMyService();
        //         }
        //        else{
        //         }
        //#endif
        //        }


         
        private void MtejaLog(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Customer.CustomerLogin());

            //Navigation.PushAsync(new NavigationPage(new Customer.CustomerLogin()));
        }
        private void WakalaLog(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Agent.AgentLogin());
        }
    }

}
