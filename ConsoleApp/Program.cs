using System;
using System.Collections.Generic;
using StudentsClass;
using System.Linq;

namespace DemoList
{
    class Program
    {
        static void Main()
        {
            int id = 1;

            List <Student> SA = new List<Student>();//Student List for Division A Students
            List<Student> SB = new List<Student>();//Student List for Division A Students
            List<Student> students = new List<Student>();//Student List for total Students merged list

            Console.WriteLine("Enter the name of Students from Division A");
            Accept(SA);//Calling accept function for div A

            Console.WriteLine("Enter the name of Students from Division B");
            Accept(SB);//Calling accept function for div B

            Console.WriteLine("\nDetails of Students from Division A");
            Display(SA);//Calling display function for div A

            Console.WriteLine("\nDetails of Students from Division B");
            Display(SB);//Calling display function for div A

            Student temp = new Student();//New Student created for insertion  
            temp.Id = id++;
            temp.Name = "Jhon";
            temp.Division = 'A';

            SA.Insert(3,temp);
            Console.WriteLine("\nDetails of Students from Division A after 'John' is inserted");//Details of Student list A after 'Insert'
            Display(SA);

            SA.Sort();
            Console.WriteLine("\nSorted Details of Students from Division A");//Details of Student list A after 'Sort'
            Display(SA);

            Console.WriteLine("Total Students : {0}",SA.Count());//Count of Students from A div 

            Console.WriteLine("\nDetails of Students from Division A after 'John' is removed");//Removed record 'Jhon' from div A list
            SA.RemoveAt(4);
            Display(SA);//Details of Student list A after 'Sort'

            SwapStudents(SA,SB,2,1);//Swapping 3nd student of Div A with 2nd student of Div B
            Console.WriteLine("\nDivisions after Swaping :");
            
            Console.WriteLine("\nDetails of Students from Division A");
            Display(SA);//Details of Student list A after 'Swap'

            Console.WriteLine("\nDetails of Students from Division B");
            Display(SB);//Details of Student list B after 'Swap'

            Console.WriteLine("\nDetails of all Students from both Divisions");
            students.AddRange(SA);
            students.AddRange(SB);
            Display(students);

            Console.ReadLine();

            void Accept(List<Student> S2)//Function to Accept details of students
            {
                char division;
                if(S2==SA)
                {
                    division = 'A';
                }

                else 
                {
                    division = 'B';
                }

                for (int i = 1; i < 5; i++)
                {
                    Student s = new Student();
                    Console.WriteLine("Roll No {0} : ", id);
                    s.Name = Console.ReadLine();
                    s.Division = division;
                    s.Id = id;
                    id++;
                    S2.Add(s);
                }
            }

            void Display(List<Student> S1)//Function to Display details of students
            {
                S1.ForEach(c => Console.WriteLine("{0} : {1} : {2}",c.Division, c.Id, c.Name));
            }

            void SwapStudents(List<Student> S1,List<Student> S2,int id1,int id2)////Function to swap students
            { 
                if (S1.Count!=S2.Count)
                {
                    Console.WriteLine("Size of the two list differs...Cannot swap");
                    return;
                }

                if((id1>S1.Count)&&(id2>S2.Count))
                {
                    Console.WriteLine("Position out of bound...Cannot swap");
                    return;
                }

                temp.Name = S1[id1].Name;
                temp.Id = S1[id1].Id;

                S1[id1].Name = S2[id2].Name;
                S1[id1].Id = S2[id2].Id;
                S1[id1].Division = 'A';

                S2[id2].Name = temp.Name;
                S2[id2].Id = temp.Id;
                S2[id2].Division = 'B';
            }
        }
    }
}
