using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CoreDepartman.Models
{

	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-QLASOVO\\SQLEXPRESS; database=corepersonelDB; integrated security=true;");
		}


		//Bu kod parçası, Entity Framework Code-First yaklaşımını kullanarak iki farklı veritabanı
		//tablosunu model sınıflarına bağladığınızı göstermektedir.DbSet özellikleri, model sınıflarını veritabanı tablolarına bağlamak için kullanılır.
		//Aşağıdaki ifadeler, departmanlar adlı model sınıfını veritabanında departmanlars adında bir tabloya bağladığınızı belirtir.
		public DbSet<departmanlar> departmanlars { get; set; }

	}
}
