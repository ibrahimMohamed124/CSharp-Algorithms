Dictionary<int, string> students = new Dictionary<int, string>();

students.Add(1, "Ibrahim");
students.Add(2, "Keemo");
students.Add(3, "Mohamed");
students.Add(4, "Said");

foreach (var (id, name) in students)
{
    Console.WriteLine($"ID: {id}, Name: {name}");
}

// Keep the console window open 