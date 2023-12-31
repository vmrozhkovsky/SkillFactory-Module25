﻿namespace EF;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    public string Role { get; set; }
    public List<Book> UserBook { get; set; } = new List<Book>();
}