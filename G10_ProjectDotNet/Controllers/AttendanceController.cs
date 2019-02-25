﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G10_ProjectDotNet.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace G10_ProjectDotNet.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly ISessionRepository _sessionRepository;

        public AttendanceController(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        public IActionResult Create(int sessionId, int memberId)
        {
            try
            {
                _sessionRepository.GetCurrentSession().Add(new Attendance { SessionId = sessionId, MemberId = memberId });
                _sessionRepository.SaveChanges();
                TempData["message"] = $"Je bent succesvol geregistreerd";
            }
            catch(InvalidOperationException e)
            {
                // Exceptie als er een duplicate in de database wordt gemaakt
                TempData["error"] = $"Deze gebruiker is reeds geregistreerd!";
            }
            return RedirectToAction("Index", "Session", new { area = "" });
        }
    }
}