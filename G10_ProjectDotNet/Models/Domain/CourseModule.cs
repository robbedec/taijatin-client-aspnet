﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G10_ProjectDotNet.Models.Domain
{
    public class CourseModule
    {
        public int? CourseModuleId { get; set; }
        public string Name { get; set; }
        public Course Course { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAlt { get; set; }
        public string Text { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public CourseModule()
        {
            Comments = new List<Comment>();
        }


        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public Comment GetComment(int commentId)
        {
            return Comments.Where(c => c.CommentId == commentId).SingleOrDefault();
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
    }
}
