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
        /// Constructor.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="level"></param>
        /// <param name="id"></param>
        public Section(string content, int level, int id)
        {
            this.Content = content;
            this.Level = level;
            this.ID = id;
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
                tabs += "\t";
            }
            return $"{tabs}{this.Content}";
        }
    }
}
