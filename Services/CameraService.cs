using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class CameraService
    {
        public async Task<FileResult> TakePhoto()
        {
            if (MediaPicker.IsCaptureSupported)
            {
                return await MediaPicker.CapturePhotoAsync();
            }

            return null;
        }
    }
