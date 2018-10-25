using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibVLCSharp.Shared;
using Xamarin.Forms;

namespace AwsomeSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //So here we go
            //It runns trough the Constructor
            //But OnAppearing() is never reached.
            Console.WriteLine("Entered ContentPage Constructor");
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            videoView.LibVLC.Log += (s, e) =>
            {
                Console.WriteLine(e);
            };

            Console.WriteLine("Entered Component Appeard!");

            base.OnAppearing();

            videoView.MediaPlayer.EncounteredError += (s, e) =>
            {
                Console.WriteLine("Error" + s + e);
            };
            videoView.MediaPlayer.Stopped += (s, e) =>
            {
                Console.WriteLine("Stopped");
            };
            videoView.MediaPlayer.Buffering += (s, e) =>
            {
                Console.WriteLine("Buffering");
            };
            videoView.MediaPlayer.Playing += (s, e) =>
            {
                Console.WriteLine("Playing");
            };

            videoView.MediaPlayer.Play(new Media(videoView.LibVLC,
                "http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4", Media.FromType.FromLocation));
        }
    }
}
