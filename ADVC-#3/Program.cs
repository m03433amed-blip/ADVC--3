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
            #region EX:2
            Dictionary<int, string> leaderboard = new Dictionary<int, string>();

            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");
            // 2
            foreach (var item in leaderboard.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
            Console.WriteLine("-----------------------------");
            // 3
            var first = leaderboard.OrderBy(x => x.Key).First();

            Console.WriteLine($"First Key: {first.Key}");
            Console.WriteLine($"First Value: {first.Value}");

            Console.WriteLine("-----------------------------");

            // 4
            Console.WriteLine(
                $"Score 500 exists: {leaderboard.ContainsKey(500)}");
            Console.WriteLine("-----------------------------");


            // 5
            if (leaderboard.TryGetValue(999, out string player))
            {
                Console.WriteLine(player);
            }
            else
            {
                Console.WriteLine("Player not found");
            }
            Console.WriteLine("-----------------------------");


            // 6
            leaderboard.Remove(200);

            Console.WriteLine("Updated Leaderboard:");

            foreach (var item in leaderboard.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }

            #endregion
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            #region EX:3
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();


            phoneBook.Add("Ahmed", "01011111111");
            phoneBook.Add("Sara", "01122222222");
            phoneBook.Add("Ali", "01233333333");
            phoneBook.Add("Mona", "01544444444");

            Console.WriteLine("-----------------------------");

            // 2
            phoneBook["Omar"] = "01055555555";

            Console.WriteLine("-----------------------------");

            // 3
            try
            {
                phoneBook.Add("Ahmed", "01199999999");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("-----------------------------");

            // 4
            bool added = phoneBook.TryAdd("Ahmed", "01199999999");

            Console.WriteLine($"TryAdd succeeded: {added}");

            Console.WriteLine("-----------------------------");

            // 5
            Console.WriteLine($"Khaled exists: {phoneBook.ContainsKey("Khaled")}");

            Console.WriteLine("-----------------------------");


            // 6
            string phone = phoneBook.TryGetValue("Khaled", out string value) ? value : "Not Found";

            Console.WriteLine($"Khaled: {phone}");

            Console.WriteLine("-----------------------------");


            // 7
            Console.WriteLine("Names:");

            foreach (string name in phoneBook.Keys)
            {
                Console.Write($"{name} ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            // 8
            Console.WriteLine("Phone Numbers:");

            foreach (string phoneNumber in phoneBook.Values)
            {
                Console.Write($"{phoneNumber} ");
            }
            #endregion
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            #region EX:4
            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // 2
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            Console.WriteLine("-----------------------------");

            // 3
            Console.WriteLine($"Email Count: {emails.Count}");

            Console.WriteLine("-----------------------------");

            // 4
            HashSet<int> setA = new HashSet<int>()
            {
                1, 2, 3, 4, 5
            };

            HashSet<int> setB = new HashSet<int>()
            {
                4, 5, 6, 7, 8
            };
            Console.WriteLine("-----------------------------");

            // Union
            HashSet<int> union = new HashSet<int>(setA);
            union.UnionWith(setB);

            Console.WriteLine("Union:");
            foreach (int x in union)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            // Intersection
            HashSet<int> intersection = new HashSet<int>(setA);
            intersection.IntersectWith(setB);

            Console.WriteLine("Intersection:");
            foreach (int x in intersection)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            // Except
            HashSet<int> except = new HashSet<int>(setA);
            except.ExceptWith(setB);

            Console.WriteLine("Except:");
            foreach (int x in except)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            // IsSubsetOf
            HashSet<int> smallSet = new HashSet<int>()
            {
                1, 2
            };

            Console.WriteLine(
                $"Is Subset: {smallSet.IsSubsetOf(setA)}");
            #endregion
        }
    }
}
