using _SOLID_Dependency_Inversion_Principle_DIP_Switch.After;
namespace SOLID_Dependency_Inversion_Principle_DIP_Switch.After
{
    public class ElectricSwitch : ISwitch
    {
        public ISwitchable _Switchable { get; }
        public ElectricSwitch(ISwitchable switchable)
        {
            _Switchable = switchable;
            _Switchable.On = false;
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