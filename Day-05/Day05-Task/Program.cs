//namespace Day05_Task
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create a new School instance
//            School school = new School();

//            // Create students
//            Student student1 = new Student() { ID = 1, Name = "Alice" };
//            Student student2 = new Student() { ID = 2, Name = "Bob" };

//            // Add students to the school
//            school.AddStudent(student1);
//            school.AddStudent(student2);

//            // Create courses
//            Course course1 = new Course() { Name = "Math", Instructor = "Prof. Smith" };
//            Course course2 = new Course() { Name = "Science", Instructor = "Prof. Johnson" };

//            // Add courses to the school
//            school.AddCourse(course1);
//            school.AddCourse(course2);

//            // Enroll students in courses
//            student1.EnrollInCourse(course1);
//            student1.EnrollInCourse(course2);
//            student2.EnrollInCourse(course2);


//            // Enrolling students in courses
//            school.EnrollStudentInCourse(1, "Math");
//            school.EnrollStudentInCourse(1, "Science");
//            school.EnrollStudentInCourse(2, "Science");


//            // Displaying all students and their details
//            school.DisplayAllStudents();
//        }
//    }
//}


// ==============================================================

namespace Day05_Task;
public class Program
{
    static void Main()
    {
        bool repeat = true;
        do
        {
            // Create a new School instance
            School school = new School();

            // Prompt user for password
            Console.Write("Enter password to add predefined courses (or press Enter to skip): ");
            string password = Console.ReadLine();

            if (password == "fady11112000")
            {
                // Display options to add courses or add students
                int choice;
                do
                {
                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("1. Add predefined courses");
                    Console.WriteLine("2. Add new course");
                    Console.WriteLine("3. Add students");
                    Console.WriteLine("4. Display students");
                    Console.Write("Enter your choice: ");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                // Add predefined courses to the school
                                AddPredefinedCourses(school);
                                break;
                            case 2:
                                // Add new course
                                AddNewCourse(school);
                                break;
                            case 3:
                                // Add students
                                AddStudentsManually(school);
                                break;
                            case 4:
                                // Display all students
                                school.DisplayAllStudents();
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number.");
                    }
                } while (choice != 4);
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                // Display all students
                school.DisplayAllStudents();
            }
            else
            {
                Console.WriteLine("Incorrect password.");
            }

            // Prompt user if they want to repeat
            Console.Write("Do you want to repeat? (yes/no): ");
            string repeatInput = Console.ReadLine();
            repeat = repeatInput.ToLower() == "yes";
        } while (repeat);
    }

    // Method to add predefined courses
    static void AddPredefinedCourses(School school)
    {
        // Define some predefined courses
        Course[] predefinedCourses = {
            new Course() { Name = "Math", Instructor = "Prof. Smith" },
            new Course() { Name = "Science", Instructor = "Prof. Johnson" }
        };

        // Add predefined courses to the school
        foreach (var course in predefinedCourses)
        {
            school.AddCourse(course);
        }
        Console.WriteLine("Predefined courses added successfully.");
    }

    // Method to add new course
    static void AddNewCourse(School school)
    {
        Console.Write("Enter course name: ");
        string courseName = Console.ReadLine();
        Console.Write("Enter instructor: ");
        string instructor = Console.ReadLine();
        Course course = new Course() { Name = courseName, Instructor = instructor };
        school.AddCourse(course);
        Console.WriteLine($"Course '{courseName}' added successfully.");
    }

    // Method to add students manually
    static void AddStudentsManually(School school)
    {
        // Get the number of students from the user
        Console.Write("\nEnter the number of students: ");
        int numberOfStudents;
        if (int.TryParse(Console.ReadLine(), out numberOfStudents))
        {
            // Get student details from the user
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine();
                Student student = new Student() { ID = i + 1, Name = studentName };
                school.AddStudent(student);

                // Enroll the student in courses
                Console.WriteLine("Available Courses:");
                school.DisplayAllCourses();
                Console.WriteLine("Enter the course name to enroll in (or type 'done' to finish):");
                string courseName;
                do
                {
                    Console.Write("Course name: ");
                    courseName = Console.ReadLine();
                    if (courseName.ToLower() != "done")
                    {
                        // Enroll the student in the course
                        school.EnrollStudentInCourse(student.ID, courseName);
                    }
                } while (courseName.ToLower() != "done");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for number of students.");
        }
    }
}

