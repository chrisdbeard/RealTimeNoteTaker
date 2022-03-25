using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeNoteTaker
{
    internal abstract class Entry : IEquatable<Entry>
    {
        public string Content { get; set; }
        public int Level { get; set; } // Represents the Entries indention.
        public int ID { get; set; }

        /// <summary>
        /// Checks to see if Entry is equal to another Entry.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Entry other)
        {
            return (this.ID == other.ID);
        }

        /// <summary>
        /// Checks to see if a object is equal to another Entry.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other is Entry)
                return this.Equals((Entry)other);
            else
                return false;
        }
        
        /// <summary>
        /// Returns unique hash code for an Entry.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.Level.GetHashCode() ^ this.Content.GetHashCode();
        }

        /// <summary>
        /// Increases the level by 1.
        /// </summary>
        public void Promote()
        {
            this.Level++;
        }

        /// <summary>
        /// Decreases the level by 1.
        /// </summary>
        public void Demote()
        {
            if (this.Level > 0)
            {
                this.Level--;
            }
        }

        public abstract override string ToString();
    }
}
