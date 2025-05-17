using Microsoft.EntityFrameworkCore;

namespace Task1;

public class MysqlDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = "DataSource=localhost;DataBase=task1;UserID=root;Password=root";
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}