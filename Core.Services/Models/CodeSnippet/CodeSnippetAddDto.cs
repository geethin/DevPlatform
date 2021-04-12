using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Services.Models;
using GT.Agreement.Models;
using Core.Entity;
namespace Core.Services.Models
{
    public class CodeSnippetAddDto
    {
        /// <summary>
        /// 实体名称
        /// </summary>
        [MaxLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }
        /// <summary>
        /// 实体定义内容
        /// </summary>
        [MaxLength(4000)]
        public string Content { get; set; }
        /// <summary>
        /// 语言类型
        /// </summary>
        public Language Language { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public CodeType CodeType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTimeOffset UpdatedTime { get; set; }
        public Guid? LibraryId { get; set; }
    
    }
}