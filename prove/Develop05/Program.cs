using System;
using System.Diagnostics;
class Demo
{
private Stopwatch sw = new Stopwatch();
private double lastFrame;
private double deltaTime()
{
TimeSpan ts = this.sw.Elapsed;
double firstFrame = ts.TotalMilliseconds;
double dt = firstFrame - lastFrame;
this.lastFrame = ts.TotalMilliseconds;
return dt;
}
public void run()
{
this.sw.Start();
double acc = 0.0;
List<string> buf = new List<string>();
Console.WriteLine("Go!");
while (acc <= 5000)
{
acc += this.deltaTime();
if (!Console.KeyAvailable)
{
continue;
}
ConsoleKeyInfo key = Console.ReadKey();
if (key.Key == ConsoleKey.Enter)
{
Console.WriteLine("");
buf.Add("\n");
}
else
{
buf.Add(key.KeyChar.ToString());
}
}
Console.WriteLine("\nTime's up!");
string bufStr = String.Join<string>("", buf);
Console.WriteLine($"Here's what you typed: {bufStr}");
}
}
static class Program
{
static void Main(string[] args)
{
Demo demo = new Demo();
demo.run();
}
}