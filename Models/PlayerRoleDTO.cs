namespace CS2Scout.Api.Models
{
    public class PlayerRoleDTO
    {
        public string role {  get; set; } = string.Empty;
        public int attribute { get; set; }

        public PlayerRoleDTO(string role, int attribute)
        {
            this.role = role;
            this.attribute = attribute;
        }
    }
}
