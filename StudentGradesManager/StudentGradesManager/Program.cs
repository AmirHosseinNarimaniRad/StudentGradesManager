List<double> grades = new();

while (true)
{
    Console.WriteLine("===== Student Grades Manager =====");
    Console.WriteLine("1. Add a grade");
    Console.WriteLine("2. Show all grades");
    Console.WriteLine("3. Calculate average");
    Console.WriteLine("4. Show highest and lowest grade");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.Write("Enter a grade (0 to 20): ");
            string gradeInput = Console.ReadLine();

            if (double.TryParse(gradeInput, out double grade))
            {
                if (grade >= 0 && grade <= 20)
                {
                    grades.Add(grade);
                    Console.WriteLine("✅ Grade added successfully.");
                }
                else
                {
                    Console.WriteLine("❌ Grade must be between 0 and 20.");
                }
            }
            else
            {
                Console.WriteLine("❌ Invalid input. Please enter a number.");
            }
            break;

        case "2":
            if (grades.Count == 0)
            {
                Console.WriteLine("⚠️ No grades have been added yet.");
            }
            else
            {
                Console.WriteLine("📋 List of all grades:");
                for (int i = 0; i < grades.Count; i++)
                {
                    Console.WriteLine($"Grade {i + 1}: {grades[i]}");
                }
            }
            break;

        case "5":
            Console.WriteLine("Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    Console.WriteLine(); 
}
