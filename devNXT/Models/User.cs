using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace devNXT.Models
{
    public class User
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string ProjectName { get; set; }
        public string BlueprintName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contactsdetails { get; set; }
        public int Geography { get; set; }
        public string ProductSpeciality { get; set; }
        public string ProcessSpeciality { get; set; }
        public string ModuleSpeciality { get; set; }
        public string ProjectExper { get; set; }
        public string CreatedBy { get; set; }
        public string ProjectId { get; set; }
        public string GEOName { get; set; }
        public string PRSName { get; set; }
        public string PSName { get; set; }
        public string MSName { get; set; }
        public string PEName { get; set; }

        public string gitlink { get; set; }
        public string ApprovalStatus { get; set; }
        public string Type { get; set; }

        public string ADId { get; set; }
        public int DId { get; set; }

        public string DivisionName { get; set; }

    }
}
