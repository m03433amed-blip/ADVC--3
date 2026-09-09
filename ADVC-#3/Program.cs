namespace ADVC__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EX:1

            List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            // 2 
            Console.WriteLine("Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First: {grades[0]}");
            Console.WriteLine($"Last: {grades[grades.Count - 1]}");
            Console.WriteLine("-----------------------------");
            // 3
            grades.Sort();

            Console.WriteLine("Sorted:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("-----------------------------");

            // 4
            int firstAbove90 = grades.Find(g => g > 90);
            Console.WriteLine($"First grade above 90: {firstAbove90}");
            Console.WriteLine("-----------------------------");

            // 5
            List<int> failingGrades = grades.FindAll(g => g < 75);

            Console.WriteLine("Failing grades:");

            foreach (int grade in failingGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("-----------------------------");

            // 6
            grades.RemoveAll(g => g < 75);
            Console.WriteLine("-----------------------------");


            // 7
            bool has100 = grades.Contains(100);
            Console.WriteLine($"Has 100: {has100}");
            Console.WriteLine("-----------------------------");

            // 8
            List<string> gradeStrings =
                grades.Select(g => $"Grade: {g}").ToList();

            foreach (string grade in gradeStrings)
            {
                Console.WriteLine(grade);
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
