using System.Diagnostics;

namespace HashSetExperiment
{
	internal class Program
	{
		const int num = (int)1E9;

		static void Main(string[] args)
		{
			Stopwatch stopwatch = new Stopwatch();

			// Add HashSet
			stopwatch.Start();
			HashSet<int> hashSet = new HashSet<int>();

			for (int i = 0; i < num; i++)
			{
				hashSet.Add(i);
			}

			stopwatch.Stop();

			long hashsetaddtime = stopwatch.ElapsedMilliseconds;

			stopwatch.Reset();
			stopwatch.Start();

			// Add List
			List<int> list = new List<int>();
			for (int i = 0; i < num; i++)
			{
				list.Add(i);
			}
			stopwatch.Stop();

			long listaddtime = stopwatch.ElapsedMilliseconds;

			// Searching
			int numToFind = num;

			stopwatch.Reset();

			stopwatch.Start();
			// in Hash Set
			hashSet.Contains(numToFind);
			stopwatch.Stop();

			long hashsetsearchtime = stopwatch.ElapsedMilliseconds;

			stopwatch.Reset();
			stopwatch.Start();
			
			list.Contains(numToFind);
			stopwatch.Stop();

			long listsearchtime = stopwatch.ElapsedMilliseconds;

			Console.WriteLine($"HashSet Add Time: {hashsetaddtime} ms");
			Console.WriteLine($"List Add Time: {listaddtime} ms");
			Console.WriteLine();
			Console.WriteLine($"HashSet Search Time: {hashsetsearchtime} ms");
			Console.WriteLine($"List Search Time: {listsearchtime} ms");
		}
	}
}