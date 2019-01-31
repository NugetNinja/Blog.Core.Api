using Demo.Core.Api.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string key = "123";
            for (int i = 0; i < 500; i++)
            {
                var msg = new { Name = "��ά" + i, Status = 1, Gender = 0, Image = "http://localhost:7779/Image/driver.png", Remark = "����һ���ر��Ц���ˣ����Ƕ�����С��", IdCard = 610124199303083650, Title = "��������" };

                string json = JsonConvert.SerializeObject(msg);
                var redis= RedisFactory.GetRedisClient(key);
                redis.StringSet(key, json);
                
            }
        }
    }
}
