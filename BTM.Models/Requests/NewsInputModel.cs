﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class NewsInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateModified { get; set; }
        public string Image { get; set; }
        public string Logo { get; set; }
        public int UserID { get; set; }
    }
}
