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
    public class TextInfo : INotifyPropertyChanged
    {
        #region Fields

        private Random random = new Random();

        private string label;

        private ObservableCollection<ImageInfo> innerList;

        #endregion

        #region Properties

        public string Label
        {
            get { return label; }
            set
            {
                label = value;
                RaisedOnPropertyChanged("Label");
            }
        }

        public ObservableCollection<ImageInfo> InnerList
        {
            get { return innerList; }
            set
            {
                innerList = value;
                RaisedOnPropertyChanged("InnerList");
            }
        }

        #endregion

        #region Constructor

        public TextInfo()
        {
            
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
