using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class PlayerList
    {
        public List<PlayerModel> list;
        public PlayerList()
        {
            list = new List<PlayerModel> ();
            list.Add(new PlayerModel { id = 1, FirstName = "Bro", LastName = "Guy", Position = "PG" });
            list.Add(new PlayerModel { id = 2, FirstName = "John", LastName = "Doe", Position = "SG" });
            list.Add(new PlayerModel { id = 3, FirstName = "Mike", LastName = "Smith", Position = "SF" });
            list.Add(new PlayerModel { id = 4, FirstName = "Chris", LastName = "Johnson", Position = "PF" });
            list.Add(new PlayerModel { id = 5, FirstName = "David", LastName = "Brown", Position = "C" });
            list.Add(new PlayerModel { id = 6, FirstName = "Matt", LastName = "Williams", Position = "PG" });
            list.Add(new PlayerModel { id = 7, FirstName = "Alex", LastName = "Taylor", Position = "SG" });
            list.Add(new PlayerModel { id = 8, FirstName = "Josh", LastName = "Anderson", Position = "SF" });
            list.Add(new PlayerModel { id = 9, FirstName = "Ryan", LastName = "Martinez", Position = "PF" });
            list.Add(new PlayerModel { id = 10, FirstName = "Kevin", LastName = "Garcia", Position = "C" });
            list.Add(new PlayerModel { id = 11, FirstName = "Jason", LastName = "Hernandez", Position = "PG" });
            list.Add(new PlayerModel { id = 12, FirstName = "Eric", LastName = "Young", Position = "SG" });
            list.Add(new PlayerModel { id = 13, FirstName = "Steven", LastName = "Rodriguez", Position = "SF" });
            list.Add(new PlayerModel { id = 14, FirstName = "Justin", LastName = "Lee", Position = "PF" });
            list.Add(new PlayerModel { id = 15, FirstName = "Andrew", LastName = "Moore", Position = "C" });
            list.Add(new PlayerModel { id = 16, FirstName = "Robert", LastName = "White", Position = "PG" });
            list.Add(new PlayerModel { id = 17, FirstName = "William", LastName = "Lopez", Position = "SG" });
            list.Add(new PlayerModel { id = 18, FirstName = "Edward", LastName = "Harris", Position = "SF" });
            list.Add(new PlayerModel { id = 19, FirstName = "Brian", LastName = "Clark", Position = "PF" });
            list.Add(new PlayerModel { id = 20, FirstName = "Ronald", LastName = "Lewis", Position = "C" });
            list.Add(new PlayerModel { id = 21, FirstName = "Anthony", LastName = "Young", Position = "PG" });
            list.Add(new PlayerModel { id = 22, FirstName = "Thomas", LastName = "Walker", Position = "SG" });
            list.Add(new PlayerModel { id = 23, FirstName = "Daniel", LastName = "Hall", Position = "SF" });
            list.Add(new PlayerModel { id = 24, FirstName = "Paul", LastName = "Allen", Position = "PF" });
            list.Add(new PlayerModel { id = 25, FirstName = "Mark", LastName = "King", Position = "C" });
            list.Add(new PlayerModel { id = 26, FirstName = "Charles", LastName = "Baker", Position = "PG" });
            list.Add(new PlayerModel { id = 27, FirstName = "Joseph", LastName = "Wright", Position = "SG" });
            list.Add(new PlayerModel { id = 28, FirstName = "Frank", LastName = "Adams", Position = "SF" });
            list.Add(new PlayerModel { id = 29, FirstName = "David", LastName = "Nelson", Position = "PF" });
            list.Add(new PlayerModel { id = 30, FirstName = "George", LastName = "Carter", Position = "C" });
            list.Add(new PlayerModel { id = 31, FirstName = "Kenneth", LastName = "Mitchell", Position = "PG" });
            list.Add(new PlayerModel { id = 32, FirstName = "Raymond", LastName = "Perez", Position = "SG" });
            list.Add(new PlayerModel { id = 33, FirstName = "Anthony", LastName = "Roberts", Position = "SF" });
            list.Add(new PlayerModel { id = 34, FirstName = "Scott", LastName = "Turner", Position = "PF" });
            list.Add(new PlayerModel { id = 35, FirstName = "Steven", LastName = "Phillips", Position = "C" });
            list.Add(new PlayerModel { id = 36, FirstName = "Timothy", LastName = "Campbell", Position = "PG" });
            list.Add(new PlayerModel { id = 37, FirstName = "Ronald", LastName = "Parker", Position = "SG" });
            list.Add(new PlayerModel { id = 38, FirstName = "Aaron", LastName = "Evans", Position = "SF" });
            list.Add(new PlayerModel { id = 39, FirstName = "Jesse", LastName = "Edwards", Position = "PF" });
            list.Add(new PlayerModel { id = 40, FirstName = "David", LastName = "Collins", Position = "C" });
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
    }
}
