using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAss2
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration() : this(0, 0, 0) { }
        public Duration(int hours, int minutes, int seconds)
        {
            Normalize(hours * 3600 + minutes * 60 + seconds);
        }

        public Duration(int totalSeconds)
        {
            Normalize(totalSeconds);
        }

        private void Normalize(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Duration d)
            {
                if(this.TotalSeconds == d.TotalSeconds)
                    return true ;
            }
            return false ;
        }

        public override int GetHashCode()
        {
            return TotalSeconds().GetHashCode();
        }

        public int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }


        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration(d1.TotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d1)
        {
            return new Duration(d1.TotalSeconds() + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(Math.Max(0, d1.TotalSeconds() - d2.TotalSeconds()));
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(Math.Max(0, d.TotalSeconds() - 60));
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        public static bool operator true(Duration d)
        {
            return d.TotalSeconds() > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.TotalSeconds() == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(d.Hours, d.Minutes, d.Seconds);
        }
    }
}
