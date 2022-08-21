using QuizPortal.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;

namespace QuizPortal.Proxies
{
    public class WiredProxy : IWiredProxy
    {
       private string v = "Place where can show your talent present inside your mind" ; 
        public async Task<ICollection<ArticleDto>> GetLastFiveArticlesAsync()
        {
            /*string url = "https://www.wired.com/feed/rss";

            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();*/

            List<ArticleDto> articleList = new List<ArticleDto>();
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            string[,] names = new string[,] { { "1", "Maths", v }, { "2", "Marvel", v }, { "3", "Python", v }, { "4", "GK", v }, { "5", "DC", v } };
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            /*
                        Dictionary<string, string> fiveFeed = new Dictionary<string, string>
                    {
                            { "Id", "1" },
                             { "Title", "Maths" },
                             {"Summary","A Place where can show your talent present inside your mind" }
                    };*/
            

            for (int x = 0; x < names.GetLength(0); x++)
            {
                ArticleDto articleDto = new ArticleDto();
                for(int y = 0; y < 3; y++)
                {
                    if (y == 0)
                    {
                        articleDto.ArticleId = names[x, y];
                        
                    }
                    else if (y == 1)
                    {
                        articleDto.Title = names[x, y];
                        
                    }
                    else
                    {
                        articleDto.Description = names[x, y];
                        articleList.Add(articleDto);
                       
                    }
#pragma warning disable IDE0059 // Unnecessary assignment of a value

#pragma warning restore IDE0059 // Unnecessary assignment of a value
                }

            }



            /*foreach (var (key, value) in fiveFeed)
    {
        string v = Console.ReadLine();
        int n = int.Parse(v);
        if (key == "Id")
            articleDto.ArticleId = value;
        else if (key == "Title")
            articleDto.Title = value;
        else 
        {
            articleDto.Description = value;
            articleList.Add(articleDto);
        }
    }*/

            /*foreach (SyndicationItem item in fiveFeed)
            {
                var articleDto = new ArticleDto();

                articleDto.ArticleId = item.Id;
                articleDto.Title = item.Title.Text;
                articleDto.Description = item.Summary.Text;
                articleList.Add(articleDto);
            }*/

            return await Task.FromResult(articleList);
        }

        private void print(string v)
        {
            throw new NotImplementedException();
        }
    }
}
