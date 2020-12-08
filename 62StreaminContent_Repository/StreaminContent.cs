using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62StreaminContent_Repository
{
    public enum GenreType
    {
        Horror=1,
        RoCom,
        Documentary,
        SciFi,
        Romance,
        Drama,
        Action
    }
    public class StreaminContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating  { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGener { get; set; }


        public StreaminContent() { }
        public StreaminContent(string title,string description,string maturityRating,double starRating,bool isFamilyFriendly,GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGener = genre;

        }
    }
   
}
