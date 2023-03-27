using BugTrackerPrime.Data;
using BugTrackerPrime.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTrackerPrime.Services
{
    public class BTLookupService : IBTLookupService
    {
        private readonly ApplicationDbContext _context;

        public BTLookupService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProjectPriority>> GetProjectPrioritiesAsync()
        {
            try
            {
                return await _context.ProjectPriorities.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<TicketPriority>> GetTicketPrioritiesAsync()
        {
            try
            {
                return await _context.TicketPriorities.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<TicketStatus>> GetTicketStatusesAsync()
        {
            try
            {
                return await _context.TicketStatuses.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<TicketType>> GetTicketType()
        {
            try
            {
                return await _context.TicketTypes.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<IEnumerable> GetTicketTypeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
