using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TetrisWebApi.Models;

namespace TetrisWebApi.Controllers
{
    public class ScoresController
    {
        private readonly TetrisWebContext _context;

        public ScoresController(TetrisWebContext context)
        {
            _context = context;
        }

        public List<Score> getTopTenScoresById(int id)
        {
            List<Score> scores = _context.Score
                .Where(score => score.UserId == id)
                .Select(score => score)
                .OrderByDescending(score => score.Value)
                .Take(10)
                .ToList();
            return scores;
        }

        public List<Score> getTopTenScoresGlobal()
        {
            List<Score> scores = _context.Score
                .Select(score => score)
                .OrderByDescending(score => score.Value)
                .Take(10)
                .ToList();
            return scores;
        }

        public List<ScoreJsonResponse> getTopTenScoresResponseWithUserNames()
        {
            var scores = getTopTenScoresGlobal();
            List<ScoreJsonResponse> response = new List<ScoreJsonResponse>();
            foreach (Score score in scores)
            {
                var user = _context.Users.SingleOrDefault(u => u.Id == score.UserId);
                ScoreJsonResponse jsonObject = new ScoreJsonResponse()
                {
                    Value = score.Value,
                    UserName = user.Name
                };
                response.Add(jsonObject);
            }

            return response;
        }

    }
}
