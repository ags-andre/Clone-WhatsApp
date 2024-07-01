namespace WhatsApp_API.Users
{
    public class UserFakeDB
    {
        public static readonly List<User> Users = [
            new User(id: new Guid("f896512a-4056-47a8-8ba4-dc219b3fdd1d"), name: "Harry Potter"),
            new User(id: new Guid("8d854b25-6089-4675-8bdc-0f3bbaa1323f"), name: "Albus Dumbledore"),
            new User(id: new Guid("f6f01b94-d8e3-4c1f-9882-b589a3e80350"), name: "lord Valdemort")
        ]; 
    }
}
