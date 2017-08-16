using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace LevelingGame.EntityFrameWork.EFCore
{
    public class LevelingGameContextFactory: IDesignTimeDbContextFactory<LevelingGameContext>
    {

        public LevelingGameContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LevelingGameContext>();
            optionsBuilder.UseSqlServer("server=.;database=LevelingDb; Trusted_Connection=True;MultipleActiveResultSets=true");

            return new LevelingGameContext(optionsBuilder.Options);
        }
    }
}