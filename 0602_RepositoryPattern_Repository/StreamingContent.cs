using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0602_RepositoryPattern_Repository
{
    //Plain old C# Object---POCO
        public enum GenerType
     {
        Horror=1,
        RomCom,
        SciFi,
        Documentary,
        Bromance,
        Drama,
        Action
     }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenerType TypeOfGener { get; set; }
        public StreamingContent() { }
        public StreamingContent(string title,string description,string maturityRating,double rating,bool friendly, GenerType gener )
        {
            Title = title;
            Description=description;
            MaturityRating = maturityRating;
            StarRating= rating;
            IsFamilyFriendly = friendly;
            MaturityRating = maturityRating;
            TypeOfGener= gener;
            

        }

    }
}
