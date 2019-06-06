using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var queries = new List<List<int>>()
            {
                new List<int>() { 1, 0, 5 },
                new List<int>() { 1, 1, 7 },
                new List<int>() { 1, 0, 3 },
                new List<int>() { 2, 1, 0 },
                new List<int>() { 2, 1, 1 }
            };

            DynamicArray(2, queries);
        }

        // Hackerrank task
        static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            int numberOfSequences = n;
            int numberOfQueries = queries.Count;
            List<List<int>> seqList = new List<List<int>>();
            List<int> results = new List<int>();

            for (int i = 0; i < numberOfSequences; i++)
            {
                seqList.Add(new List<int>());
            }

            int lastAnswer = 0;

            for (int i = 0; i < numberOfQueries; i++)
            {
                if (queries[i][0] == 1)
                {
                    int numberToAppend = queries[i][2];
                    int index = ((queries[i][1] ^ lastAnswer) % numberOfSequences);
                    seqList[index].Add(numberToAppend);
                }
                else if (queries[i][0] == 2)
                {
                    int index = ((queries[i][1] ^ lastAnswer) % numberOfSequences);

                    int temp = queries[i][2] % seqList[index].Count;
                    lastAnswer = seqList[index][temp];

                    results.Add(lastAnswer);
                    Console.WriteLine(lastAnswer);
                }
                else
                {
                    throw new ArgumentException("Something went wrong. Check how you handle the queries!!!");
                }
            }

            return results;
        }
    }
}
