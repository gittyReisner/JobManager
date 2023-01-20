using System;
using System.Collections.Generic;
using System.Text;

namespace JobManager.Core.Response
{
    public class ManagerResponse
    {
        public ManagerResponse() { }
        public ManagerResponse(ManagerResponseResult result)
        {
            this.Result = result;
        }
        public ManagerResponse(ManagerResponseResult result, string ErrorMessage)
        {
            this.Result = result;
            this.ErrorMessage = ErrorMessage;
        }
        public ManagerResponseResult Result { get; set; }
        public string ErrorMessage { get; set; }

    }

    public class ManagerResponse<T> : ManagerResponse
    {
        public ManagerResponse() { }
        public ManagerResponse(T response) : base()
        {
            responseObject = response;
        }
        public ManagerResponse(ManagerResponseResult result, T response) : base(result)
        {
            responseObject = response;
        }
        public ManagerResponse(ManagerResponseResult result, string ErrorMessage) : base(result, ErrorMessage) { }
        public ManagerResponse(ManagerResponseResult result, string ErrorMessage, T response) : base(result, ErrorMessage)
        {
            responseObject = response;
        }
        public T responseObject { get; set; }

    }
}
