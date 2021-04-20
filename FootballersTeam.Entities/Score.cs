using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Score : IComparable<Score>, IComparable, IEquatable<Score>
    {

        private int _scoreId;
        private int _scoredGoals;
        private int _missedGoals;

        public int ScoreId
        {
            get => _scoreId;
            set
            {
                if (value > 0 && value < Int32.MaxValue)
                {
                    _scoreId = value;
                }
            }
        }
        public int ScoredGoals
        {
            get => _scoredGoals;
            set
            {
                if (value > 0 && value < 100)
                {
                    _scoredGoals = value;
                }
            }
        }
        public int MissedGoals
        {
            get => _missedGoals;
            set
            {
                if (value > 0 && value < 100)
                {
                    _missedGoals = value;
                }
            }
        }
        public Score()
        {

        }
        public Score(int scoreId, int scoredGoals, int missedGoals, FootballResults footballResults)
        {
            ScoreId = scoreId;
            ScoredGoals = scoredGoals;
            MissedGoals = missedGoals;
            FootballResults = footballResults;
        }
        public override string ToString() => GetType().Name;

        ~Score() => Console.WriteLine($"The {ToString()} destructor is executing.");

        protected Score(Score scoreToCopyFrom)
        {

            ScoreId = scoreToCopyFrom._scoreId;
            ScoredGoals = scoreToCopyFrom._scoredGoals;
            MissedGoals = scoreToCopyFrom._missedGoals;
        }

        public FootballResults FootballResults { get; set; }

        #region oprators_overloading
        public static Score operator +(Score c)
        {
            Score temp = new Score();
            temp.MissedGoals = +c.MissedGoals;
            temp.ScoredGoals = +c.ScoredGoals;
            return temp;
        }

        public static Score operator +(Score c1, Score c2)
        {
            Score temp = new Score();
            temp.ScoreId = c1.ScoreId;
            temp.MissedGoals = c1.MissedGoals + c2.MissedGoals;
            temp.ScoredGoals = c1.ScoredGoals + c2.ScoredGoals;
            return temp;
        }

        #endregion

        #region comparators
        public static bool operator >(Score left, Score right)
        {
            return Comparer<Score>.Default.Compare(left, right) > 0;
        }

        public static bool operator <=(Score left, Score right)
        {
            return Comparer<Score>.Default.Compare(left, right) <= 0;
        }

        public static bool operator >=(Score left, Score right)
        {
            return Comparer<Score>.Default.Compare(left, right) >= 0;
        }
        public static bool operator <(Score left, Score right)
        {
            return Comparer<Score>.Default.Compare(left, right) < 0;
        }
        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            return obj is Score other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Score)}");
        }

        public int CompareTo(Score other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var scoredGoalsComparison = _scoredGoals.CompareTo(other._scoredGoals);
            if (scoredGoalsComparison != 0) return scoredGoalsComparison;
            return _missedGoals.CompareTo(other._missedGoals);
        }

        #endregion

        #region  equality
        public static bool operator ==(Score left, Score right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Score left, Score right)
        {
            return !Equals(left, right);
        }

        public bool Equals(Score other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _scoredGoals == other._scoredGoals && _missedGoals == other._missedGoals;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Score)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_scoredGoals, _missedGoals);
        }

        #endregion
    }
}
