using System;
using System.Collections.Generic;

namespace drone
{
    public class ServiceOne
    {
        public ServiceOne()
        {
        }

        public IEnumerable<char> GetResponse()
        {
            return "friend";
        }
    }
}
