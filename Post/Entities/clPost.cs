﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Entities
{
    class clPost
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public clPost()
        {

        }

        public clPost(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComments(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
