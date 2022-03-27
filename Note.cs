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
        /// Constructor that takes the timestamp, content, level and ID and sets it to the class properties.
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <param name="content"></param>
        /// <param name="level"></param>
        /// <param name="id"></param>
        public Note(DateTime timeStamp, string content, int level, int id)
        {
            this.TimeStamp = timeStamp;
            this.Content = content.Trim();
            this.Level = level;
            this.ID = id;
        }

        /// <summary>
        /// Constructor that will parse a line from a selected file.
        /// </summary>
        /// <param name="line"></param>
        public Note(string line)
        {
            IDGenerator _IDGenerator = IDGenerator.GetInstance();           
            List<string> splitLine = line.Split(' ').ToList();                        
            int numOfSpaces = 0;
            int contentStart = 0;
            for (int i = 0; i < splitLine.Count(); i++)
            {
                if (splitLine[i] == "")
                {
                    numOfSpaces++;
                }
                else
                {
                    this.TimeStamp = DateTime.Parse(splitLine[i]);
                    contentStart = i + 1;
                    break;
                }
            }
            string content = "";
            for (int i = contentStart; i < splitLine.Count(); i++)
            {
                content += splitLine[i] + " ";
            }
            this.Content = content.Trim();
            this.Level = numOfSpaces / 4;
            this.ID = _IDGenerator.NextID();
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
                tabs += "    ";
            }
            return $"{tabs}{this.TimeStamp.ToString("HH:mm:ss.fff")} {this.Content}";
        }
    }
}
