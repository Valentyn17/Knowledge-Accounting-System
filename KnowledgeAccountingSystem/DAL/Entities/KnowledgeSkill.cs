using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class KnowledgeSkill:BaseEntity
    {
    

        [Required]
        public string Name { get; set; }

        [Required]
        public int KnowledgeAreaId { get; set; }

        
        public KnowledgeArea KnowledgeArea { get; set; }

    }
}