using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalPlan.Model;

namespace TechnicalPlan.Contexts
{
    /// <summary>
    /// Контекст базы данных для управления сущностями техплана.
    /// </summary>
    public class TechPlanDBContext:DbContext
    {
        /// <summary>
        /// Набор титульных листов в базе данных.
        /// </summary>
        public DbSet<TitlePage> TitlePages { get; set; }

        /// <summary>
        /// Настраивает параметры подключения к базе данных SQLite.
        /// </summary>
        /// <param 
        ///     name="optionsBuilder">Строитель опций для контекста базы данных.
        /// </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mydatabase.db");
        }
    }
}
