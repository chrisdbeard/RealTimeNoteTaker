using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeNoteTaker
{
    internal class Section : Entry
    {
        /// <summary>
        /// Constructor that takes the content, level, and ID and sets it to the class properties.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="level"></param>
        /// <param name="id"></param>
        public Section(string content, int level, int id)
        {
            this.Content = content.Trim();
            this.Level = level;
            this.ID = id;
        }

        /// <summary>
        /// Constructor that will parse a line from a selected file.
        /// </summary>
        /// <param name="line"></param>
        public Section(string line)
        {
            IDGenerator _IDGenerator = IDGenerator.GetInstance();
            List<string> splitLine = line.Split(' ').ToList();
            this.Content = line.Trim();
            int numOfSpaces = 0;
            for (int i = 0; i < splitLine.Count(); i++)
            {
                if (splitLine[i] == "")
                {
                    numOfSpaces++;
                }
                else
                {
                    break;
                }
            }
            this.Level = numOfSpaces / 4;
            this.ID = _IDGenerator.NextID();
        }

        /// <summary>
        /// Converts the Section to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string tabs = "";
            for (int i = 0; i < Level; i++)
            {
                tabs += "    ";
            }
            return $"{tabs}{this.Content}";
        }
    }
}
