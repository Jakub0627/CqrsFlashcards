using CqrsFlashcards.Models;
using Microsoft.EntityFrameworkCore;

namespace CqrsFlashcards.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Flashcard> Flashcards { get; set; }
    }
}
