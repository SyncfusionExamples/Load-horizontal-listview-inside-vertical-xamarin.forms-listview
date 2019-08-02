using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewSample
{
    public class ListViewModel : INotifyPropertyChanged
    {

        #region Fields

        private Random random = new Random();

        private ObservableCollection<TextInfo> outerList;

        #endregion

        #region Properties

        public ObservableCollection<TextInfo> OuterList
        {
            get
                { return outerList; }
            set
                {
                    outerList = value;
                    RaisedOnPropertyChanged("OuterList");
                }
        }

        #endregion

        #region Constructor

        public ListViewModel()
        {

            OuterList = new ObservableCollection<TextInfo>();

            for (int i = 1; i < 7; i++)
            {
                var textInfo = new TextInfo()
                {
                    Label = "Team" + i,
                };

                textInfo.InnerList = new ObservableCollection<ImageInfo>();

                for (int j = 1; j < 7; j++)
                {
                    var imageInfo = new ImageInfo()
                    {
                        Image = ImageSource.FromResource("HorizontalInVerticalListview.Images.Image" + random.Next(0, 28) + ".png", typeof(MainPage)),
                    };

                    textInfo.InnerList.Add(imageInfo);
                }
                OuterList.Add(textInfo);
            }
        }

        #endregion

        #region Interface Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
}
