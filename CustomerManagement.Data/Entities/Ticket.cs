﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }  

        public string Title { get; set; }  
        public string Description { get; set; }  

        public string Status { get; set; }  
        public string Priority { get; set; }  

        public DateTime CreatedAt { get; set; }  
        public DateTime UpdatedAt { get; set; }  

        public int UserId { get; set; }  
        public User User { get; set; }  

        public int? AssignedAgentId { get; set; }  
        public User AssignedAgent { get; set; }
    }
}
