using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace bugops.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BugopsUser class
public class BugopsUser : IdentityUser {
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

