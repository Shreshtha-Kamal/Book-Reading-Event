using DataAccessLayer.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class UserDataConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
                        (
                            new User { UserID = 1, FullName = "Carson Alexander", Email = "carson@gmail.com", Password = "carson@" },
                            new User { UserID = 2, FullName = "Meredith Alonso", Email = "meredith@gmail.com", Password = "meredith!" },
                            new User { UserID = 3, FullName = "Arturo Anand", Email = "arturo@yahoo.com", Password = "arturo@" },
                            new User { UserID = 4, FullName = "Yan Li", Email = "yanli@rediff.com", Password = "yanli#" },
                            new User { UserID = 5, FullName = "Peggy Justice", Email = "peggy@gmail.com", Password = "peggy!" },
                            new User { UserID = 6, FullName = "Nino Olivetto", Email = "nino.olivetto@gmail.com", Password = "nino@!" },
                            new User { UserID = 7, FullName = "Lomen Norman", Email = "lomen@gmail.com", Password = "larson@" }
                        );
        }
    }

    public class EventDataConfiguration : IEntityTypeConfiguration<Event>
    {
        void IEntityTypeConfiguration<Event>.Configure(EntityTypeBuilder<Event> builder)
        {
            

            builder.HasData
            (
                new Event { EventID = 1, Title = "Node Js", Date = System.DateTime.Parse("2021-08-31"), Location = "India", StartTime = "09:00", Type = "Public", DurationInHours = 1, Description = "", OtherDetails = "", InviteByEmail = "lonely@gmail.com", UserID = 1 },
                new Event { EventID = 2, Title = "Java Quiz", Date = System.DateTime.Parse("2017-06-15"), Location = "America", StartTime = "12:00", Type = "Public", DurationInHours = 2, Description = "", OtherDetails = "", InviteByEmail = "yanli@rediff.com,arturo@yahoo.com", UserID = 1 },
                new Event { EventID = 3, Title = "Level Up", Date = System.DateTime.Parse("2021-10-01"), Location = "New Delhi", StartTime = "08:00", Type = "Private", DurationInHours = 2, Description = "", OtherDetails = "", InviteByEmail = "carson@gmail.com,baroliya@nagarro.com", UserID = 2 },
                new Event { EventID = 4, Title = "Altered Images", Date = System.DateTime.Parse("2020-12-05"), Location = "London", StartTime = "11:00", Type = "Public", DurationInHours = 2, Description = "", OtherDetails = "", InviteByEmail = "", UserID = 2 },
                new Event { EventID = 5, Title = "Josh Clapham Memorial Show", Date = System.DateTime.Parse("2019-01-30"), Location = "Germany", StartTime = "10:00", Type = "Private", DurationInHours = 4, Description = "", OtherDetails = "", InviteByEmail = "arturo@yahoo.com", UserID = 3 },
                new Event { EventID = 6, Title = "The Doors Alive", Date = System.DateTime.Parse("2021-06-12"), Location = "New York", StartTime = "16:00", Type = "Private", DurationInHours = 3, Description = "", OtherDetails = "", InviteByEmail = "yanli@rediff.com", UserID = 8 },
                new Event { EventID = 7, Title = "Easter Concert", Date = System.DateTime.Parse("2021-09-11"), Location = "Sydeny,Australia", StartTime = "18:00", Type = "Private", DurationInHours = 4, Description = "", OtherDetails = "", InviteByEmail = "", UserID = 3 },
                new Event { EventID = 8, Title = "Mental Health Conference", Date = System.DateTime.Parse("2019-05-07"), Location = "Delhi", StartTime = "13:00", Type = "Public", DurationInHours = 1, Description = "", OtherDetails = "", InviteByEmail = "anie@nagarro.com", UserID = 3 },
                new Event { EventID = 9, Title = "Propaganda Live Tour", Date = System.DateTime.Parse("2017-03-21"), Location = "Texas,USA", StartTime = "01:00", Type = "Private", DurationInHours = 3, Description = "", OtherDetails = "", InviteByEmail = "nino.olivetto@gmail.com", UserID = 4 },
                new Event
                {
                    EventID = 10,
                    Title = "Learn AI In 60 Minutes",
                    Date = System.DateTime.Parse("2021-01-11"),
                    Location = "California",
                    StartTime = "06:00",
                    Type = "Public",
                    DurationInHours = 1,
                    Description = "We’ve received demand to host online workshop.",
                    OtherDetails = "In response to this demand, A.I." +
                " For Anyone is excited to host a Learn AI in 60 Minutes virtual workshop in partnership with the Mark Cuban Foundation.",
                    InviteByEmail = "",
                    UserID = 8
                },
                new Event { EventID = 11, Title = "Learn Python", Date = System.DateTime.Parse("2020-06-17"), Location = "Mumbai", StartTime = "04:00", Type = "Public", DurationInHours = 1, Description = "", OtherDetails = "", InviteByEmail = "lonely@gmail.com,baroliya@nagarro.com", UserID = 7 },
                new Event { EventID = 12, Title = "Tech Fest", Date = System.DateTime.Parse("2021-06-15"), Location = "Gurgaon", StartTime = "05:00", Type = "Public", DurationInHours = 4, Description = "", OtherDetails = "", InviteByEmail = "yanli@rediff.com,arturo@yahoo.com", UserID = 7 },
                new Event { EventID = 13, Title = "Online Quiz", Date = System.DateTime.Parse("2022-10-01"), Location = "New Delhi", StartTime = "08:00", Type = "Private", DurationInHours = 3, Description = "", OtherDetails = "", InviteByEmail = "carson@gmail.com", UserID = 8 },
                new Event { EventID = 14, Title = "Year Book", Date = System.DateTime.Parse("2016-12-05"), Location = "Ghaziabad", StartTime = "14:00", Type = "Public", DurationInHours = 2, Description = "", OtherDetails = "", InviteByEmail = "", UserID = 8 },
                new Event { EventID = 15, Title = "Memorial Show", Date = System.DateTime.Parse("2015-01-30"), Location = "Shahdara", StartTime = "21:00", Type = "Private", DurationInHours = 4, Description = "", OtherDetails = "", InviteByEmail = "arturo@yahoo.com,baroliya@nagarro.com", UserID = 3 }

            );  
            
        }
    }
    public class CommentDataConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData
                        (
                            new Comment { CommentID = 1, Comments = "Nice Event...!", DateTime = System.DateTime.Parse("2020-09-30"), EventID = 1 },
                            new Comment { CommentID = 2, Comments = "I like it...!", DateTime = System.DateTime.Parse("2020-10-11"), EventID = 1 },
                            new Comment { CommentID = 3, Comments = "Superb Event", DateTime = System.DateTime.Parse("2020-09-27"), EventID = 2 },
                            new Comment { CommentID = 4, Comments = "Great...", DateTime = System.DateTime.Parse("2018-10-05"), EventID = 2 },
                            new Comment { CommentID = 5, Comments = "Nice", DateTime = System.DateTime.Parse("2020-01-01"), EventID = 2 },
                            new Comment { CommentID = 6, Comments = "Thanks for it.", DateTime = System.DateTime.Parse("2020-11-01"), EventID = 1 },
                            new Comment { CommentID = 7, Comments = "Gazab..(`.`)", DateTime = System.DateTime.Parse("2019-06-16"), EventID = 5 },
                            new Comment { CommentID = 8, Comments = "Cool Event", DateTime = System.DateTime.Parse("2019-01-31"), EventID = 5 },
                            new Comment { CommentID = 9, Comments = "You are Great", DateTime = System.DateTime.Parse("2019-07-11"), EventID = 8 },
                            new Comment { CommentID = 10, Comments = "Waiting for it...", DateTime = System.DateTime.Parse("2020-03-08"), EventID = 6 },
                            new Comment { CommentID = 11, Comments = "Super cool", DateTime = System.DateTime.Parse("2020-02-27"), EventID = 9 },
                            new Comment { CommentID = 12, Comments = "Nice Event...!", DateTime = System.DateTime.Parse("2019-09-30"), EventID = 8 },
                            new Comment { CommentID = 13, Comments = "Very interesting", DateTime = System.DateTime.Parse("2020-01-31"), EventID = 8 },
                            new Comment { CommentID = 14, Comments = "Nice Event...!", DateTime = System.DateTime.Parse("2019-06-09"), EventID = 9 },
                            new Comment { CommentID = 15, Comments = "Cool", DateTime = System.DateTime.Parse("2018-05-01"), EventID = 9 }
                        );
        }
    }
}
