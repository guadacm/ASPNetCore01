class User
{
    public string? Name { get; set; }

    public string? Surname { get; set; }

    public User()
    {
        
    }

    public User(string name, string surname)
    {
        this.Name=name;
        this.Surname=surname;
    }

    public string Fullname(){
        return $"{Name} {Surname}";
    }
}