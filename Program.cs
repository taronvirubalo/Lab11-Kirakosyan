//int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
//int target = 1071;
//bool found = false;

//foreach (int number in recordBooks)

/// if (number == target)
//  {
//   found = true;
///    break;
//  }
//}
// int variant = 17;
// bool isPrime = true;

// for (int divisor = 2; divisor == 0;)
// {
//     isPrime = false;
//     break;
// }


// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");

// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;
// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++){
//     {
//         if (groupIds[i]== groupIds [j]) {
//             hasDuplicates = true;
//             break;
//         }
//     }
// }
// Console.WriteLine(hasDuplicates ? "усть повторяющиеся номера" : "Все номера уникальны");
// int days = 5;
// int lessonsPerday = 6;
// bool found = false;
// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerday; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);

//         if (isFree)
//         {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }

// if (!found)
// {
//     Console.WriteLine("Свободных слотов нет");
// }
Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы. ");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
