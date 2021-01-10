using System;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace MySQL_Demo
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Music> Musics{get;set;}
        public DbSet<Singer> Singers{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseMySQL(@"Server=localhost;
            port=3306;
            Database=test;
            Uid=root;
            Pwd=root;
            Allow User Variables=True;
            sslMode=None;");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public class Music
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Game { get; set; }
        public DateTime PublishTime { get; set; }
    }

    public class Singer
    {
        public int Id  { get; set; }
        public string Name { get; set; }
    }
}
