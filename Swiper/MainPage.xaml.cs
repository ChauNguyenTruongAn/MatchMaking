using Swiper.Controls;
using System.Diagnostics;

namespace Swiper
{
    public partial class MainPage : ContentPage
    {
        private int _lineCount = 0;
        private int _denyCount = 0;

        public MainPage()
        {
            InitializeComponent();
            try
            {
                AddInitialPhotos();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Bug is: " + ex.ToString() +"ajhffafsd");
            }
        }
        
        private void AddInitialPhotos()
        {
            for(int i= 0; i < 10; i++)
            {
                InsertPhoto();
            }
        }

        private void InsertPhoto()
        {
            var photo = new SwiperControl();
            photo.OnLike += Hande_OnLike;
            photo.OnDeny += Handle_OnDeny;
            this.MainGrid.Children.Insert(0,photo);
        }

        private void UpdateGui()
        {
            likeLabel.Text = _lineCount.ToString();
            denyLable.Text = _denyCount.ToString();
        }

        private void Hande_OnLike(object sender, EventArgs e)
        {
            _lineCount++;
            InsertPhoto();
            UpdateGui();
        }
        
        private void Handle_OnDeny(object sender, EventArgs e)
        {
            _denyCount++;
            InsertPhoto();
            UpdateGui();
        }
    }

}
