﻿using G10_ProjectDotNet.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace G10_ProjectDotNet.Data.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<Session> _sessions;

        public SessionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _sessions = dbContext.Sessions;
        }

        public Session GetByDateToday()
        {
            return _sessions.Where(b => b.Date == DateTime.Now.Date && JsonConvert.DeserializeObject<Type>(b.StateSerialized) != typeof(SessionEndedState)).Include(b => b.Attendances).SingleOrDefault();
        }

        public Session GetLatest()
        {
            return _sessions.OrderBy(b => b.SessionId).LastOrDefault();
        }

        public void Add(Session session)
        {
            _sessions.Add(session);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
