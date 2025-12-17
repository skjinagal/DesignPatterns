// See https://aka.ms/new-console-template for more information
using System.Data;
using Command_Pattern;
using Command_Pattern.Appliances;
using Command_Pattern.Commands;
Console.WriteLine("Hello, World!");

RemoteControlSystem remote = new RemoteControlSystem();
Lights light = new Lights();
GarageDoor garageDoor = new GarageDoor();
Fan fan = new Fan();
ICommand lightOn = new LightsOnCommand(light);
ICommand lightOff = new LightsOffCommand(light);
ICommand fanOn = new FanOnCommand(fan);
ICommand fanOff = new FanOffCommand(fan);
ICommand garageOn = new GarageDoorOnCommand(garageDoor);
ICommand garageOff = new GarageDoorOffCommand(garageDoor);
remote.SetCommand(0, lightOn, lightOff);
remote.SetCommand(1, garageOn, garageOff);
remote.SetCommand(2, fanOn, fanOff);

remote.OnButtonPressed(0);
remote.OffButtonPressed(0);
remote.OnButtonPressed(1);
remote.OffButtonPressed(1);
remote.OnButtonPressed(2);
remote.OffButtonPressed(2);
remote.UndoButtonPressed();