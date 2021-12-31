using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class KnowledgeArea:BaseEntity
    {
 
        [Required]
        public string Name { get; set; }


        public ICollection<KnowledgeSkill> Skills { get; set; }
    }
}
