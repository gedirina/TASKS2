﻿Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
{
  Console.WriteLine("Третья цифра: " + NumberText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}