
using Parcial3_VargasGaviriaJhoanSebastian.DAL.Entities;

namespace Parcial3_VargasGaviriaJhoanSebastian.DAL
{
    public class SeederDb
    {
        private readonly DataBaseContext _context;
        public SeederDb(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            PopulateTickets();

            await _context.SaveChangesAsync();
        }

        // Este metodo es para llenar los tickets en la db por primera vez
        private void PopulateTickets()
        {
            if (_context.Tickets.Any()) return;

            for (int i = 0; i < 1000; i++)
            {
                _context.Tickets.Add(new Ticket
                {
                    TicketID = i,
                    UseDate = null,
                    IsUsed = false,
                    EntranceGate = null,
                    CreateDate = DateTime.Now,
                }
                );
            }
        }
    }
}
