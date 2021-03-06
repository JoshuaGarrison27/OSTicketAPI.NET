﻿using System;

namespace OSTicketAPI.NET.Entities
{
    public partial class OstTicketStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Mode { get; set; }
        public int Flags { get; set; }
        public int Sort { get; set; }
        public string Properties { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
