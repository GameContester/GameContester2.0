using System.ComponentModel.DataAnnotations;

namespace GameContester.Domain.Entities
{
    public class Entity: IEntity<int>
    {
        [Key]
        public int Id { get; set; }
    }
}
