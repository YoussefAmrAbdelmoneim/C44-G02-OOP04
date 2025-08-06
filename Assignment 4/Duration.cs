namespace Assignment_4
{
    internal class Duration
    {
        private int hours;
        private int minutes;
        private int seconds;
        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Duration(int seconds)
        {
            this.hours = seconds / 3600;
            int remainder = seconds % 3600;
            this.minutes = remainder / 60;
            this.seconds = remainder % 60;
        }
        public int TotalSeconds()
        {
            return this.hours * 3600 + this.minutes * 60 + this.seconds;
        }
        public override string ToString()
        {
            string result = "";
            if (hours > 0)
                result += $"Hours: {hours}, ";
            if (minutes > 0 || hours > 0)
                result += $"Minutes :{minutes}, ";
            result += $"Seconds :{seconds}";
            return result.TrimEnd(' ', ',');
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration((a?.TotalSeconds() ?? 0) + (b?.TotalSeconds() ?? 0));
        }
        public static Duration operator +(Duration a, int seconds)
        {
            return new Duration((a?.TotalSeconds() ?? 0) + seconds);
        }
        public static Duration operator +(int seconds, Duration a)
        {
            return new Duration((a?.TotalSeconds() ?? 0) + seconds);
        }

        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration((a?.TotalSeconds() ?? 0) - (b?.TotalSeconds() ?? 0));
        }
        public static bool operator >(Duration a, Duration b)
        {
            return a?.TotalSeconds() > b?.TotalSeconds();
        }
        public static bool operator <(Duration a, Duration b)
        {
            return a?.TotalSeconds() < b?.TotalSeconds();
        }
        public static bool operator >=(Duration a, Duration b)
        {
            return a?.TotalSeconds() >= b?.TotalSeconds();
        }
        public static bool operator <=(Duration a, Duration b)
        {
            return a?.TotalSeconds() <= b?.TotalSeconds();
        }
        public static Duration operator ++(Duration a)
        {
            return new Duration((a?.TotalSeconds() ?? 0) + 60);
        }
        public static Duration operator --(Duration a)
        {
            return new Duration((a?.TotalSeconds() ?? 0) - 60);
        }
        public static bool operator true(Duration a)
        {
            return a.TotalSeconds() > 0;
        }

        public static bool operator false(Duration a)
        {
            return a.TotalSeconds() <0;
        }
        public static explicit operator DateTime(Duration a)
        {
            return DateTime.MinValue.AddSeconds(a.TotalSeconds());
        }
    }
}
