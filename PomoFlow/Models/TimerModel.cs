﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomoFlow.Models
{
    public class TimerModel
    {
        public TimeSpan PomoTime { get; set; } = TimeSpan.FromMinutes(25);
        public TimeSpan ShortBreakTime { get; set; } = TimeSpan.FromMinutes(5);
        public TimeSpan LongBreakTime { get; set; } = TimeSpan.FromMinutes(15);
        public TimeSpan ElapsedTime { get; set; }
        public DateTime TimerStartTime { get; set; }
        public bool IsRunning { get; set; }
        public bool GotClickedBefore { get; set; }
        public bool IsBreakTime { get; set; } = false;
        public int PomoCounter { get; set; } = 1;
            
        public TimeSpan GetRemainingTime()
        {
            ElapsedTime = DateTime.Now - TimerStartTime;

            if (!IsBreakTime)
            {
                return PomoTime - ElapsedTime;
            }

            else
            {
                if (PomoCounter % 4 == 0)
                    return LongBreakTime - ElapsedTime;
                else
                    return ShortBreakTime - ElapsedTime;
            }
        }
    }
}
