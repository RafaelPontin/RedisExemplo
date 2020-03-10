using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRedis.Util
{
    public class RedisUtil
    {
        private readonly string _host;

        public RedisUtil(string host)
        {
            _host = host;
        }

        public void Set(string key, string value)
        {
            using (RedisClient redisClient = new RedisClient(_host))
            {
                redisClient.Set(key, value);
            }
        }

        public string Get(string key)
        {
            using (RedisClient redisClient = new RedisClient(_host))
            {
                return redisClient.Get<string>(key);
            }
        }


    }
}
