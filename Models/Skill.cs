using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExperiencePost1.Models
{
	public class Skill
	{
		public int SkillID { get; set; }
		public int EmployeeID { get; set; }
		public string? SkillName { get; set; }
		public string? Role { get; set; }
		public int Expyrs { get; set; }
		public string? PostalCode { get; set; }
		
	}
}