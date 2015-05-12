using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Human_Student_Worker
{
    class HumanStudentWorker
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", "1200e"));
            students.Add(new Student("Pesho", "Ivanov", "13002"));
            students.Add(new Student("Petko", "Ivanov", "14002"));
            students.Add(new Student("Georgi", "Ivanov", "12200"));
            students.Add(new Student("Misho", "Ivanov", "200we3"));
            students.Add(new Student("Dimitar", "Ivanov", "220e2"));
            students.Add(new Student("Petya", "Ivanova", "1021e"));
            students.Add(new Student("Ivana", "Ivanova", "11200"));
            students.Add(new Student("Viktoria", "Ivanova", "4200q"));
            students.Add(new Student("Milka", "Ivanova", "123q1"));
            List<Student> studentSortdedList = students.OrderBy(o=>o.FaultyNumber).ToList();
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Petrov", 200, 8));
            workers.Add(new Worker("Pesho", "Petrov", 100, 6));
            workers.Add(new Worker("Petko", "Petrov", 300, 3));
            workers.Add(new Worker("Georgi", "Petrov", 500, 8));
            workers.Add(new Worker("Misho", "Petrov", 100, 4));
            workers.Add(new Worker("Dimitar", "Petrov", 0, 7));
            workers.Add(new Worker("Petya", "Petrova", 50, 6));
            workers.Add(new Worker("Ivana", "Petrova", 120, 8));
            workers.Add(new Worker("Viktoria", "Petrova", 70, 8));
            workers.Add(new Worker("Milka", "Petrova", 2000, 6));
            List<Worker> workerSortedList = workers.OrderByDescending(o => o.MoneyPerHour(o.WeekSalary, o.WorkHoursPerDay)).ToList();
            var result = workerSortedList.Cast<Human>().Concat(studentSortdedList.Cast<Human>());
            result = result.OrderBy(o => o.FirstName);
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}