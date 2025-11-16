using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CareItem
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length < 2 || value.Length > 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }
    }

    private bool status;

    public bool Status
    {
        get
        {
            return status;
        }
        set
        {
            status = value;
        }
    }

    public CareItem(string name, bool status)
    {
        Name = name;
        Status = status;
    }

    public override string ToString()
    {
        return $"CareItem {Name}\n"
            + $"Status: {Status}";
    }
}