using System;
using System.Globalization;
using System.Text;

public class VirtualEventOffer : EventOffer
{
    private bool fullyVirtual;

    public VirtualEventOffer(string eventTitle, string organizer, double ticketPrice, int durationHours, bool fullyVirtual)
        : base(eventTitle, organizer, ticketPrice, durationHours)
    {
        FullyVirtual = fullyVirtual;
    }

    public bool FullyVirtual
    {
        get => fullyVirtual;
        set => fullyVirtual = value;
    }

    public override string ToString()
    {
        string fv = FullyVirtual ? "yes" : "no";
        return base.ToString() + Environment.NewLine + $"Fully Virtual: {fv}";
    }
}
