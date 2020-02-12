using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public class FavoritesDaoCollection : IFavoritesDao
    {
        private static Dictionary<long, Cart> userFavorites;
        public FavoritesDaoCollection()
        {
            if (userFavorites == null)
                userFavorites = new Dictionary<long, Favorites>();
        }
        public void AddFavoriteMovie(long userId, long movieItemId)
        {
            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            MovieItem movieItem = movieItemDao.GetMovieItem(movieItemId);
            if (userFavorites.ContainsKey(userId))
            {
                userFavorites[userId].MovieItemList.Add(movieItem);
                userFavorites[userId].Total += movieItem.Price;
            }
            else
            {
                userFavorites.Add(userId, new Favorites(new List<MovieItem>() { movieItem }));
            }
        }
        public Favorites GetAllFavoriteMovies(long userId)
        {
            if (userFavorites.ContainsKey(userId))
            {
                return userFavorites[userId];
            }
            else
                throw new FavoritesEmptyException("Favorites List is empty");
        }

        public void RemoveFavoriteMovie(long userId, long movieItemId)
        {
            Favorites favoriteMovies = GetAllFavoriteMovies(userId);
            int movieId = favoriteMovies.MovieItemList.FindIndex(i => i.ID == movieItemId);
            userFavorites[userId].MovieItemList.Remove(favoriteMovies.MovieItemList[movieId]);
        }
    }
}