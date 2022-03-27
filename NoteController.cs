using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RealTimeNoteTaker
{
    internal class NoteController
    {
        private IDGenerator _IDGenerator { get; set; }
        public List<Entry> Entries { get; set; }
        private string FilePath { get; set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        public NoteController()
        {
            this._IDGenerator = IDGenerator.GetInstance();
            this.Entries = new List<Entry>();
            this.FilePath = "";
        }

        /// <summary>
        /// Adds a note to the list Entries.
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <param name="content"></param>
        /// <param name="level"></param>
        public void AddNote(DateTime timeStamp, string content, int level)
        {
            Entries.Add(new Note(timeStamp, content, level, _IDGenerator.NextID()));
        }

        /// <summary>
        /// Adds a section to the list Entries.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="level"></param>
        public void AddSection(string content, int level)
        {
            Entries.Add(new Section(content, level, _IDGenerator.NextID()));
        }

        /// <summary>
        /// Promotes an entry in Entries if an entry in the Entries is equal to the given entry.
        /// </summary>
        /// <param name="entry"></param>
        public void PromoteEntry(Entry entry)
        {
            foreach (Entry e in Entries)
            {
                if (e.Equals(entry))
                {
                    e.Promote();
                }               
            }
        }

        /// <summary>
        /// Demotes an entry in Entries if an entry in the Entries is equal to the given entry.
        /// </summary>
        /// <param name="entry"></param>
        public void DemoteEntry(Entry entry)
        {
            foreach (Entry e in Entries)
            {
                if (e.Equals(entry))
                {
                    e.Demote();
                }
            }
        }

        public void EditEntry(Entry entry, string content)
        {
            foreach (Entry e in Entries)
            {
                if (e.Equals(entry))
                {
                    e.Content = content;
                }
            }
        }

        /// <summary>
        /// Removes an entry from Entries.
        /// </summary>
        /// <param name="entry"></param>
        public void RemoveEntry(Entry entry)
        {
            Entries.Remove(entry);
        }

        public void WriteEntriesToFile()
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (Entry e in Entries)
                {
                    sw.WriteLine(e);
                }
            }
        }

        public void ReadFile(string filePath)
        {
            Regex rx = new Regex(@"[0 - 9]{ 1,2}:[0 - 9]{ 1,2}:[0 - 9]{ 1,2}.[0 - 9]{ 1,3}",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            this.Entries.Clear();

            if (File.Exists(filePath))
            {
                this.FilePath = filePath;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        MatchCollection matches = rx.Matches(line);
                        if (matches.Count == 0)
                        {
                            this.Entries.Add(new Section(line));
                        }
                        else
                        {
                            this.Entries.Add(new Note(line));
                        }                       
                    }
                }
            }
        }

        /// <summary>
        /// Sets the FilePath property.
        /// </summary>
        /// <param name="filePath"></param>
        public void SetFilePath(string filePath)
        {
            this.FilePath = filePath;
        }
    }
}
