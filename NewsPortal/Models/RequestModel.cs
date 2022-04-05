using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewsPortal.Models
{
    public class RequestModel
    {
        [Key]
        public int Id { get; set; }
        public List<string> Sources;
        public List<string> Domains;
        public string Q { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public Languages? Language { get; set; }
        public SortBys? SortBy { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public ArticlesResult ArticleResult { get; set; }
    }
}
