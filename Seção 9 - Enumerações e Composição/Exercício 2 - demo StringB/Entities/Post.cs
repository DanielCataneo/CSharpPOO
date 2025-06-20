﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_2___demo_StringB.Entities;

namespace Exercício_2___demo_StringB.Entities
{
    internal class Post
    {
        public DateTime Date {  get; set; }
        public  string Title { get; set; }
        
        public string Content { get; set; }

        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

       public Post() { }
        
        public Post(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
            
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes.ToString() + " Likes");
            sb.AppendLine(" - " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }
            
            return sb.ToString();
        }

    }
}
