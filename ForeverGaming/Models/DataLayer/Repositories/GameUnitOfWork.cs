using System.Linq;

namespace ForeverGaming.Models
{
    public class GameUnitOfWork : IGameUnitOfWork
    {
        private GameContext context { get; set; }
        public GameUnitOfWork(GameContext ctx) => context = ctx;

        private Repository<Game> gameData;
        public Repository<Game> Games
        {
            get
            {
                if (gameData == null)
                    gameData = new Repository<Game>(context);
                return gameData;
            }
        }

        private Repository<Genre> genreData;
        public Repository<Genre> Genres
        {
            get
            {
                if (genreData == null)
                    genreData = new Repository<Genre>(context);
                return genreData;
            }
        }

        private Repository<Type> typeData;
        public Repository<Type> Types
        {
            get
            {
                if (typeData == null)
                    typeData = new Repository<Type>(context);
                return typeData;
            }
        }

        private Repository<Format> formatData;
        public Repository<Format> Formats
        {
            get
            {
                if (formatData == null)
                    formatData = new Repository<Format>(context);
                return formatData;
            }
        }
        
        public void Save() => context.SaveChanges();
    }
}
