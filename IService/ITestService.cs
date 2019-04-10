using System;
using System.Collections.Generic;
using System.Text;

namespace IService
{
   public interface ITestService
    {
        Guid MyProperty { get; }
        List<string> GetList(string Id);

    }
}
