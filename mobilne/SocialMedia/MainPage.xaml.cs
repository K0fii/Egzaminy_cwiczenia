namespace SocialMedia
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        bool zaznaczenie = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void zaznaczZdjecie(object sender, TappedEventArgs e)
        {
            if(!zaznaczenie)
            {
                zaznaczenie=true;
                ImageFrame.BackgroundColor = Colors.MediumPurple;
            }
            else
            {
                zaznaczenie=false;
                ImageFrame.BackgroundColor= Colors.White;
            }
        }

        private void polubZdjecie(object sender, TappedEventArgs e)
        {
            count++;
            LikesLabel.Text = count.ToString();
        }

        private void pokazUkryjOpis(object sender, TappedEventArgs e)
        {
            DescriptionLabel.IsVisible = !DescriptionLabel.IsVisible;
        }
    }

}
