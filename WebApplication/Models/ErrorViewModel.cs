using System;

namespace WebApplication.Models
{
    public class ErrorViewModel
    {
        //test!!
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}