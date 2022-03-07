using System;

namespace StudentAndTeacherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Greet();
            myPerson.SetAge(21);

            Student myStudent = new Student();
            myStudent.ShowAge();
            myStudent.Greet();
            myStudent.Study();
            myStudent.SetAge(35);


            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(53);
            myTeacher.Greet();
            myTeacher.Explain();
            myTeacher.Greet();

        }
    }
}
