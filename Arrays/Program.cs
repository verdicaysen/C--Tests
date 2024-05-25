internal class Program
{
    private static void Main(string[] args)
    {

        int[] scores = new int[5];
        
        Console.WriteLine("Hello, please add the numbers for the replicator.");

        scores[0] = Convert.ToInt32(Console.ReadLine());
        scores[1] = Convert.ToInt32(Console.ReadLine());
        scores[2] = Convert.ToInt32(Console.ReadLine());
        scores[3] = Convert.ToInt32(Console.ReadLine());
        scores[4] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nicely done, time to build the array");
        for (int index = 0; index < scores.Length; index++)
        {
            
            Console.WriteLine(scores[index]);
        }

        Console.WriteLine("Alright, now we're going to copy the original array using the original scores input.");
        int[] scores1 = new int[scores.Length];
        Array.Copy(scores, scores1, scores.Length);
        
        Console.WriteLine("First array.");
        for (int index = 0; index < scores.Length; index++)
        {
            Console.WriteLine(scores[index]);
        }

        Console.WriteLine("Second array.");
        for (int index1 = 0; index1 < scores1.Length; index1++)
        {
            Console.WriteLine(scores1[index1]);
            
        }
        Console.WriteLine("There, now we've displayed both, the Replicator is complete.");
    }
}