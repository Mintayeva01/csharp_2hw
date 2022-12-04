Console.WriteLine("Введите день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void TheDayOfTheWeek (int dayNumber)
    {
  if (dayNumber == 6 || dayNumber == 7)

    {
  Console.WriteLine("этот день выходной");
    }
  
    else 

    {
  Console.WriteLine("этот день не выходной");
    }
    }
    TheDayOfTheWeek(dayNumber);