using Lab3;

string path = "C:\\1\\v0.json";

Vector v0 = new(1, 2, 3, 4, 5, 6);
Console.WriteLine("Vector v0:");
v0.PrintCoords();
v0.PrintVect();
double x = v0.XStart;
Console.WriteLine("v0.xStart = " + x);
double xV = v0.XVect;
Console.WriteLine("v0.xVect = " + xV);
v0.SaveToJson(path/*, v0*/);
Console.WriteLine();

Vector v1 = Vector.LoadFromJson(path);

Console.WriteLine("Vector v1:");
v1.PrintCoords();
v1.PrintVect();
Console.WriteLine();

Vector v2 = new(1, 2, 3);
Console.WriteLine("Vector v2:");
v2.PrintCoords();
v2.PrintVect();
Console.WriteLine();

Vector vS = Vector.Sum(v1, v2);
Console.WriteLine("Sum vector of v1 and v2:");
vS.PrintCoords();
vS.PrintVect();
Console.WriteLine();

Vector vD = Vector.Diff(v1, v2);
Console.WriteLine("Diff vector of v1 and v2:");
vD.PrintCoords();
vD.PrintVect();
Console.WriteLine();

Vector vSV = Vector.SumVect(v1, v2);
Console.WriteLine("Sum vector of v1 and v2 (Vect version):");
vSV.PrintCoords();
vSV.PrintVect();
Console.WriteLine();

Vector vDV = Vector.DiffVect(v1, v2);
Console.WriteLine("Diff vector of v1 and v2 (Vect version):");
vDV.PrintCoords();
vDV.PrintVect();
Console.WriteLine();

v1.MoveVect(1, 2, 3);
Console.WriteLine("Moved vector v1 (+ (1, 2, 3)):");
v1.PrintCoords();
v1.PrintVect();
Console.WriteLine();

Console.WriteLine("Scalar product (v1, v2) = " + Vector.ScalarProduct(v1, v2));
Console.WriteLine("Length of v1 = " + Vector.Length(v1));
Console.WriteLine("Length of v2 = " + Vector.Length(v2));
Console.WriteLine("Cosine of (v1 ^ v2) = " + Vector.Cosine(v1, v2));

Console.ReadKey();