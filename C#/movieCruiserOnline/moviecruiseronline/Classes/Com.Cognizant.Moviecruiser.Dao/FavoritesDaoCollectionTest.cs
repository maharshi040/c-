using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public class FavoritesDaoCollectionTest
    {
        static string format = "{0,-10}{1,-20}{2,-15}{3,-10}{4,-15}{5,-15}{6}";
        static string heading = string.Format(format, "ID", "Name", "Price", "Active", "Date of Launch", "Category", "Free Delivery");
        public FavoritesDaoCollectionTest()
        {
            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            List<MovieItem> movieItemList = movieItemDao.GetMovieItemListAdmin();
            Console.WriteLine("Available Items:\n" + heading);
            foreach (MovieItem item in MovieItemList)
            {
                Console.WriteLine(item);
            }
            string choice;
            FavoritesDaoCollection favoritesDao = new FavoritesDaoCollection();
            Console.WriteLine();
            l1: Console.Write("1. Add To Favorite\n2. Remove Favorite Movie\n3. Get All Favorite Movies\n\nEnter your choice: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        TestAddCartItem(favoritesDao);
                        goto l1;
                    }
                case "2":
                    {
                        TestRemoveCartItem(favoritesDao);
                        goto l1;
                    }
                case "3":
                    {
                        TestGetAllCartItems(favoritesDao);
                        goto l1;
                    }
                default:
                    {
                        Console.WriteLine("Exiting...");
                        break;
                    }

            }
            Console.WriteLine();
        }
        public static void TestAddCartItem(FavoritesDaoCollection favoritesDao)
        {
            Console.Write("Enter User ID: ");
            long userId = long.Parse(Console.ReadLine());
            Console.Write("Enter Movie ID to add to user favorites: ");
            long movieId = long.Parse(Console.ReadLine());
            favoritesDao.AddFavoriteMovie(userId, movieId);
            Favorites favoriteMovies = favoritesDao.GetAllFavoriteMovie(userId);
            Console.WriteLine("\nAfter adding entered movie in favorites...\n\n" + list);
            foreach (MovieItem movie in cartItems.MovieItemList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
        }
        public static void TestRemoveCartItem(FavoritesDaoCollection favoritesDao)
        {
            try
            {
                Console.Write("Enter User ID: ");
                long userId = long.Parse(Console.ReadLine());
                Favorites favoriteMovies = favoritesDao.GetAllFavoriteMovies(userId);
                Console.WriteLine("\n" + heading);
                foreach (MovieItem movie in favoriteMovies.MovieItemList)
                {
                    Console.WriteLine(movie);
                }
                Console.Write("Enter Movie ID to remove from user favorites: ");
                long movieId = long.Parse(Console.ReadLine());
                favoritesDao.RemoveFavoriteMovie(userId, movieId);
                favoriteMovies = favoritesDao.GetAllFavoriteMovies(userId);
                Console.WriteLine("\n" + heading);
                foreach (MovieItem movie in favoriteMovies.MovieItemList)
                {
                    Console.WriteLine(movie);
                }
                Console.WriteLine();
                throw new FavoritesEmptyException();
            }
            catch (FavoritesEmptyException e)
            {
                Console.WriteLine("\n" + e.Message + "\n");
            }
        }
        public static void TestGetAllCartItems(FavoritesDaoCollection favoritesDao)
        {
            try
            {
                Console.Write("Enter User ID: ");
                long userId = long.Parse(Console.ReadLine());
                Favorites favoriteMovies = favoritesDao.GetAllFavoriteMovies(userId);
                Console.WriteLine("\n" + heading);
                foreach (MovieItem movie in favoriteMovies.MovieItemList)
                {
                    Console.WriteLine(movie);
                }
                Console.WriteLine();
                throw new FavoritesEmptyException();
            }
            catch (FavoritesEmptyException e)
            {
                Console.WriteLine("\n" + e.Message + "\n");
            }
        }
    }
}