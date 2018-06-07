using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TetrisWebApi.Models
{
    public class Score : IComparable
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int UserId { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Score)
            {
                var score = (Score)obj;
                if (this.Value > score.Value)
                    return 1;
                else if (this.Value < score.Value)
                    return -1;
                else
                    return 0;
            }
            return 0;
        }
    }
}
