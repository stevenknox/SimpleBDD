using System;

namespace CoreBDD
{
    public class Scenario : System.Attribute
    {
        public string Title { get; set; }
        public Scenario(string title)
        {
            Title = title;
        }

    }
}