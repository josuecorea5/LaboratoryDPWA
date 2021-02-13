using CitasSystem.Data.Interfaces;
using CitasSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasSystem.Data.Repositories
{
    public class CitasRepository : Repository<Citas>, ICitasRepository
    {
        private readonly ApplicationDbContext _db;
        public CitasRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
