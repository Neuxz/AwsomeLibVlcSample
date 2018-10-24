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
            System.Diagnostics.Debugger.Break();
            InitializeComponent();


        }
        protected override void OnAppearing()
        {
            System.Diagnostics.Debugger.Break();

            base.OnAppearing();

            videoView.MediaPlayer.EncounteredError += (s, e) =>
            {
                System.Diagnostics.Debugger.Break();
            };
            videoView.MediaPlayer.Stopped += (s, e) =>
            {
                System.Diagnostics.Debugger.Break();
            };
            videoView.MediaPlayer.Buffering += (s, e) =>
            {
                System.Diagnostics.Debugger.Break();
            };
            videoView.MediaPlayer.Playing += (s, e) =>
            {
                System.Diagnostics.Debugger.Break();
            };

            videoView.MediaPlayer.Play(new Media(videoView.LibVLC,
                "http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4", Media.FromType.FromLocation));
        }
    }
}
