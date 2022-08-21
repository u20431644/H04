using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BlogEntry
    {
        private int BlogentryID { get; set; }
        private string blogHeading { get; set; }
        private string blogDescription { get; set; }

        public BlogEntry()
        {

        }

        //public virtual int getBlogEntryID()
        //{
        //    return BlogentryID;
        //}

        //public virtual string getBlogHeading()
        //{
        //    return blogHeading;
        //}

        //public virtual string getblogDescription()
        //{
        //    return blogDescription;
        //}

        public int BlogentryIDs
        {
            get { return BlogentryID; }
            set { BlogentryID = value; }
        }

        public string blogHeadings
        {
            get { return blogHeading; }
            set { blogHeading = value; }
        }

        public string blogDescriptions
        {
            get { return blogDescription; }
            set { blogDescription = value; }
        }

        //public BlogEntry (int blogentryID, string blogHeading, string blogDescription)
        //{
        //    BlogentryID = blogentryID;
        //    this.blogHeading = blogHeading;
        //    this.blogDescription = blogDescription;
        //}
  
    }
}