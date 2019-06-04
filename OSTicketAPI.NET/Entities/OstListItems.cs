﻿namespace OSTicketAPI.NET.Entities
{
    public partial class OstListItems
    {
        public int Id { get; set; }
        public int? ListId { get; set; }
        public int Status { get; set; }
        public string Value { get; set; }
        public string Extra { get; set; }
        public int Sort { get; set; }
        public string Properties { get; set; }
    }
}
