using Strings.Logic;

Console.WriteLine("Ingrese la viga: ");
string TheBeam = Console.ReadLine();
TheMostResistantBeam instanceBeam = new TheMostResistantBeam(TheBeam);

Console.WriteLine(instanceBeam.validBeam());