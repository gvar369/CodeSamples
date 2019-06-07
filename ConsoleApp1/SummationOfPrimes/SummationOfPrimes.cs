using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CodeSamples.SummationOfPrimes
{
    public class SummationOfPrimes : ISummationOfPrimes
    {
        public long ProcessData(int maxNumber)
        {
            long result = 0;
            if (maxNumber > 0 && maxNumber <= 2)
                result = maxNumber;
            else
            {
                for (int i = 3; i <= maxNumber; i++)
                {
                    bool isPrime = true;
                    if (i % 2 != 0)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        isPrime = false;
                    }

                    if (isPrime)
                        result += i;
                }
            }

            if (result > 2) result = result + 2;
            return result;
        }

        public long ProcessDataSieve(int maxNumber)
        {
            List<int> primeNumbers = Enumerable.Range(2, maxNumber).Where(w => w % 2 != 0).ToList();

            return primeNumbers.Count;
        }

        public long ProcessDataLinq(int maxNumber)
        {
            List<long> primeNumbers = new List<long>();
            var nonEvenNumbers = Enumerable.Range(2, maxNumber).Where(w => w % 2 != 0).ToList();
            foreach (var nonEvenNumber in nonEvenNumbers)
            {
                bool isPrime = true;
                for (int i = 2; i <= nonEvenNumber; i++)
                {
                    if (nonEvenNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                    primeNumbers.Add(nonEvenNumber);
            }

            return primeNumbers.Sum();
        }
    }
}
