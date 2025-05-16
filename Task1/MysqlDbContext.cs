using Microsoft.EntityFrameworkCore;

namespace Task1;

public class MysqlDbContext : DbContext
{
    private readonly string _connectionString;
    public MysqlDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
}