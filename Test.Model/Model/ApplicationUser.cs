using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Test.Model.Model
{
	public class ApplicationUser : IdentityUser
	{
		
	}

	public class ApplicationUserManager : UserManager<ApplicationUser>
	{
		public ApplicationUserManager()
			: base(new UserStore<ApplicationUser>(new TestAutC()))
		{
			
		}
	}
}
