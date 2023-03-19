using System.Security.Claims;
using System.Security.Principal;

namespace BugTrackerPrime.Extentions
{
    public static class IdentityExtentions
    {
        public static int? GetCompanyId(this IIdentity identity)
        {
            Claim claim = ((ClaimsIdentity)identity).FindFirst("CompanyId");
            // Ternary operator (if/else)
            return (claim != null) ? int.Parse(claim.Value) : null;

            // ^^^ Above Ternary operator explination ^^^
            
            //int result;
            //if (claim != null)
            //{
            //      result = int.Parse(claim.Value);
            //}
            //else
            //{
            //      result = 0;
            //}
            //return result;

        }
    }
}
