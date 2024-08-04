using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxServerManager.Core.Entities
{
    [Table("roles")]
    public class PlayerRole
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("role_name")]
        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
