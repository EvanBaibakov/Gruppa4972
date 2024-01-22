// Написать программу которая будет выдавать название дня недели по заданному нуму
 //student 
//  int day = int.Parse(Console.ReadLine()??"0");

//  string[] dayOFWeek = new string[7];

//  dayOFWeek[0]="Понедельник";
//  dayOFWeek[1]="Вторник";
//  dayOFWeek[2]="Среда";
//  dayOFWeek[3]="Четверг";
//  dayOFWeek[4]="Пятница";
//  dayOFWeek[5]="Суббота";
//  dayOFWeek[6]="Воскресенье";

//  Console.WriteLine(dayOFWeek[day-1]);

//student

System.Console.WriteLine("Vvedite chislo");
int a = Convert.ToInt32 (Console.ReadLine());
switch (a)
{
    case 1: Console.WriteLine ("Mon");
    break;

    case 2: Console.WriteLine ("The");
    break;

    case 3: Console.WriteLine ("Wen");
    break;

    case  4: Console.WriteLine ("The4");
    break;

    case 5: Console.WriteLine ("Fri");
    break;

    case 6: Console.WriteLine ("Sat");
    break;

    case 7: Console.WriteLine ("Sun");
    break;
}