using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Data.SQLite;
using System;
using System.Collections.Generic;


public class Composition
{
	public string author { get; set; }
    public string song { get; set; }
    public Composition()
    {
        author = string.Empty;
        song = string.Empty;
    }
    public Composition(string _author, string _song)
	{
        author= _author;
		song = _song;
    }
    public override string ToString()
	{
		return author + " - " + song;
    }
}
