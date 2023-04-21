using System.Collections.Generic;

namespace HW.Models
{
    public class Data
    {
        public static List<Service> Services = new List<Service>
        {
            new Service {Id = 1, Title = "Lorem Ipsum", Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",
            Icon = "<i class=\"bx bxl-dribbble\"></i>"},
            new Service {Id = 2, Title = "Lorem Ipsum", Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",
            Icon = "<i class=\"bx bxl-dribbble\"></i>"},
            new Service {Id = 3, Title = "Lorem Ipsum", Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",
            Icon = "<i class=\"bx bxl-dribbble\"></i>"},
            new Service {Id = 4, Title = "Lorem Ipsum", Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",
            Icon = "<i class=\"bx bxl-dribbble\"></i>"},
            new Service {Id = 5, Title = "Lorem Ipsum", Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",
            Icon = "<i class=\"bx bxl-dribbble\"></i>"},
            new Service {Id = 6, Title = "Lorem Ipsum", Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",
            Icon = "<i class=\"bx bxl-dribbble\"></i>"},
        };

        public static List<Team> Teams = new List<Team>
        {
            new Team {Id = 1, Title = "Sarah Jhonson", Description ="Product Manager", Image = "team-1.jpg"},
            new Team {Id = 2, Title = "Sarah Jhonson", Description ="Chief Executive Officer", Image = "team-2.jpg"},
            new Team {Id = 3, Title = "Sarah Jhonson", Description ="CTO", Image = "team-3.jpg"},
            new Team {Id = 4, Title = "Sarah Jhonson", Description ="Accountant", Image = "team-4.jpg"},
        };
    }
}
