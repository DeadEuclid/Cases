using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cases;
using Cases.ViewModel;

namespace DbMock
{
    public class MockContext:DbContext
    {
        public MockContext() : base("Server=localhost;Database=TicketsDB;trusted_connection=true;")
        { 
        
        }
        public DbSet<DemandRoute> DemandRoutes { get;set }
        public DbSet<TicketReport> TicketReports{ get;set }
        public DbSet<TripInfo> TripInfos{ get; set; }
        public DbSet<TripSearch> TripSearches { get;set }
    }
}
