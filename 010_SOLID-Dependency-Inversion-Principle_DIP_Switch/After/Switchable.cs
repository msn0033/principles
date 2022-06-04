using SOLID_Dependency_Inversion_Principle_DIP_Switch.After;

namespace _SOLID_Dependency_Inversion_Principle_DIP_Switch.After
{
    public class Switchable:ISwitchable
    {
        public bool On { get; set; }=false;
        public bool TurnOff() => false;
        public bool TurnOn() => true;
    }
}