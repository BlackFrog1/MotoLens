namespace MotoLens
{
    public partial class ViewModel : ViewModelBase
    {
        void ToggleVision()
        {
            _shakeToggle = !_shakeToggle;

            if (_shakeToggle)
                MphOpacity = GaugeOpacity = FULL_CLARITY;

            else
                MphOpacity = GaugeOpacity = LOW_CLARITY;
        }
    }
}