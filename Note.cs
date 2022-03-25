using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeNoteTaker
{
    internal class Note : Entry
    {
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <param name="content"></param>
        /// <param name="level"></param>
        /// <param name="id"></param>
        public Note(DateTime timeStamp, string content, int level, int id)
        {
            this.TimeStamp = timeStamp;
            this.Content = content;
            this.Level = level;
            this.ID = id;
        }

        /// <summary>
        /// Converts a Note to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string tabs = "";
            for (int i = 0; i < Level; i++)
            {
                tabs += "\t";
            }
            return $"{tabs}{this.TimeStamp.ToString("HH:mm:ss.fff")} {this.Content}";
        }
    }
}
