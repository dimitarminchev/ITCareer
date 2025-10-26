using System;
using System.Collections.Generic;
using System.Text;

public class OnlineProduct : Product
{
    private string downloadUrl;

    public string DownloadUrl
    {
        get
        {
            return downloadUrl;
        }
        set
        {
            downloadUrl = value;
        }
    }

    public OnlineProduct(string title, double price, string downloadUrl)
        : base(title, price)
    {
       DownloadUrl = downloadUrl;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Title: {Title}");
        sb.AppendLine($"Price: {Price:F2} EUR");
        sb.AppendLine($"Download: {downloadUrl}");

        return sb.ToString();
    }
}

