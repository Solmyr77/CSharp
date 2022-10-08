using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class pickObject
    {
        public int[] AwardPoints(int flag)
        {
            int[] points = new int[2];

            if (flag == 0)
            {
                points[0] = 0; //user points
                points[1] = 1; //opponent points
                return points;
            }
            else if (flag == 1)
            {
                points[0] = 1;
                points[1] = 0;
                return points;
            }
            else
            {
                points[0] = 0;
                points[1] = 0;
                return points;
            }
        }
    }
}
