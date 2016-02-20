using System.ComponentModel.DataAnnotations;

namespace GameContester.Domain.Entities
{
    class Entity: IEntity<int>
    {
        [Key]
        public int Id { get; set; }
    }
}
