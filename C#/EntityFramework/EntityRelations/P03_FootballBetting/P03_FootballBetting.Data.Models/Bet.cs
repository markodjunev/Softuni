namespace P03_FootballBetting.Data.Models
{
    using System;

    public class Bet
    {
        public int BetId { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateTime { get; set; }

        public PredictionType Prediction { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        public enum PredictionType
        {
            Win = 1,
            Draw = 0,
            Lose = -1
        }
            
    }
}
