using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvvaHostEmulator.Models
{
    public class AlertModel
    {
        public int Id { get; set; }
        public int DigitalOutput { get; set; }
        public string OutputText { get; set; }
        public string MessageOutput { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}