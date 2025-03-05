using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Prgm_12_Manager
    {

        public string Name { get; set; }
        public Prgm_12_Manager(string name) 
        {
            Name = name;
        }
    }
    class Department
    {
        public string DepartmentName { get; set; }
        public Prgm_12_Manager DeptManager { get; set; }
        public Department(string departmentName, Prgm_12_Manager deptManager)
        {
            DepartmentName = departmentName;
            DeptManager = deptManager;
        }
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }
        public Department DeepCopy()
        {
            return new Department(DepartmentName, new Prgm_12_Manager(DeptManager.Name));
        }
    }
}
