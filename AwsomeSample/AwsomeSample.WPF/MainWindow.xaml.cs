        using LibVLCSharp.Forms.Platforms.WPF;
        using LibVLCSharp.Forms.Shared;
        using System.Collections.Generic;
        using System.Reflection;
        using Xamarin.Forms;
        using Xamarin.Forms.Platform.WPF;

        namespace AwsomeSample.WPF
        {
            /// <summary>
            /// Interaction logic for MainWindow.xaml
            /// </summary>
            public partial class MainWindow : FormsApplicationPage
            {
                public MainWindow()
                {
                    InitializeComponent();
                    InitDependencies();
                    Forms.Init();
                    LoadApplication(new AwsomeSample.App());
                }
                void InitDependencies()
                {
                    var init = new List<Assembly>
                    {
                        typeof(VideoView).Assembly,
                        typeof(VideoViewRenderer).Assembly
                    };
                }
            }
        }
