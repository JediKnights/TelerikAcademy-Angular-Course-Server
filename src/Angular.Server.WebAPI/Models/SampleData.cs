namespace Angular.Server.WebAPI.Models
{
    using System.Collections.Generic;

    public static class SampleData
    {
        public static List<User> LoadUsers()
        {
            var users = new List<User>()
            {
                new User() { Id = 1, Name = "John Doe" },
                new User() { Id = 2, Name = "Mike Murphy"},
                new User() { Id = 3, Name = "Kevin Spacey"},
                new User() { Id = 4, Name = "Daniel Donovan"}
            };

            return users;
        } 
    }
}
