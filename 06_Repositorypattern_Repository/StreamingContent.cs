using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repositorypattern_Repository
{
    public enum GenerType
    {
        Horror=1,
        RomCom,
        SciFic,
        Documenttary,
        Bromance,
        Drama,
        Action

    }
    public class StreamingContent
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating   { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenerType TypeOfGener { get; set; }

        public StreamingContent() { }

        public StreamingContent(string title,string description,string maturityRating, double starRatiing,bool isFamilyFriendly, GenerType gener)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRatiing;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGener = gener;

        }
    }
}
