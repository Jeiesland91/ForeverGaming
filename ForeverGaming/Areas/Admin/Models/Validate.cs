using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ForeverGaming.Models
{
    public class Validate
    {
        private const string GameKey = "validGame";
        private const string GenreKey = "validGenre";
        private const string FormatKey = "validFormat";
        private const string TypeKey = "validType";

        private ITempDataDictionary tempData { get; set; }
        public Validate(ITempDataDictionary temp) => tempData = temp;

        public bool IsValid { get; private set; }
        public string ErrorMessage { get; private set; }

        public void CheckGame(int gameId, string operation, Repository<Game> data)
        {
            Game entity = null; // only check database on add
            if (Operation.IsAdd(operation))
            {
                entity = data.Get(new QueryOptions<Game>
                {
                    Where = g => g.GameId == gameId
                });
            }
            IsValid = (entity == null) ? true : false;
            ErrorMessage = (IsValid) ? "" :
                $"Game {entity.Name} is already in the database.";
        }

        public void MarkGameChecked() => tempData[GameKey] = true;
        public void ClearGame() => tempData.Remove(GameKey);
        public bool IsGameChecked => tempData.Keys.Contains(GameKey);

        public void CheckGenre(string genreId, string operation, Repository<Genre> data)
        {
            Genre entity = null; // only check database on add
            if (Operation.IsAdd(operation))
            {
                entity = data.Get(new QueryOptions<Genre>
                {
                    Where = g => g.GenreId == genreId
                });
            }
            IsValid = (entity == null) ? true : false;
            ErrorMessage = (IsValid) ? "" :
                $"Genre {entity.Name} is already in the database.";
        }

        public void MarkGenreChecked() => tempData[GenreKey] = true;
        public void ClearGenre() => tempData.Remove(GenreKey);
        public bool IsGenreChecked => tempData.Keys.Contains(GenreKey);

        public void CheckType(string typeId, string operation, Repository<Type> data)
        {
            Type entity = null; // only check database on add
            if (Operation.IsAdd(operation))
            {
                entity = data.Get(new QueryOptions<Type>
                {
                    Where = t => t.TypeId == typeId
                });
            }
            IsValid = (entity == null) ? true : false;
            ErrorMessage = (IsValid) ? "" :
                $"Type {entity.Name} is already in the database.";
        }

        public void MarkTypeChecked() => tempData[TypeKey] = true;
        public void ClearType() => tempData.Remove(TypeKey);
        public bool IsTypeChecked => tempData.Keys.Contains(TypeKey);

        public void CheckFormat(string formatId, string operation, Repository<Format> data)
        {
            Format entity = null; // only check database on add
            if (Operation.IsAdd(operation))
            {
                entity = data.Get(new QueryOptions<Format>
                {
                    Where = f => f.FormatId == formatId
                });
            }
            IsValid = (entity == null) ? true : false;
            ErrorMessage = (IsValid) ? "" :
                $"Format {entity.Name} is already in the database.";
        }
        public void MarkFormatChecked() => tempData[FormatKey] = true;
        public void ClearFormat() => tempData.Remove(FormatKey);
        public bool IsFormatChecked => tempData.Keys.Contains(FormatKey);

    }
}
