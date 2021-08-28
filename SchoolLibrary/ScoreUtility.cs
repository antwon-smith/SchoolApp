using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class ScoreUtility
    {

        public static IScored BestofTwo(IScored Assignment1, IScored Assignment2)
        {
            var score1 = Assignment1.Score / Assignment1.Maximumscore;
            var score2 = Assignment2.Score / Assignment2.Maximumscore;

            if (score1 > score2)
            {
                return Assignment1;
            }
            else
            {
                return Assignment2;
            }
        }
    }
}
