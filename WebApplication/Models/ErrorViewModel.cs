using System;

namespace WebApplication.Models
{
    public class ErrorViewModel
    {
        //test!! sdasdasdasd
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}