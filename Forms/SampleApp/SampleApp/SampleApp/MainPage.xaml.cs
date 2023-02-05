using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SizeChanged += MainPage_SizeChanged;
        }

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            Player.Aspect = Aspect.AspectFill;
            Player.Source = "ms-appx:///video.mp4";
            Player.Volume = 0;
            Player.IsLooping = true;
            Player.Play();
        }
    }
}
