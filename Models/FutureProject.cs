using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Models
{   //Derived from Project
    public class FutureProject : Project
    {
        private string completionDate { get; set; }
        public FutureProject()
        {

        }
        
        public override string getDescription()
        {
            return description;
        }
        public override string getSection()
        {
            return section;
        }

        public override string getProjname()
        {
            return base.getProjname();
        }

        public override string getURL()
        {
            return base.getURL();
        }

        public string getCompletionDate()
        {
            return completionDate;
        }

        public string CompletionDate
        {
            get { return completionDate; }
            set { completionDate = value; }
        }

        public static void Main()
        {
            List<CompletedProject> list = new List<CompletedProject>();
            //list.Add(new CurrentProject 
            //{
            //    projname="test1", 
            //    description="test1", 
            //    url="www.test.co.za",
            //    section="section1"});
            //list.Add(new CurrentProject
            //{
            //    projname = "test2",
            //    description = "test2",
            //    url = "www.test.co.za",
            //    section = "section2"
            //});
            //list.Add(new CurrentProject
            //{
            //    projname = "test3",
            //    description = "test3",
            //    url = "www.test.co.za",
            //    section = "section1"
            //});

            var query = list.GroupBy(x => x.section);
            foreach (var result in query)
            {
                Console.WriteLine(result.Key);

                foreach (var person in result)
                    Console.WriteLine(person.description);
            }
        }
    }


}