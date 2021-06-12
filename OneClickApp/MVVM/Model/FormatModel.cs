using System.Windows;
using System.Windows.Media;
using OneClickApp.ViewModel;

namespace OneClickApp.Model
{
    /// <summary>
    /// Model for document format properties.
    /// </summary>
    public class FormatModel : ObservarObject
    {
        private FontStyle _style;
        public FontStyle Style
        {
            get { return _style; }
            set
            {
                _style = value;
                OnPropertyChanged();
            }
        }

        private FontWeight _weight;
        public FontWeight Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged();
            }
        }

        private FontFamily _family;
        public FontFamily Family
        {
            get { return _family; }
            set
            {
                _family = value;
                OnPropertyChanged();
            }
        }

        private TextWrapping _wrap;
        public TextWrapping Wrap
        {
            get { return _wrap; }
            set
            {
                _wrap = value;
                OnPropertyChanged();
            }
        }

        private bool _isWrapped;
        public bool isWrapped
        {
            get { return _isWrapped; }
            set
            {
                _isWrapped = value;
                OnPropertyChanged();
            }
        }

        private double _size;
        public double Size
        {
            get { return _size; }
            set
            {
                _size = value;
                OnPropertyChanged();
            }
        }
    }
}
