using Google.Cloud.Firestore;

namespace Domain.Models.v1.Player
{
    [FirestoreData]
    public class PlayerModel
    {
        public PlayerModel(string name, string race, string weapon)
        {
            Name = name;
            Race = race;
            Weapon = weapon;
        }

        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public string Race { get; set; }

        [FirestoreProperty]
        public string Weapon { get; set; }
    }
}
