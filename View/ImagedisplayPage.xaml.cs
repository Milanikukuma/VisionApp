using PicSight.ViewModels;
using Microsoft.Maui.Controls;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Compatibility;

namespace PicSight.View
{
    public partial class ImagedisplayPage : ContentPage
    {
        private readonly ImageAnalyzer _imageAnalyzer;
        private BaseViewModel _viewModel;

        public ImagedisplayPage(BaseViewModel vm)
        {
            InitializeComponent();
            _viewModel = vm;
            BindingContext = _viewModel; // Set the BindingContext to the view model

            // Initialize the ImageAnalyzer with endpoint and key
            _imageAnalyzer = new ImageAnalyzer(
                "https://mkcomputeraanalyser.cognitiveservices.azure.com/",
                "ffa687cbca3d4a27a2b42abe58db3459");
        }

        private async void TakePhotoButton_ClickedAsync(object sender, EventArgs e)
        {
            await TakePhoto();
        }

        public async Task TakePhoto()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    // Analyze the captured photo
                    // After analyzing the captured photo
                    string analysisResult = await _imageAnalyzer.AnalyzeAsync(photo);
                    _viewModel.ImageDescription = analysisResult; // Set the analysis result to the view model property

                }
            }
        }

    }
}
