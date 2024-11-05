using DIRTBIKESBM.Models;
using System;
using System.Collections.Generic;

public class Seed
{
    public static List<Category> Categories => new List<Category>
    {
        new Category { Id = 1, Name = "Dirt Bikes" },
        new Category { Id = 2, Name = "Enduro Bikes" },
        new Category { Id = 3, Name = "Motocross Bikes" }
    };

    public static List<Motor> Motors => new List<Motor>
    {
        new Motor { Id = 1, Model = "Yamaha YZ450F", Year = 2023, Price = 9499, Description = "High-performance motocross bike.", CategoryId = 1 },
        new Motor { Id = 2, Model = "KTM 450 EXC-F", Year = 2022, Price = 9999, Description = "Versatile and powerful enduro bike.", CategoryId = 2 },
        new Motor { Id = 3, Model = "Honda CRF450R", Year = 2023, Price = 9199, Description = "Lightweight and agile motocross bike.", CategoryId = 1 }
    };

    public static List<Order> Orders => new List<Order>
    {
        new Order { Id = 1, UserId = 1, MotorId = 2, OrderDate = DateTime.Now },
        new Order { Id = 2, UserId = 2, MotorId = 1, OrderDate = DateTime.Now.AddDays(-1) }
    };

    public static List<Review> Reviews => SeedReviews();

    public static List<Reviewer> Reviewers => new List<Reviewer>
    {
        new Reviewer { Id = 1, Name = "John Doe" },
        new Reviewer { Id = 2, Name = "Jane Smith" }
    };

    public static List<User> Users => new List<User>
    {
        new User { Id = 1, Username = "biker123", Email = "biker123@example.com", PasswordHash = "hashed_password_1" },
        new User { Id = 2, Username = "dirtbikefan", Email = "dirtbikefan@example.com", PasswordHash = "hashed_password_2" }
    };

    public static List<UserLoginDto> UserLoginDtos => new List<UserLoginDto>
    {
        new UserLoginDto { Username = "biker123", Password = "password123" },
        new UserLoginDto { Username = "dirtbikefan", Password = "password456" }
    };

    public static List<UserRegistrationDto> UserRegistrationDtos => new List<UserRegistrationDto>
    {
        new UserRegistrationDto { Username = "biker123", Email = "biker123@example.com", Password = "password123" },
        new UserRegistrationDto { Username = "dirtbikefan", Email = "dirtbikefan@example.com", Password = "password456" }
    };

    private static List<Review> SeedReviews()
    {
        return new List<Review>
        {
            new Review { Id = 1, MotorId = 1, ReviewerId = 1, Comment = "Amazing bike, very powerful!", Rating = 5 },
            new Review { Id = 2, MotorId = 2, ReviewerId = 2, Comment = "Great for off-road adventures.", Rating = 4 }
        };
    }

    internal void SeedDataContext()
    {
        throw new NotImplementedException();
    }
}