using ChatMessenger.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatMessenger.Services;

public class ChatContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Message> Messages { get; set; }

    public ChatContext(DbContextOptions<ChatContext> options) : base(options) { }
}
