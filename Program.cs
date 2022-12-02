internal class Program
{
    static int[,] resultsTree = new int[3, 3];
    private static void Init()
    {
        //lose choice
        resultsTree[0, 0] = 3;
        resultsTree[1, 0] = 1;
        resultsTree[2, 0] = 2;
        //draw choice
        resultsTree[0, 1] = 1 + 3;
        resultsTree[1, 1] = 2 + 3;
        resultsTree[2, 1] = 3 + 3;
        //win choice
        resultsTree[0, 2] = 2 + 6;
        resultsTree[1, 2] = 3 + 6;
        resultsTree[2, 2] = 1 + 6;
    }
    private static void Main(string[] args)
    {
        Init();
        
        int total = 0;
        string[] lines = File.ReadAllLines("input.txt");
        foreach (string line in lines)
        {
            total += resultsTree[line[0]-'A', line[2]-'X'];
        }

        Console.WriteLine(total);
    }
}