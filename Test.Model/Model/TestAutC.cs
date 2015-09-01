using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Test.Model.Model
{
	public class TestAutC : IdentityDbContext<ApplicationUser>
	{
		public TestAutC()
			: base("DefaultConnection")
		{
			
		}

		public DbSet<Test_Aut> Test_Aut { get; set; } 
	}
}
