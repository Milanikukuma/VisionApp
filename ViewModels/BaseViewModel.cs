using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PicSight.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private string _imageDescription;

        public string ImageDescription
        {
            get { return _imageDescription; }
            set
            {
                if (_imageDescription != value)
                {
                    _imageDescription = value;
                    OnPropertyChanged(); // Notify UI about the change
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
