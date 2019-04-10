using System;
using System.Collections.Generic;
using System.Text;
using IService;

namespace Service
{
   public class TestService:ITestService
    {
        public TestService()
        {
            MyProperty = Guid.NewGuid();
        }

        public Guid MyProperty { get; set; }

        public List<string> GetList(string Id)
        {
            return new List<string>() {"Lilei","Hanmeimei","Lisa","Tom","Jack" };
        }




    }
}
