using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0602_RepositoryPattern_Repository
{
   public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfConten = new List<StreamingContent>();
        //Create 
        public void AddContentList(StreamingContent content)
        {
            _listOfConten.Add(content);//_listofContent  is a filed 
        }
        //Read
        public List<StreamingContent> GetContetList()
        {
            return _listOfConten;
        }

        //Update
        public bool UpdateExistingContent(string orginalTitle, StreamingContent newContent)
        {
            //Find the Content
            StreamingContent oldContent = GetContentByTitle(orginalTitle);

            //Update the content
            if (oldContent != null)
            {
                
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.StarRating = newContent.StarRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.TypeOfGener = newContent.TypeOfGener;
                return true;
                
            }
            else
            {
                return false;
            }
        }
        //Delete

        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);
            if (content==null)
            {
                return false;
            }
            int initialCount = _listOfConten.Count;
            _listOfConten.Remove(content);

            if (initialCount>_listOfConten.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper Method
        private StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfConten)
            {
                if (content.Title == title)
                {
                    return content;
                }
            }
            
            return null;
        }

    }
}
