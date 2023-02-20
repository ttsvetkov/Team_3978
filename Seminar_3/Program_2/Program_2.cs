/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
*/

using static GetCoor;
using static GetDistance;

string[] Xcoor = ConsoleInputX();
string[] Ycoor = ConsoleInputY();

Console.Write($"Расстояние : {Distance(Xcoor, Ycoor)}");
