using StackExchange.Redis;
using System;

namespace Redis
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            IDatabase db = redis.GetDatabase();
            string value = db.StringGet("k1");
            Console.WriteLine(value);
        }
    }
}
