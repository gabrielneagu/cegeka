using Homework3.Data;
using Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly WorkLoadDbContext _context;
        public LocationRepository(WorkLoadDbContext context)
        {
            _context = context;
        }
        public void AddLocation(Location location)
        {
            _context.Location.Add(location);
            _context.SaveChanges();
        }

        public List<Location> GetLocations()
        {
            return _context.Location.ToList();
        }
    }
}
