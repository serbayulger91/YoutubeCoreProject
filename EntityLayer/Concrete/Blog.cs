﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public string BlogStatus { get; set; }

        /*Bağlantılar*/
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        

        public List<Comment> Comments { get; set; }
    }
}