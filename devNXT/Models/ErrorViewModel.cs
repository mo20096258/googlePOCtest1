using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace devNXT.Models
{
    public class ErrorViewModel
    {

        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
