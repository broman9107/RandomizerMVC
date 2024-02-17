using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class PlayerList
    {
        public List<PlayerModel> list;
        public PlayerList()
        {
            list = new List<PlayerModel> ();
            list.Add(new PlayerModel { id = 1, FirstName = "LeBron", LastName = "James", Position = "SF" });
            list.Add(new PlayerModel { id = 2, FirstName = "Michael", LastName = "Jordan", Position = "SG" });
            list.Add(new PlayerModel { id = 3, FirstName = "Kobe", LastName = "Bryant", Position = "SG" });
            list.Add(new PlayerModel { id = 4, FirstName = "Magic", LastName = "Johnson", Position = "PG" });
            list.Add(new PlayerModel { id = 5, FirstName = "Larry", LastName = "Bird", Position = "SF" });
            list.Add(new PlayerModel { id = 6, FirstName = "Shaquille", LastName = "O'Neal", Position = "C" });
            list.Add(new PlayerModel { id = 7, FirstName = "Tim", LastName = "Duncan", Position = "PF" });
            list.Add(new PlayerModel { id = 8, FirstName = "Hakeem", LastName = "Olajuwon", Position = "C" });
            list.Add(new PlayerModel { id = 9, FirstName = "Stephen", LastName = "Curry", Position = "PG" });
            list.Add(new PlayerModel { id = 10, FirstName = "Kevin", LastName = "Durant", Position = "SF" });
            list.Add(new PlayerModel { id = 11, FirstName = "Kareem", LastName = "Abdul-Jabbar", Position = "C" });
            list.Add(new PlayerModel { id = 12, FirstName = "Wilt", LastName = "Chamberlain", Position = "C" });
            list.Add(new PlayerModel { id = 13, FirstName = "Bill", LastName = "Russell", Position = "C" });
            list.Add(new PlayerModel { id = 14, FirstName = "Oscar", LastName = "Robertson", Position = "PG" });
            list.Add(new PlayerModel { id = 15, FirstName = "Jerry", LastName = "West", Position = "PG" });
            list.Add(new PlayerModel { id = 16, FirstName = "Karl", LastName = "Malone", Position = "PF" });
            list.Add(new PlayerModel { id = 17, FirstName = "Charles", LastName = "Barkley", Position = "PF" });
            list.Add(new PlayerModel { id = 18, FirstName = "Allen", LastName = "Iverson", Position = "SG" });
            list.Add(new PlayerModel { id = 19, FirstName = "Dwyane", LastName = "Wade", Position = "SG" });
            list.Add(new PlayerModel { id = 20, FirstName = "Dirk", LastName = "Nowitzki", Position = "PF" });
            list.Add(new PlayerModel { id = 21, FirstName = "John", LastName = "Stockton", Position = "PG" });
            list.Add(new PlayerModel { id = 22, FirstName = "Scottie", LastName = "Pippen", Position = "SF" });
            list.Add(new PlayerModel { id = 23, FirstName = "David", LastName = "Robinson", Position = "C" });
            list.Add(new PlayerModel { id = 24, FirstName = "Clyde", LastName = "Drexler", Position = "SG" });
            list.Add(new PlayerModel { id = 25, FirstName = "Kevin", LastName = "Garnett", Position = "PF" });
            list.Add(new PlayerModel { id = 26, FirstName = "Isiah", LastName = "Thomas", Position = "PG" });
            list.Add(new PlayerModel { id = 27, FirstName = "Steve", LastName = "Nash", Position = "PG" });
            list.Add(new PlayerModel { id = 28, FirstName = "Paul", LastName = "Pierce", Position = "SF" });
            list.Add(new PlayerModel { id = 29, FirstName = "Patrick", LastName = "Ewing", Position = "C" });
            list.Add(new PlayerModel { id = 30, FirstName = "Chris", LastName = "Paul", Position = "PG" });
            list.Add(new PlayerModel { id = 31, FirstName = "Kevin", LastName = "McHale", Position = "PF" });
            list.Add(new PlayerModel { id = 32, FirstName = "George", LastName = "Gervin", Position = "SG" });
            list.Add(new PlayerModel { id = 33, FirstName = "Dominique", LastName = "Wilkins", Position = "SF" });
            list.Add(new PlayerModel { id = 34, FirstName = "Elgin", LastName = "Baylor", Position = "SF" });
            list.Add(new PlayerModel { id = 35, FirstName = "Tracy", LastName = "McGrady", Position = "SG" });
            list.Add(new PlayerModel { id = 36, FirstName = "Russell", LastName = "Westbrook", Position = "PG" });
            list.Add(new PlayerModel { id = 37, FirstName = "James", LastName = "Harden", Position = "SG" });
            list.Add(new PlayerModel { id = 38, FirstName = "Carmelo", LastName = "Anthony", Position = "SF" });
            list.Add(new PlayerModel { id = 39, FirstName = "Paul", LastName = "George", Position = "SF" });
            list.Add(new PlayerModel { id = 40, FirstName = "Giannis", LastName = "Antetokounmpo", Position = "PF" });
            list.Add(new PlayerModel { id = 41, FirstName = "Anthony", LastName = "Davis", Position = "PF" });
            list.Add(new PlayerModel { id = 42, FirstName = "Kyrie", LastName = "Irving", Position = "PG" });
            list.Add(new PlayerModel { id = 43, FirstName = "Dennis", LastName = "Rodman", Position = "PF" });
            list.Add(new PlayerModel { id = 44, FirstName = "Ray", LastName = "Allen", Position = "SG" });
            list.Add(new PlayerModel { id = 45, FirstName = "Chris", LastName = "Bosh", Position = "PF" });
            list.Add(new PlayerModel { id = 46, FirstName = "Grant", LastName = "Hill", Position = "SF" });
            list.Add(new PlayerModel { id = 47, FirstName = "Vince", LastName = "Carter", Position = "SG" });
            list.Add(new PlayerModel { id = 48, FirstName = "Shaquille", LastName = "O'Neal", Position = "C" });
            list.Add(new PlayerModel { id = 49, FirstName = "Nate", LastName = "Thurmond", Position = "C" });
            list.Add(new PlayerModel { id = 50, FirstName = "Jerry", LastName = "Lucas", Position = "PF" });
            list.Add(new PlayerModel { id = 51, FirstName = "George", LastName = "Mikan", Position = "C" });
            list.Add(new PlayerModel { id = 52, FirstName = "Willis", LastName = "Reed", Position = "C" });
            list.Add(new PlayerModel { id = 53, FirstName = "Bob", LastName = "Cousy", Position = "PG" });
            list.Add(new PlayerModel { id = 54, FirstName = "Pete", LastName = "Maravich", Position = "SG" });
            list.Add(new PlayerModel { id = 55, FirstName = "Rick", LastName = "Barry", Position = "SF" });
            list.Add(new PlayerModel { id = 56, FirstName = "David", LastName = "Thompson", Position = "SG" });
            list.Add(new PlayerModel { id = 57, FirstName = "John", LastName = "Havlicek", Position = "SF" });
            list.Add(new PlayerModel { id = 58, FirstName = "Bob", LastName = "Pettit", Position = "PF" });
            list.Add(new PlayerModel { id = 59, FirstName = "Earvin", LastName = "Johnson", Position = "PG" });
            list.Add(new PlayerModel { id = 60, FirstName = "Julius", LastName = "Erving", Position = "SF" });
            list.Add(new PlayerModel { id = 61, FirstName = "Wes", LastName = "Unseld", Position = "C" });
            list.Add(new PlayerModel { id = 62, FirstName = "Bill", LastName = "Walton", Position = "C" });
            list.Add(new PlayerModel { id = 63, FirstName = "Elvin", LastName = "Hayes", Position = "PF" });
            list.Add(new PlayerModel { id = 64, FirstName = "Walt", LastName = "Frazier", Position = "PG" });
            list.Add(new PlayerModel { id = 65, FirstName = "Bob", LastName = "McAdoo", Position = "C" });
            list.Add(new PlayerModel { id = 66, FirstName = "Nate", LastName = "Archibald", Position = "PG" });
            list.Add(new PlayerModel { id = 67, FirstName = "Billy", LastName = "Cunningham", Position = "SF" });
            list.Add(new PlayerModel { id = 68, FirstName = "Yao", LastName = "Ming", Position = "C" });
            list.Add(new PlayerModel { id = 69, FirstName = "Alonzo", LastName = "Mourning", Position = "C" });
            list.Add(new PlayerModel { id = 70, FirstName = "George", LastName = "Gervin", Position = "SG" });
            list.Add(new PlayerModel { id = 71, FirstName = "Reggie", LastName = "Miller", Position = "SG" });
            list.Add(new PlayerModel { id = 72, FirstName = "Bernard", LastName = "King", Position = "SF" });
            list.Add(new PlayerModel { id = 73, FirstName = "Chris", LastName = "Webber", Position = "PF" });
            list.Add(new PlayerModel { id = 74, FirstName = "Tracy", LastName = "McGrady", Position = "SF" });
            list.Add(new PlayerModel { id = 75, FirstName = "Steve", LastName = "Kerr", Position = "PG" });
            list.Add(new PlayerModel { id = 76, FirstName = "Dikembe", LastName = "Mutombo", Position = "C" });
            list.Add(new PlayerModel { id = 77, FirstName = "Dennis", LastName = "Johnson", Position = "PG" });
            list.Add(new PlayerModel { id = 78, FirstName = "Joe", LastName = "Dumars", Position = "SG" });
            list.Add(new PlayerModel { id = 79, FirstName = "Dwight", LastName = "Howard", Position = "C" });
            list.Add(new PlayerModel { id = 80, FirstName = "Amar'e", LastName = "Stoudemire", Position = "PF" });
            list.Add(new PlayerModel { id = 81, FirstName = "Chauncey", LastName = "Billups", Position = "PG" });
            list.Add(new PlayerModel { id = 82, FirstName = "Sam", LastName = "Jones", Position = "SG" });
            list.Add(new PlayerModel { id = 83, FirstName = "Dave", LastName = "Cowens", Position = "C" });
            list.Add(new PlayerModel { id = 84, FirstName = "Walt", LastName = "Bellamy", Position = "C" });
            list.Add(new PlayerModel { id = 85, FirstName = "Paul", LastName = "Arizin", Position = "SF" });
            list.Add(new PlayerModel { id = 86, FirstName = "George", LastName = "Mikan", Position = "C" });
            list.Add(new PlayerModel { id = 87, FirstName = "Bill", LastName = "Sharman", Position = "SG" });
            list.Add(new PlayerModel { id = 88, FirstName = "Tom", LastName = "Heinsohn", Position = "PF" });
            list.Add(new PlayerModel { id = 89, FirstName = "Nate", LastName = "Thurmond", Position = "C" });
            list.Add(new PlayerModel { id = 90, FirstName = "Pau", LastName = "Gasol", Position = "PF" });
            list.Add(new PlayerModel { id = 91, FirstName = "Kevin", LastName = "Love", Position = "PF" });
            list.Add(new PlayerModel { id = 92, FirstName = "Ben", LastName = "Wallace", Position = "C" });
            list.Add(new PlayerModel { id = 93, FirstName = "Shawn", LastName = "Kemp", Position = "PF" });
            list.Add(new PlayerModel { id = 94, FirstName = "Chris", LastName = "Mullin", Position = "SF" });
            list.Add(new PlayerModel { id = 95, FirstName = "Vlade", LastName = "Divac", Position = "C" });
            list.Add(new PlayerModel { id = 96, FirstName = "Tim", LastName = "Hardaway", Position = "PG" });
            list.Add(new PlayerModel { id = 97, FirstName = "Tony", LastName = "Parker", Position = "PG" });
            list.Add(new PlayerModel { id = 98, FirstName = "Chris", LastName = "Bosh", Position = "C" });
            list.Add(new PlayerModel { id = 99, FirstName = "Kevin", LastName = "McHale", Position = "PF" });
            list.Add(new PlayerModel { id = 100, FirstName = "Dennis", LastName = "Rodman", Position = "PF" });

        }

        public IEnumerable<PlayerModel> OrderListByLastName()
        {
            IEnumerable<PlayerModel> list2 = list.OrderBy(p => p.LastName);
            return list2;
        }

        public IEnumerable<PlayerModel> OrderListByFirstName()
        {
            IEnumerable<PlayerModel> list2 = list.OrderBy(p => p.FirstName);
            return list2;
        }

        public IEnumerable<PlayerModel> OrderListByPosition()
        {
            IEnumerable<PlayerModel> list2 = list.OrderBy(p => p.Position);
            return list2;
        }
        public void AddToList(PlayerModel player)
        {
            if(list.Count == 0)
            {
                player.id = 1;
            }
            else 
            { 
                int highestId = list.Max(x => x.id);
                player.id = highestId + 1;
            }
            list.Add(player);
        }

        public void RemoveFromList(PlayerModel player)
        {
            PlayerModel playertoremove = list.Find(x => x.id == player.id);
            list.Remove(playertoremove);
        }

        public List<PlayerModel> Randomize(int i)
        {
            Random rnd = new Random();
            List<PlayerModel> players = new List<PlayerModel>();
            for (int j = 0; j < i; j++)
            {
                players.Add(list[rnd.Next(list.Count)]);
            }
            return players;
        }
    }
}
