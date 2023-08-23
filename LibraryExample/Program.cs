using clib = ConsoleLibrary; // can use using statement to create an alias 
var x = 12;
var y = 0;

Console.WriteLine($"{x} + {y} = {clib.Math.Add(x,y)}");
Console.WriteLine($"{x} - {y} = {clib.Math.Sub(x, y)}");
Console.WriteLine($"{x} * {y} = {clib.Math.Mult(x, y)}");
Console.WriteLine($"{x} / {y} = {clib.Math.Div(x, y)}");
Console.WriteLine(clib.Math.Power(12, 4));
Console.WriteLine(clib.Math.Cubed(5));
Console.WriteLine($"{clib.Math.Inverse(12):F4}");
Console.WriteLine(clib.Math.Mod(5, 4));
Console.WriteLine(5 % 4);
