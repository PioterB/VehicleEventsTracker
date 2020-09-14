using System;

namespace WebApi
{
    public interface ITimeHolder
    {
        DateTimeOffset RequestTime { get; }
        void Memorize(DateTimeOffset currentTime);
    }

    public class TimeHolder : ITimeHolder
    {       
        public void Memorize(DateTimeOffset currentTime)
        {
            RequestTime = currentTime;
        }

        public DateTimeOffset RequestTime { get; private set; }
    }
}