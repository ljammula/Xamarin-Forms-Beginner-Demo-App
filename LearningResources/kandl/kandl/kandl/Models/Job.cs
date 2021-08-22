using kandl.Helpers;
using System.Collections.Generic;

namespace kandl.Models
{
    public class Job
    {
        public string ID { get; set; }
        public string TeamID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }

        public List<string> Tags { get; set; }

        public string FormattedTags
        {
            get
            {
                if (Tags == null)
                {
                    return string.Empty;
                }
                return string.Join(", ", Tags);
            }
        }

        public Job()
        {
            ID = Helper.GetRandomGUID();
        }
    }
}
