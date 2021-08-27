using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegList.Data
{
  public class ApplicationUser : IdentityUser
  {

    public string FullName { get; set; }

    public string RegNumber { get; set; }

    public string Department { get; set; }

    public string year { get; set; }

    public string Courses { get; set; }

  }
}
