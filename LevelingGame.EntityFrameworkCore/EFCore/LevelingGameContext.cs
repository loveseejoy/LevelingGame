using LevelingGame.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace LevelingGame.EntityFrameWork.EFCore
{
    public class LevelingGameContext:DbContext
    {
       public  DbSet<User> Users { set; get; }

        public LevelingGameContext(DbContextOptions<LevelingGameContext> options):base(options)
        {
            
        }
    }
}