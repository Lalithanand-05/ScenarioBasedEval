using ExperiencePost1.Models;
using ExperiencePost1.Repository;

namespace ExperiencePost1.Repository
{
	public class SQLEmployeeRepository : IEmployeeRepository
	{
		EmployeeDbContext _context;
		public SQLEmployeeRepository(EmployeeDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Employee> GetAllEmployee()
		{
			IEnumerable<Employee> empList = _context.employees.ToList();
			return empList;
		}

		public Employee GetEmployeeByID(int EmployeeID)
		{
			Employee emp = _context.employees.Find(EmployeeID);
			return emp;
		}

		void Add(Employee employee)
		{
			_context.employees.Add(employee);
			_context.SaveChanges();

		}

		public void Delete(int EmployeeID)
		{
			Employee obj = _context.employees.Find(EmployeeID);
			_context.employees.Remove(obj);
			_context.SaveChanges();

		}

		public void Update(Employee employee )
		{
			_context.employees.Update(employee);
			_context.SaveChanges();

		}
	}
}
