using System;
using System.Collections.Generic;
using System.Text;

namespace JobManager.Data.Responses
{
    public class DataResponse
    {
        public DataResponse() { }
        public DataResponse(DataResponseResult result)
        {
            this.Result = result;
        }
        public DataResponse(DataResponseResult result, string ErrorMessage)
        {
            this.Result = result;
            this.ErrorMessage = ErrorMessage;
        }
        public DataResponseResult Result { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class DataResponse<T> : DataResponse
    {
        public DataResponse() { }
        public DataResponse(T response) : base()
        {
            ResponseObject = response;
        }
        public DataResponse(DataResponseResult result, T response) : base(result)
        {
            ResponseObject = response;
        }
        public DataResponse(DataResponseResult result, string ErrorMessage) : base(result, ErrorMessage) { }
        public DataResponse(DataResponseResult result, string ErrorMessage, T response) : base(result, ErrorMessage)
        {
            ResponseObject = response;
        }
        public T ResponseObject { get; set; }
    }
}
