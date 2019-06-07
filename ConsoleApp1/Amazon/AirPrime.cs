using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeSamples.Amazon
{
    class AirPrime
    {
        public List<List<int>> optimalUtilization(int maxTravelDist, List<List<int>> forwardRouteList,
            List<List<int>> returnRouteList)
        {
            int maxiterations = 0;
            var output = new List<List<int>>();
            var fsorted = forwardRouteList.Select(s => s.OrderBy(o => o).ToList()).ToList();
            var rsorted = returnRouteList.Select(s => s.OrderBy(o => o).ToList()).ToList();
            var m = maxTravelDist;
            while (true)
            {
                foreach (var f in fsorted)
                {
                    foreach (var r in rsorted)
                    {
                        int fdist = f.LastOrDefault();
                        int rdist = r.LastOrDefault();
                        int totaldist = fdist + rdist;

                        if (totaldist > m)
                            break;
                        if (totaldist == m)
                            output.Add(new List<int> {f.FirstOrDefault(), r.FirstOrDefault()});
                            
                    }
                }
                //if(output.Count() > 0 || maxiterations = int.MaxValue)
                    break;
                m--;
                maxiterations++;
            }

            return output;
        }
    }
}
