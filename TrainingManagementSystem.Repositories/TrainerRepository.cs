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
    public class TrainerRepository:BaseRepository<Trainer>,ITrainerRepository
    {
        private DbContext db;

        private TrainingDbContext Context
        {
            get { return (TrainingDbContext) db; }
        }
        public TrainerRepository(DbContext db):base(db)
        {
            this.db = (TrainingDbContext) db;
        }
    }
}
