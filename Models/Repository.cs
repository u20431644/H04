using System.Collections.Generic;

namespace WebApplication2.Models
{
    public static class Repository
    {
        public static readonly List<BlogEntry> BlogEntries = new List<BlogEntry>
        {
            new BlogEntry{BlogentryIDs = 1, blogHeadings="The early years!", blogDescriptions="The Energy Development Group (EDG) – forerunner to SEA – " +
                "was set up in 1993 and provided input into the energy arena in the early years by bringing issues of development, poverty and alternative " +
                "energy into the picture."},
            new BlogEntry{BlogentryIDs = 2, blogHeadings="Early 2000 to present, SEA Formed", blogDescriptions="Sustainable Energy Africa (SEA) was established as a non-profit organisation." +
                "The energy-intensive urban areas were identified as a strategic focus of the new organisation because of their importance in addressing development and climate-related energy issues."},
            new BlogEntry{BlogentryIDs = 3, blogHeadings="Building Capacity and developing strategies", blogDescriptions="SEA’s Sustainable Energy for Environment and " +
                "Development (SEED) Programme gained momentum as the first nationwide urban energy learning network and capacity building programme. " +
                "It deployed and supported energy advisors within several cities, several of whom now hold key government positions."},
            new BlogEntry{BlogentryIDs = 4, blogHeadings="Implementation and the building of an urban energy platform amongst local and national stakeholder",
                blogDescriptions="A City Energy Support Unit was established to drive the new and challenging area of implementation of strategy commitments " +
                "and the development of a national Urban Energy Platform. The scope has included vertical engagement with provincial and national government, " +
                "policy participation, the development of provincial energy strategies and a role in the low carbon chapter of the National Development Plan."},
            new BlogEntry{BlogentryIDs = 5, blogHeadings="Reinvigorating the urban energy poverty dialogue", blogDescriptions="Energy poverty has always been at the " +
                "core of SEA’s work, particularly in the area of sustainable housing and energy services development. SEA has researched key elements of urban energy " +
                "poverty, and incorporates pro-poor measures into its city and national service delivery frameworks."},
            new BlogEntry{BlogentryIDs = 6, blogHeadings="Extending the capacity development model further into Africa", blogDescriptions="A partnership with Ghana, Uganda and UK support " +
                "agencies is now expandingour approach into developing African cities."},
            new BlogEntry{BlogentryIDs = 7, blogHeadings="SEA Continues to extend it's reach into sub-Saharan Africa. Under the Covenant of the Mayors Programme!",
                blogDescriptions="SEA builds capacity within African cities using knowledge transfer and technical assistance to develop strategy plans."},
            new BlogEntry{BlogentryIDs = 8, blogHeadings="The future of SEA", blogDescriptions="To continue growing the organisation into Africa to redress energy poverty" +
                "in multiple countries, to provide a safe an accessible platform to energy dialogue between relevant parties and to ensure progress is made!"},
        };

        public static readonly List<CurrentProject> currentProjects = new List<CurrentProject>
        {
            new CurrentProject{Projnames = "Supporting Sustainable energy in South African Municipalities (SSESAM)",
                Url="https://www.sustainable.org.za",
                description="Promoting sustainable energy in municiplaities, focusing on renewable energy and energy efficiency",
                section="Energy Poverty" },
            new CurrentProject{Projnames = "Mobilizing Social Movements for Energy Democracy and Sovereignty in South Africa: Towards socially owned renewable energy solutions",
                Url="https://www.sustainable.org.za",
                description="The project aims to strengthen social and environmental justice movements for democratic engagement and to partner with municipalities and relevant entities " +
                "so as to lead to the installation and operation of community-led, socially owned renewable energy.",
                section="Energy Poverty" },
             new CurrentProject{Projnames = "City of Johannesburg EV Readiness Support Programme: Phase 2",
                Url="https://www.sustainable.org.za",
                description="The Johannesburg Electric Vehicle (EV) Readiness Programme phase 2, funded by UK PACT (Partnering for Accelerated Climate Transitions)," +
                 " aims to deepen the capacity of key stakeholders in the City of Johannesburg to accelerate the transition to electric mobility, while also learning from, and sharing learnings with, the City of Cape Town",
                section="Planning and Mobility" },
             new CurrentProject{Projnames = "Mobilizing Social Movements for Energy Democracy and Sovereignty in South Africa: Towards socially owned renewable energy solutions",
                Url="https://www.sustainable.org.za",
                description="The project aims to strengthen social and environmental justice movements for democratic engagement and to partner with municipalities and relevant entities",
                section="Sustainable Energy Development" },
             new CurrentProject{Projnames = "Supporting Sustainable energy in South African Municipalities (SSESAM)",
                Url="https://www.sustainable.org.za",
                description="Promoting sustainable energy in municiplaities, focusing on renewable energy and energy efficiency",
                section="Sustainable Energy Development" },
        };

        public static readonly List<CompletedProject> completedProjects = new List<CompletedProject>
        {
            new CompletedProject{Projnames = "Municipal Sustainable Energy Transition Support Programme (MSETS)",
                Url="https://www.sustainable.org.za",
                description="Promoting sustainable energy in municipalities, focusing on renewable energy.",
                section="Energy Poverty" },
            new CompletedProject{Projnames = "Providing training for municipalities to implement the mitigation component of the Let’s Respond Toolkit",
                Url="https://www.sustainable.org.za",
                description="The project’s objective is to facilitate capacity building workshops for local government on climate change mitigation.",
                section="Energy Poverty" },
             new CompletedProject{Projnames = "Urban Transformation in South Africa Through Co-Designing Energy Services Provision Pathways",
                Url="https://www.sustainable.org.za",
                description="The project will focus on co-designing context sensitive energy provision pathways"
                ,section="Energy Poverty"}, 
             new CompletedProject{Projnames = "KZN GHG Mitigation Opportunities",
                Url="https://www.sustainable.org.za",
                description="The programme aims to help regions in developing and newly industrialized countries to better understand the mitigation opportunities presented by their climate change emissions.",
                 section="Planning and Mobility"},
             new CompletedProject{Projnames = "KZN GHG Mitigation Opportunities)",
                Url="https://www.sustainable.org.za",
                description="Promoting sustainable energy in municiplaities, focusing on renewable energy and energy efficiency",
                section="Sustainable Energy Development"},
        };

        public static readonly List<FutureProject> futureProjects = new List<FutureProject>
        {
            new FutureProject{Projnames="Western Cape Independent power provider changeover",
            Url="test1",
            description="tEnsuring clean energy is available to all and readily available to use!",
            section="Sustainable Energy development",
            CompletionDate="2024"},
            new FutureProject{Projnames="Western Cape - Increasing sustainable energy capacity at a municipal level",
            Url="test1",
            description="Onboarding of more capacity in terms of Independent power producers, with specific focus on sustainable energy!",
            section="Sustainable Energy development",
            CompletionDate="2025"},
        };
    }
}



