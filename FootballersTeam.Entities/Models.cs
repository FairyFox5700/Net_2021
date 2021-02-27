using System;

namespace FootballProject.Entities.Models
{
    public abstract class FootballTotalResultsResponse
    {
        public  int RedCardTotalCount { get; set; }
        public  int YellowCardTotalCount { get; set; }
        public  int ScoredGoalsTotalCount { get; set; }
        public  int MissedGoalsTotalCount { get; set; }
    }

    public class TotalResultsForMatch:FootballTotalResultsResponse
    {
        public  int MatchId { get; set; }
        public  string MatchName { get; set; }
    }

    public class TotalResultsForFootballer:FootballTotalResultsResponse
    {
        public  int PlayerId { get; set; }
        public  string FirstName { get; set; }
        public  string MiddleName { get; set; }
    }
    
    public class FootballResultsResponse
    {
        public int ResultId { get; set; }
        public int ScoreId { get; set; }
        public int ScoredGoals { get; set; }
        public int MissedGoals { get; set; }
        public int? CardId { get; set; }
        public int RedCardCount { get; set; }
        public int YellowCardCount { get; set; }
        public int MatchId { get; set; }
        public int FootballerId { get; set; }
    }
    
    public class FootballerDto
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Nationality { get; set; }
        public DateTime DataOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int? RoleId { get; set; }
    }
}