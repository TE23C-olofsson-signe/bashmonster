using bashmonster;

Harry youHarry = new Harry();

Voldermort youVoldermort = new Voldermort(); 

Console.WriteLine($"{youHarry.name}has{youHarry.health}healths");
Console.WriteLine($"{youVoldermort.name}has{youVoldermort.health}healths and {youVoldermort.size} size");

Console.WriteLine("Attack!");
youVoldermort.health -= 10;

Console.WriteLine($"{youVoldermort.name} now has{youVoldermort.health}health");
Console.WriteLine("Press any key to continue....");

Console.ReadKey(); 