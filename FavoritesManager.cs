// FavoritesManager.cs


namespace MetropolitanMuseum
{
    public class FavoritesManager
    {
        //retourne l'instance unique de la classe
        private static FavoritesManager _instance;

        // Dictionnaire pour stocker les favoris (1, 2, 3)
        private Dictionary<int, List<DepartmentFavorite>> favorites;

        
        private FavoritesManager() // Constructeur privé 
        {
            // Initialisation du dictionnaire
            favorites = new Dictionary<int, List<DepartmentFavorite>>
        {
            { 1, new List<DepartmentFavorite>() },
            { 2, new List<DepartmentFavorite>() },
            { 3, new List<DepartmentFavorite>() }
        };
        }

        // Propriété pour accéder à l'instance unique
        public static FavoritesManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FavoritesManager();
                }
                return _instance;
            }
        }

        // Méthode pour ajouter un favori
        public void AddFavorite(int choice, DepartmentFavorite favorite)
        {
            if (favorites.ContainsKey(choice))
            {
                favorites[choice].Add(favorite);
            }
        }

        // Méthode pour récupérer les favoris d'un choix donné
        public List<DepartmentFavorite> GetFavorites(int choice)
        {
            if (favorites.ContainsKey(choice))
            {
                return favorites[choice];
            }
            return new List<DepartmentFavorite>();
        }

        // Ajoutez une méthode HasFavorites
        public bool HasFavorites()
        {
            // récupère le choix si plus grand que 0
            return favorites.Values.Any(favoritesList => favoritesList.Count > 0);
        }

    }

}
