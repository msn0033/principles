using _SOLID_Dependency_Inversion_Principle_DIP_Switch.After;

namespace SOLID_Dependency_Inversion_Principle_DIP_Switch.After
{
    public class VoicePowerSwitch : ISwitch
    {
        public ISwitchable _Switchable { get; }
        public VoicePowerSwitch(ISwitchable switchable)
        {
            this._Switchable = switchable;
        }
        public bool Press()
        {
            if (_Switchable.On)
                _Switchable.On = _Switchable.TurnOff();
            else
                _Switchable.On = _Switchable.TurnOn();

            return _Switchable.On;
        }
    }
}