using YourNamespace.Models;

namespace YourNamespace.Services
{
    public class UserService
    {
        private readonly List<User> _users = [];

        public void AddUser(User user)
        {
            _users.Add(user);
            Console.WriteLine($"Utilisateur ajouté: {user.Name}");
        }

        public User GetUserByName(string name)
        {
#pragma warning disable CS8603 // Existence possible d'un retour de référence null.
            return _users.Find(u => u.Name == name);
#pragma warning restore CS8603 // Existence possible d'un retour de référence null.
        }

        public void DisplayAllUsers()
        {
            foreach (var user in _users)
            {
                Console.WriteLine($"Nom: {user.Name}. Âge: {user.Age} ans.");
            }
        }
    }
}
