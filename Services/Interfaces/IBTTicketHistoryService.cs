using BugTrackerPrime.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTrackerPrime.Services.Interfaces
{
    public interface IBTTicketHistoryService
    {
        Task AddHistoryAsync(Ticket oldTicket, Ticket newTicket, string userId);

        Task<List<TicketHistory>> GetProjectTicketsHistoriesAsync(int projectId, int companyId);

        Task<List<TicketHistory>> GetCompanyTicketHistoriesAsync(int companyId);
    }
}
