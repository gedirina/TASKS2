Console.Write("Введи номер дня недели: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek (int dayNumber)
 {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("этот день выходной");
  }
 
  else Console.WriteLine("этот день не выходной");
}

DayOfTheWeek(dayNumber);