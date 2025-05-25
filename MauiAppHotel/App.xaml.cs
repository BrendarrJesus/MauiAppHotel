namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());

        }



        protected override Window CreateWindow(IActivationState? activationstate)
        {
            var window = base.CreateWindow(activationstate);
            window.Width = 400;
            window.Height = 700;
            return window;
        }

    }
}
