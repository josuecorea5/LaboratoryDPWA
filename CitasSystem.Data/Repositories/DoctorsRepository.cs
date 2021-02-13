using CitasSystem.Data.Interfaces;
using CitasSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasSystem.Data.Repositories
{
    public class DoctorsRepository : Repository<Doctors>, IDoctorsRepository
    {
        private readonly ApplicationDbContext _db;
        public DoctorsRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
