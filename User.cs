namespace SistemaGestionBiblioteca;

public class User
{
    public User(int ID, string name, string lastName, string email, string phone)
    {
        this.ID = ID;
        this.name = name;
        this.lastName = lastName;
        this.email = email;
        this.phone = phone;
    }

    public string? name, lastName, email, phone;
    public int ID;

}