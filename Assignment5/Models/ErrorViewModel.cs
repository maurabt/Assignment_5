using System;

namespace Assignment5.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        //when variable is null / empty upon request
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
