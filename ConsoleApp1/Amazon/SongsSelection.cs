using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeSamples.Amazon
{
    class SongsSelection
    {
        public List<int> IDsOfSongs(int rideDuration, List<int> songDuration)
        {
            var output = new List<int>();
            var sortedList = songDuration.OrderBy(o => o).ToArray();
            int l = 0, r = sortedList.Count() - 1, diff = int.MaxValue;
            int pos_l = 0, pos_r = 0;
            rideDuration -= 30;

            while (l < r)
            {
                if (Math.Abs(sortedList[l] + sortedList[r] - rideDuration) < diff)
                {
                    pos_l = l;
                    pos_r = r;
                    diff = Math.Abs(sortedList[l] + sortedList[r] - rideDuration);
                }

                if (sortedList[l] + sortedList[r] > rideDuration)
                    r--;
                else
                    l++;
            }

            int il = 0, ir = 0;
            foreach (var s in songDuration)
            {
                if (s == sortedList[pos_l])
                    break;
                il++;
            }
            foreach (var s in songDuration)
            {
                if (s == sortedList[pos_r])
                    break;
                ir++;
            }
            output.Add(il);
            output.Add(ir);
            return output.OrderBy(o => o).ToList();
        }
    }
}
