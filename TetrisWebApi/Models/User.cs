using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TetrisWebApi.Models
{
    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Score> Scores { get; set; }

        public User()
        {
            Scores = new SortedSet<Score>();
        }

    }
}