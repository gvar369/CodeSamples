using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSamples
{
    class IsRobotBounded
    {
        public static bool IsRobotBounded1(string instructions)
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
}
