using AvvaHostEmulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AvvaHostEmulator.Controllers
{
    public class AlertsController : ApiController
    {
        // GET: api/Alerts
        public IQueryable<AlertModel> GetAlerts()
        {
            HashSet<AlertModel> alerts = new HashSet<AlertModel>
            {
                new AlertModel
                {
                    CreatedAt = DateTime.Now.AddMinutes(-3),
                    DigitalOutput = 1,
                    OutputText = "Camera1"
                },

                new AlertModel
                {
                    CreatedAt = DateTime.Now.AddMinutes(-2),
                    DigitalOutput = 2,
                    OutputText = "Camera2"
                },

                new AlertModel
                {
                    CreatedAt = DateTime.Now.AddMinutes(-1),
                    DigitalOutput = 3,
                    OutputText = "Camera3"
                },

                new AlertModel
                {
                    CreatedAt = DateTime.Now,
                    DigitalOutput = 4,
                    OutputText = "Camera4"
                }
            };
            return alerts.AsQueryable();
        }
    }
}
