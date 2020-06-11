using System;
using System.Collections.Generic;

namespace PBCTracker.Models
{
    public class Case
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string Department { get; set; }
        public string CostCenter { get; set; }
        public RequestTypes RequestType { get; set; }
        public string Situation { get; set; }
        public string Background { get; set; }
        public string Assessment { get; set; }
        public string Recommendation { get; set; }
        public StatusCodes Status { get; set; }
        public List<string> Stakeholders { get; set; }
        public List<string> Approvers { get; set; }
        public Case()
        {
            Stakeholders = new List<string>();
            Approvers = new List<string>();
        }
    }
}
