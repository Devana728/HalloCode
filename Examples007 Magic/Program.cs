// See https://aka.ms/new-console-template for more information
Console.Clear();
//Console.SetCursorePosition(10, 4);
//Console.WriteLine("+");

int xa = 1;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;

Console.SetCursorePosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorePosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorePosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while(count<10000);
{
    int what = new Random().Next(0,3);
    if(what == 0);
    {
        x = (x+xa) /2;
        y = (y+ya) /2;
    }
    if(what == 1);
    {
        x = (x+xb) /2;
        y = (y+yb) /2;
    }
    if(what == 2);
    {
        x = (x+xc) /2;
        y = (y+yc) /2;
    }
    Console.SetCursorePosition(x, y);
    Console.WriteLine("+");
}
 

