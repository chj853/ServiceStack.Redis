﻿namespace ServiceStack.Redis
{
    public static class RedisClientExtensions
    {
        public static string GetHostString(this IRedisClient redis)
        {
            return "{0}:{1}".Fmt(redis.Host, redis.Port);
        }
    }
}