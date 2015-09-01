using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/rectangle-area/
    class RectangleArea
    {
        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            var area1 = ComputeArea(A, B, C, D);
            var area2 = ComputeArea(E, F, G, H);
            var commonarea = CommanArea(A, B, C, D, E, F, G, H);
            return area1 + area2 - commonarea;
        }

        private int CommanArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            //Y axis value
            if (B > H || D < F)
                return 0;
            //X axis value
            else if (A > G || C < E)
                return 0;
            var height = Math.Abs(Math.Min(D, H) - Math.Max(B, F));
            var width = Math.Abs(Math.Max(A, E) - Math.Min(C, G));
            return height * width;
        }

        private int ComputeArea(int A, int B, int C, int D)
        {
            var height = Math.Abs(D - B);
            var width = Math.Abs(A - C);
            return height * width;
        }
    }
}
