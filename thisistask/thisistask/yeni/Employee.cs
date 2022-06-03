using System;
using System.Collections.Generic;
using System.Text;

namespace thisistask.yeni
{
    class Employee
    {

        public string Name;
        public string Surname;
        public int Salary;

        public void SetName(string name)
        {
            for(int i =0; i < name.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(name) && HasDigit1(name) && HasUpper1(name))
                {

                    Name = name;
                }


            }
        }
        public void SetSurname(string surname)
        {
            for (int i = 0; i < surname.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(surname) && !string.IsNullOrEmpty(surname) && HasDigit2(surname) && HasUpper2(surname))
                {

                    Surname = surname;
                }


            }
        }
        public void SetSalary(int salary)
        {
            if (salary >= 250)
            {
                Salary = salary;
            }
        }

        public bool HasDigit1(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i])) ;
                return false;

            }
            return true;


        }
        public bool HasUpper1(string name)
        {
            bool check = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i])) ;
                check = true;
                break;

            }
            return check;


        }
        public bool HasDigit2(string surname)
        {
            for (int i = 0; i < surname.Length; i++)
            {
                if (char.IsDigit(surname[i])) ;
                return false;

            }
            return true;


        }
        public bool HasUpper2(string surname)
        {
            bool check = false;
            for (int i = 0; i < surname.Length; i++)
            {
                if (char.IsDigit(surname[i]));
                check = true;
                break;

            }
            return check;


        }

        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public int GetSalary()
        {
            return Salary;
        }








    }
}
