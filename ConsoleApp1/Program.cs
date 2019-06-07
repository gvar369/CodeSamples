using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public static class Program
{
    static void Main()
    {
        //var inputData = new int[] { 1, 6, 2, 1, 6, 1 };
        //var outpuData = (new KElements.KElements()).ProcessData(inputData, 2);

        //var outputData = (new SummationOfPrimes.SummationOfPrimes()).ProcessDataSieve(2000000);
        //Console.WriteLine(outputData);

        //var outputData = (new SongsSelection()).IDsOfSongs(250, new List<int> {100,180,40,120,10});
        //foreach (var i in outputData)
        //{
        //    Console.WriteLine(i);
        //}

        //var finput = new List<List<int>> {new List<int> {1, 3000}, new List<int> {2, 5000}, new List<int> {3, 7000}, new List<int> { 4, 10000 } };
        //var rinput = new List<List<int>> { new List<int> { 1, 2000 }, new List<int> { 2, 3000 }, new List<int> { 3, 4000 }, new List<int> { 4, 5000 } };
        //var outputData = (new AirPrime()).optimalUtilization(10000, finput, rinput);
        //foreach (var i in outputData)
        //{
        //    foreach (var i1 in i)
        //    {
        //        Console.WriteLine(i1);
        //    }
        //}

        //string[] strArr = new string[] { "[5,2,6,1,#,8,#]" };
        //var data = strArr[0].Where(w => w != '[' && w != ']' && w != ',').ToArray();
        //Console.WriteLine(data[0]);
        //Console.WriteLine((int)'1');

        //using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        //    while (!reader.EndOfStream)
        //    {
        //        string line = reader.ReadLine();
        //        string pattern = @"[A-Z][a-z]+[$]+[A-Z][a-z0-9]";
        //        var output = Regex.IsMatch(line, pattern);
        //        Console.WriteLine(output);
        //    }
        //var result = IsRobotBounded("GL");

        //var result = LastStoneWeightII(new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 14, 23, 37, 61, 98 });
        //var result = RemoveDuplicates("abbaca");

        //string phone = "+1 9723756495";
        //var output = string.Join("",phone.Where(w => char.IsNumber(w)).Skip(1));
        //Console.WriteLine(output);
        //var result = DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });

        var result = GcdOfStrings("ABCABC", "ABC");
        Console.WriteLine(string.Join(" ", result));


    }

    public static string GcdOfStrings(string str1, string str2)
    {
        if (str1.Length == str2.Length)
        {
            if (str1.Equals(str2))
            {
                Console.WriteLine($"str1: {str1}, str2: {str2}");
                return str1;
            }
            else
                return "";
        }
        else
        {
            if (str1.Length < str2.Length)
            {
                Console.WriteLine($"switching str1: {str1}, str2: {str2}");
                return GcdOfStrings(str2, str1);
            }
            else
            {
                Console.WriteLine($"str1 - substring: {str1.Substring(str2.Length)}, str2: {str2}");
                return GcdOfStrings(str1.Substring(str2.Length), str2);
            }
                
        }
    }

    public static int[] DailyTemperatures(int[] T)
    {
        var stack = new Stack<int>();
        var output = new int[T.Length];
        for (int i = 0; i < T.Length; i++)
        {
            while (stack.Count() > 0 && T[i] > T[stack.Peek()])
            {
                int idx = stack.Pop();
                output[idx] = i - idx;
            }
            stack.Push(i);
        }
        return output;
    }

    //public static int[] DailyTemperatures(int[] T)
    //{
    //    var length = T.Length;
    //    var output = new int[length];

    //    for (int i = 0; i < length; i++)
    //    {
    //        int currentTemp = T[i];
    //        int k = i + 1;
    //        for (int j = 0; j < length - i - 1; j++)
    //        {
    //            if (T[k] > currentTemp)
    //            {
    //                output[i] = k - i;
    //                break;
    //            }
    //            k++;
    //        }
    //    }
    //    return output;
    //}

    public static int LastStoneWeight(int[] stones)
    {
        var sStones = stones.OrderByDescending(o => o).ToArray();
        while(sStones.Length > 1)
        {
            if (sStones[0] == sStones[1])
                sStones[0] = 0;
            else
                sStones[0] = sStones[0] - sStones[1];

            sStones[1] = 0;

            sStones = sStones.Where(w => w != 0).OrderByDescending(o => o).ToArray();
            Console.WriteLine("[" + string.Join(", ", sStones) + "]");
        }
        return sStones[0];
    }

    public static int LastStoneWeightII(int[] stones)
    {
        var dp = new bool[1501];
        dp[0] = true;
        int sumA = 0, res = 100;
        foreach(var s in stones)
        {
            sumA += s;
            for(int i = 1500; i >= s; --i)
            {
                dp[i] |= dp[i - s];
            }
        }
        for(int i = sumA/2; i> 0; --i)
        {
            Console.WriteLine(dp[i]);
            if (dp[i]) return sumA - i - 1;
        }

        return 0;

        //while (stones.Length > 2)
        //{
        //    if (stones[0] == stones[1])
        //        stones[0] = 0;
        //    else
        //    {
        //        if (stones[0] > stones[1])
        //            stones[0] = stones[0] - stones[1];
        //        else
        //            stones[0] = stones[1] - stones[0];
        //    }
                

        //    stones[1] = 0;

        //    stones = stones.Where(w => w != 0).ToArray();
        //    Console.WriteLine("[" + string.Join(", ", stones) + "]");
        //}
        //return stones.Min();
    }

    public static string RemoveDuplicates(string S)
    {
        int i = 0;
        StringBuilder sb = new StringBuilder(S);
        while(i < sb.Length - 1)
        {
            if(sb[i] == sb[i + 1])
            {
                sb.Remove(i, 2);
                i = 0;
            }
            else
                i++;
            Console.WriteLine(i);
            Console.WriteLine(sb.ToString());
        }

        return sb.ToString();
    }

    public static bool IsRobotBounded(string instructions)
    {
        int ctr = 0, vctr = 1;
        bool isLeftStart = true;
        while (vctr > 1 || ctr <= 10)
        {
            for (int i = 0; i < instructions.Length; i++)
            {
                var instr = instructions[i];
                Console.WriteLine(instr);
                if (instr == 'R')
                    isLeftStart = false;

                switch (instr)
                {
                    case 'G':
                        break;
                    case 'L':
                        if (isLeftStart)
                        {
                            if (vctr > 1)
                                vctr--;
                            else
                                vctr++;
                        }
                        else
                        {
                            if (vctr > 2)
                                vctr++;
                            else
                                vctr--;
                        }
                        Console.WriteLine(vctr);
                        ctr++;
                        break;
                    case 'R':
                        if (isLeftStart)
                        {
                            if (vctr > 1)
                                vctr++;
                            else
                                vctr--;
                        }
                        else
                        {
                            if (vctr > 1)
                                vctr--;
                            else
                                vctr++;
                        }
                        Console.WriteLine(vctr);
                        ctr++;
                        break;
                    default:
                        break;
                }
            }
        }
        return (ctr > 0 && vctr == 1);
    }
}