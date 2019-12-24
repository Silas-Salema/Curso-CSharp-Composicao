using Contracts.Entities.Enums;
using System.Collections.Generic;

namespace Contracts.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts1 { get; set; }

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            Contracts1 = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        {
            Contracts1.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts1.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts1)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
                
            }
            return sum;
        }
    }
}
