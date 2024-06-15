using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strike_Showdown_Back_End.Models
{
    public class MatchScoresModel
    {
        public int ID { get; set; }
        public int PostID { get; set; } 
        public int UserID { get; set; }
        public int ScoreOne { get; set; }
        public int ScoreTwo { get; set; }
        public bool IsValid { get; set; }

        public MatchScoresModel()
        {
        }
    }
}