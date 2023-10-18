using Project_65030258;

namespace Project_65030258
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project members:");
            foreach (string member in Enum.GetNames(typeof(Project.Members)))
            {
                Console.WriteLine("  [" +
                    ((int)Enum.Parse(typeof(Project.Members), member)).ToString() + "]: "
                    + member);
            }

            Console.WriteLine($"Project members count = {Enum.GetNames(typeof(Project.Members)).Length}");

        }
    }
}