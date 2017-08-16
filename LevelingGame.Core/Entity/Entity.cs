using System.ComponentModel.DataAnnotations;

namespace LevelingGame.Core.Entity
{
    public abstract class Entity<TPrimaryKey>
    {
        [Key]
        public virtual TPrimaryKey Id { set; get; }
    }

    public abstract class Entity : Entity<int>
    {

    }
}