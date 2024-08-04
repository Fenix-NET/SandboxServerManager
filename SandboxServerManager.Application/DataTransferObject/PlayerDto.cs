using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxServerManager.Application.DataTransferObject
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public int Level { get; set; }
        public string Clan {  get; set; }
        public string Role { get; set; }
    }
}
