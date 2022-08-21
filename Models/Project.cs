using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{

    //base class
    public abstract class Project
    {
        private string projname { get; set; } //encapsulation
        private string url { get; set; } //encapsulation
        public string description { get; set; }
        public string section { get; set; }

        public Project()
        {

        }

        //public abstract string getProjname();

        //public abstract string getUrl();

        public abstract string getDescription();

        public abstract string getSection();

        public virtual string getProjname()
        {
            return projname;
        }

        public virtual string getURL()
        {
            return url;
        }

        public string Projnames
        {
            get { return projname; }
            set { projname = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}