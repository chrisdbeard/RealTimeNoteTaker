using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeNoteTaker
{
    internal sealed class IDGenerator
    {
        private int ID { get; set; }
        private static IDGenerator _instance;

        /// <summary>
        /// Constructor.
        /// </summary>
        private IDGenerator()
        {
            this.ID = 0;
        }

        /// <summary>
        /// Returns the current instance of the IDGenerator.
        /// </summary>
        /// <returns></returns>
        public static IDGenerator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new IDGenerator();
            }
            return _instance;
        }

        /// <summary>
        /// Returns a unique ID.
        /// </summary>
        /// <returns></returns>
        public int NextID()
        {
            this.ID++;
            return this.ID;
        }
    }
}
