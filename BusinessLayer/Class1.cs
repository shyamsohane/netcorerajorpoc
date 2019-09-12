using System;

namespace BusinessLayer
{
    public interface IBusinessLayer
    {
        dynamic GetCustomerDetails(long id);
    }
    public class BusinessLayer : IBusinessLayer
    {
        public dynamic GetCustomerDetails(long id)
        {
            throw new NotImplementedException();
        }
    }
}
