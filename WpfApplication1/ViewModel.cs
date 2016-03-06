using Bizmonger.Patterns;

namespace MotoLens
{
    public partial class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            Clarity = new DelegateCommand(_ => ToggleVision());
        }

        float _mphOpacity = 1;
        public float MphOpacity
        {
            get { return _mphOpacity; }
            set
            {
                if (_mphOpacity != value)
                {
                    _mphOpacity = value;
                    OnPropertyChanged();
                }

            }
        }

        float _gaugeOpacity = 1f;
        public float GaugeOpacity
        {
            get { return _gaugeOpacity; }
            set
            {
                if (_gaugeOpacity != value)
                {
                    _gaugeOpacity = value;
                    OnPropertyChanged();
                }

            }
        }
    }
}