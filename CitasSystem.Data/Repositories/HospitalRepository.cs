using CitasSystem.Data.Interfaces;
using CitasSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasSystem.Data.Repositories
{
    public class HospitalRepository : Repository<Hospital>, IHospitalRepository
    {
        private readonly ApplicationDbContext _db;
        public HospitalRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
