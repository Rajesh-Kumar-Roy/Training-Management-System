using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrainingManagementSystem.DatabaseContext;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories.Base;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Repositories
{
    public class BatchRepository:BaseRepository<Batch>,IBatchRepository
    {
        private DbContext db;

        public TrainingDbContext Context
        {
            get { return (TrainingDbContext) db; }
        }
        public BatchRepository(DbContext db):base(db)
        {
            
        }
    }
}
