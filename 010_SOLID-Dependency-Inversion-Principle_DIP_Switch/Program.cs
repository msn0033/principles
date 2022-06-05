// See https://aka.ms/new-console-template for more information


using _SOLID_Dependency_Inversion_Principle_DIP_Switch.After;
using SOLID_Dependency_Inversion_Principle_DIP_Switch.After;



Bulb bulb=new Bulb();//On turnOf TurnOn      
ISwitch s1=new ElectricSwitch(bulb);

var s=s1.Press()?"TurnOF":"TurnOn";
System.Console.WriteLine($"\nElectricSwitch : {s}\n");

bulb.On=true;
ISwitch s2=new VoicePowerSwitch(bulb);
var v=s2.Press()?"TurnOF":"TurnOn";
System.Console.WriteLine($"VoicePowerSwitch : {v}\n\n");