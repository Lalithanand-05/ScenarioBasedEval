using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExperiencePost1.Models;

namespace ExperiencePost1.Repository
{
	public interface IEmployeeRepository
	{
		//Employee GetEmployee(Employee employee);
		IEnumerable<Employee> GetAllEmployee();
		public Employee Add(Employee employee);
		public Employee GetEmployeeByID(Employee employee);
		public Employee Update(Employee employee);
		public void Delete(int EmployeeID);
		//Skill GetSkill(int SkillID);
		//IEnumerable<Skill> GetAllSkills(int SkillID);
		//void AddSkill(Skill skill);
		//void DeleteSkill(int SkillID);

	}
}
