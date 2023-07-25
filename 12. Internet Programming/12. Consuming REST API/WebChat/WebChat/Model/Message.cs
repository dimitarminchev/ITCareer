﻿using System;

namespace WebChat.Model
{
    public class Message
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public string User { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
