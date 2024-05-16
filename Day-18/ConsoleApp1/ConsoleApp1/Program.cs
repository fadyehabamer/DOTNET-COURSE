using ConsoleApp1.Data;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentSystemContext())
            {
                Console.WriteLine("Enter course details:");
                var course = new Course
                {
                    Name = ReadString("Course Name: ", maxLength: 80),
                    Description = ReadString("Description (optional): ", optional: true),
                    StartDate = ReadDate("Start Date (yyyy-MM-dd): "),
                    EndDate = ReadDate("End Date (yyyy-MM-dd): "),
                    Price = ReadDecimal("Price: "),
                };
                context.Courses.Add(course);
                context.SaveChanges();

                Console.WriteLine("Enter student details:");
                var student = new Student
                {
                    Name = ReadString("Student Name: ", maxLength: 100),
                    PhoneNumber = ReadString("Phone Number (optional): ", optional: true, maxLength: 10, unicode: false),
                    RegisteredOn = DateTime.Now,
                    Birthday = ReadDate("Birthday (optional, yyyy-MM-dd): ", optional: true)
                };
                context.Students.Add(student);
                context.SaveChanges();

                var studentCourse = new StudentCourse
                {
                    StudentId = student.StudentId,
                    CourseId = course.CourseId
                };
                context.StudentCourses.Add(studentCourse);
                context.SaveChanges();

                Console.WriteLine("Data saved successfully.");
            }
        }

        static string ReadString(string prompt, bool optional = false, int maxLength = int.MaxValue, bool unicode = true)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (optional && string.IsNullOrEmpty(input)) return null;
            } while (input.Length > maxLength || (!unicode && input.Length != input.ToCharArray().Length));
            return input;
        }

        static DateTime ReadDate(string prompt, bool optional = false)
        {
            DateTime date;
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (optional && string.IsNullOrEmpty(input)) return DateTime.MinValue;
            } while (!DateTime.TryParse(input, out date));
            return date;
        }

        static decimal ReadDecimal(string prompt)
        {
            decimal value;
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (!decimal.TryParse(input, out value));
            return value;
        }


    }

}
