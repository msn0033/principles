// See https://aka.ms/new-console-template for more information


using _SOLID_Dependency_Inversion_Principle_DIP_Switch.After;
using SOLID_Dependency_Inversion_Principle_DIP_Switch.After;



Switchable obj1=new Switchable();//On turnOf TurnOn      
ISwitch s1=new ElectricSwitch(obj1);

var s=s1.Press()?"TurnOF":"TurnOn";
System.Console.WriteLine($"\nElectricSwitch : {s}\n");

obj1.On=true;
ISwitch s2=new VoicePowerSwitch(obj1);
var v=s2.Press()?"TurnOF":"TurnOn";
System.Console.WriteLine($"VoicePowerSwitch : {v}\n\n");