using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Share.Models;
using Core.Entity;
namespace Share.Models
{
    public class ArticleCatalogAddDto
    {
        /// <summary>
        /// 父目录
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        public short Sort { get; set; } = 0;
        public short Level { get; set; }
        public Guid? ParentId { get; set; }
        public Guid AccountId { get; set; }
    }
}