using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cronometro.Models
{
    public class Chrono
    {

        DateTime dateStarted;
        DateTime datePaused;
        bool paused;

        public Chrono()
        {
            paused = false;
        }

        public void Play()
        {
            // If the chrono has been paused
            if (paused == true)
            {
                // Resume
                TimeSpan t = DateTime.Now.Subtract(datePaused);
                dateStarted = dateStarted.Add(t);
            }
            // Else : not been paused
            else
                dateStarted = DateTime.Now;

        }
        public void Pause()
        {
            datePaused = DateTime.Now;
            paused = true;
        }

        public void Reset()
        {
            paused = false;
            dateStarted = DateTime.Now;
            datePaused = DateTime.Now;

        }

        public override String ToString()
        {
            DateTime DateNow = DateTime.Now;
            TimeSpan Difference = DateNow - dateStarted;

            StringBuilder builder = new StringBuilder(11);
            builder.Append(Difference.Hours.ToString("d2"));
            builder.Append("::");
            builder.Append(Difference.Minutes.ToString("d2"));
            builder.Append("::");
            builder.Append(Difference.Seconds.ToString("d2"));

            return builder.ToString();
        }

    }
   }
