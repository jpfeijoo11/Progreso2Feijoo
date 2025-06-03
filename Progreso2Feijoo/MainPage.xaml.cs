namespace Progreso2Feijoo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BotonChistesLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChistesLayout());
        }

        private void BotonAboutLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutLayout());
        }
    }

}
