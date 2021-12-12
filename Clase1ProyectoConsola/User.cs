class User
{
    private string? Name { get; set; }

    private string? Surname { get; set; }

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