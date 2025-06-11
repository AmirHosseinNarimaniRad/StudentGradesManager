List<double> grades = new();

while (true)
{
    Console.WriteLine("===== Student Grades Manager =====");
    Console.WriteLine("1. Add a grade");
    Console.WriteLine("2. Show all grades");
    Console.WriteLine("3. Calculate average");
    Console.WriteLine("4. Show highest and lowest grade");
    Console.WriteLine("5. Exam status");
    Console.WriteLine("6. Exit");
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

        case "3":
            if (grades.Count == 0)
            {
                Console.WriteLine("⚠️ No grades available to calculate average.");
            }
            else
            {
                double average = grades.Average();
                Console.WriteLine($"📊 Average grade: {average:F2}");
            }
            break;
        case "4":
            if(grades.Count == 0)
            {
                Console.WriteLine("⚠️ No grades available.");

            }
            else
            {
                double max= grades.Max();
                double min= grades.Min();
                Console.WriteLine($"Highest Grade is {max:F2}");
                Console.WriteLine($"Lowest Grade is {min:F2}");
            }
            break;
        case "5":
            if (grades.Count == 0)
            {
                Console.WriteLine("No Grades Available.");
            }
            else 
            {
                double avrage = grades.Average();
                if(avrage < 10)
                {
                    Console.WriteLine("You failed your exams! ");
                }
                else
                {
                    Console.WriteLine("Good job,you passed your exams!"); 
                }
            }
            break;

        case "6":
            Console.WriteLine("Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    Console.WriteLine(); 
}
