﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReviewSpr18.Models
{
    public class Message
    {
        public Message() { }

        public Message(string msg)
        {
            MessageText = msg;
        }
        public string MessageText { set; get; }
    }
}