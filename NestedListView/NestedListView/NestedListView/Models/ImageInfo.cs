using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewSample
{
    public class ImageInfo : INotifyPropertyChanged
    {
        #region Fields

        private ImageSource image;

        #endregion

        #region Properties

        public ImageSource Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged("Image1");
            }
        }

        #endregion

        #region Constructor

        public ImageInfo()
        {

        }

        #endregion

        #region Interface Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
}
