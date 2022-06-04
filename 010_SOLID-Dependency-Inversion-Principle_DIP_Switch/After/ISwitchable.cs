namespace SOLID_Dependency_Inversion_Principle_DIP_Switch.After
{
    public interface ISwitchable
    {
        public bool On { get; set; }
        public bool TurnOff();
        public bool TurnOn();
    }
}