using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAss1
{

    class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        public HireDate(int day, int month, int year)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("invalid month");

            if (year < 1920 || year > DateTime.Now.Year)
                throw new ArgumentException("invalid year");

            int maxDays = DateTime.DaysInMonth(year, month);

            if (day < 1 || day > maxDays)
                throw new ArgumentException($"invalid day: {day} is not valid for month {month} and year {year}");

            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    } 
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    enum Gender
    {
        M,
        F
    }

    
    class Employee
    {

        public int id {  get; set; }
        public string name {  get; set; }
        public SecurityLevel securityLevel { get; set; }
        public decimal salary { get; set; }
        public HireDate hireDate { get; set; }
        public Gender gender { get; set; }



        public Employee(int _id, string _name, SecurityLevel _securityLevel, decimal _salary, HireDate _hireDate, Gender _gender)
        {
            id = _id;
            name = _name;
            securityLevel = _securityLevel;
            salary = _salary >= 0 ? _salary : throw new ArgumentException("Salary cannot be negative");
            hireDate = _hireDate;
            gender = _gender;
        }

        public override string ToString()
        {
            return $"id: {id}, name: {name}, gender: {gender}, security level: {securityLevel}, " +
                   $"salary: {string.Format(CultureInfo.CurrentCulture, "{0:C}", salary)}, hire date: {hireDate}";
        }

    }
}
