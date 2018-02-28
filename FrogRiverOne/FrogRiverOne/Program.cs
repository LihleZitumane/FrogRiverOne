using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
    class Program
    {
        static int solution(int X, int[] A)
        {
            int count = 1;
            int Ind1 = Array.IndexOf(A, X);
            Array.Sort(A);
            List<int> x = new List<int>();
            x = A.ToList();
            int Ind = x.IndexOf(X);
            for (int i=0; i < Ind+1; i++)
            {
                var IsThere = x.Where(v => v == count);
                var IsThereCount = IsThere.ToList();
                if (IsThereCount.Count == 0)
                    return -1;
                if (i < Ind && A[i] != A[i + 1])
                    count++;
            }

            return Ind1;
        }
        static void Main(string[] args)
        {
            Console.Write(solution(5, new int[] {3,3,2,1,4}));
            Console.ReadKey();        }
    }
}
