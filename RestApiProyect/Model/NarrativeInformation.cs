using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiProyect.Model
{
    public class Entry
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    public class Organization
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
    }

    public class NarrativeInformation
    {
        public string Id { get; set; }
        public string Source { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DateTime { get; set; }
        public string Author { get; set; }
        public IList<Entry> Entries { get; set; }
        public Organization Organization { get; set; }
    }
}
