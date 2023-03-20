using BugTrackerPrime.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTrackerPrime.Services
{
    public interface IBTLookupService
    {
        public Task<List<TicketPriority>> GetTicketPrioritiesAsync();

        public Task<List<TicketStatus>> GetTicketStatusesAsync();

        public Task<List<TicketType>> GetTicketType();

        public Task<List<ProjectPriority>> GetProjectPrioritiesAsync();
    }
}
