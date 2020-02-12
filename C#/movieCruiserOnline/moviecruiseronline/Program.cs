using Com.Cognizant.Moviecruiser.Dao;
using System;

namespace movieCruiserOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            MovieItemDaoCollectionTest movieItemDaoCollectionTest;
            FavoritesDaoCollectionTest favoritesDaoCollectionTest;
            l1: Console.Write("1. Movie List\n2. Favorites\n\nEnter your choice: ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        movieItemDaoCollectionTest = new MovieItemDaoCollectionTest();
                        goto l1;
                    }
                case "2":
                    {
                        favoritesDaoCollectionTest = new FavoritesDaoCollectionTest();
                        goto l1;
                    }
                default:
                    {
                        break;
                    }
            }
            Console.Read();
        }
    }
}
