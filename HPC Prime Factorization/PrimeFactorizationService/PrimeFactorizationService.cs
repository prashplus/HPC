using System.Collections.Generic;

namespace Microsoft.Hpc.SOASample.RealTimeMode
{
    public class PrimeFactorizationService : IPrimeFactorization
    {
        public List<int> Factorize(int n)
        {
            List<int> factors = new List<int>();

            for (int i = 2; n > 1; )
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
                else
                {
                    i++;
                }
            }

            return factors;
        }
    }
}