using System.Linq;
using TechConference.Api.Data.Entities;

namespace TechConference.Data
{
    public static class InitialData
    {
        public static void Seed(this TechConferenceDbContext dbContext)
        {
            // add seeded datatbase on project run or with entity frame code run

            if (!dbContext.Sessions.Any())
            {
                dbContext.Sessions.Add(new Session
                {
                    Title = "Html",
                    Description = "front web development controls.",
                    Room = "Apollo",
                    Day = "Monday",
                    Format = "Online",
                    Level = "Basic",
                });

                dbContext.Sessions.Add(new Session
                {
                    Title = "CSS",
                    Description = "front web development styles.",
                    Room = "Pioneer",
                    Day = "Tuesday",
                    Format = "Offline",
                    Level = "Basic",
                });

                dbContext.Sessions.Add(new Session
                {
                    Title = "Javascript",
                    Description = "front web development programming.",
                    Room = "Pioneer",
                    Day = "Wednesday",
                    Format = "Online",
                    Level = "Basic",
                });

                dbContext.Sessions.Add(new Session
                {
                    Title = "ReactJS",
                    Description = "front web development library.",
                    Room = "Luna",
                    Day = "Monday",
                    Format = "Online",
                    Level = "Basic",
                });

                dbContext.Sessions.Add(new Session
                {
                    Title = "Html",
                    Description = "front web development basic.",
                    Room = "Apollo",
                    Day = "Monday",
                    Format = "Online",
                    Level = "Basic",
                });

                dbContext.Sessions.Add(new Session
                {
                    Title = "c#",
                    Description = "back end programming language",
                    Room = "Ranger",
                    Day = "Monday",
                    Format = "Offline",
                    Level = "Intermediate",
                });

                dbContext.SaveChanges();
            }

            if (!dbContext.Users.Any())
            {
                dbContext.Users.Add(new User
                {
                    Email = "john@gmail.com",
                    Password = "admin@123"

                }); ;

                dbContext.Users.Add(new User
                {
                    Email = "kevin@gmail.com",
                    Password = "admin@123"
                });

                dbContext.Users.Add(new User
                {
                    Email = "david@gmail.com",
                    Password = "admin@123"
                });

                dbContext.SaveChanges();
            }
            }
    }
}
