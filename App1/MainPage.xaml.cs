using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public static FileResult CapturedPhoto { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            var photo = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Take a Photo"
            });
            CapturedPhoto = photo;
        }



        async void Button_Clicked_1(object sender, EventArgs e)
        {
            var photo = await MediaPicker.CapturePhotoAsync();
            CapturedPhoto = photo;
        }
    
        async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

    }
}
