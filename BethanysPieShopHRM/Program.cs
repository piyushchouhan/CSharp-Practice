DateTime hireDate = new DateTime(2024, 1,1 , 12, 00, 0);
Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2024, 07, 07);
Console.WriteLine(exitDate);

DateTime startDate = hireDate.AddDays(8);
Console.WriteLine(startDate);

DateTime startHour = DateTime.Now;
TimeSpan timeSpent = new TimeSpan(8, 35, 8);

DateTime endHour = startHour.Add(timeSpent);

Console.WriteLine(startHour); 
Console.WriteLine(endHour);

Console.ReadLine();
