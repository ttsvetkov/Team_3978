/*
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
*/

using static Input;
using static CheckPolindrom;

string str = Convert.ToString(ConsoleInput());
CheckPol(str);