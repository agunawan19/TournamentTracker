using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class Matchup
    {
        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>
        public List<MatchupEntry> Entries { get; set; } = new List<MatchupEntry>();

        /// <summary>
        /// The winner of the match
        /// </summary>
        public Team Winner { get; set; }

        /// <summary>
        /// Which round this match is a part of.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
