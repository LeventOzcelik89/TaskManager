using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class BaseResponse<T> {
        public Guid MyProperty { get; set; }
    }

}
