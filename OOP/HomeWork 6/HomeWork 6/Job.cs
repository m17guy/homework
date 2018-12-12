using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    class Job
    {
        public string name;
        public string descripton;
        public double salary;
        public int vacationdays;
        public Job()
        {
            void promotion(double newsalary)
            {
                if(newsalary>salary)
                    salary = newsalary;
                //salary = (newsalary > salary) ? newsalary : salary;
            }
            void takevacation(int days)
            {
                if (vacationdays > days)
                    vacationdays -= days;
                //vacationdays = (vacationdays > days) ? (vacationdays - days) : vacationdays;
            }
        }
    }
}
