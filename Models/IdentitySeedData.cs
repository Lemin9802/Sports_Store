using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
	public static class IdentitySeedData
	{
		private const string adminUser = "Min98"; 
		private const string adminPassword = "Min@98";
		public static async void EnsurePopulated(IApplicationBuilder app)
		{
			AppIdentityDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AppIdentityDbContext>(); 
			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();
			}

			UserManager<IdentityUser> userManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
			
			IdentityUser user = await userManager.FindByNameAsync(adminUser); 
			if (user == null)
			{
				user = new IdentityUser("Min98"); 
				user.Email = "Min98@example.com"; 
				user.PhoneNumber = "09696969"; 
				await userManager.CreateAsync(user, adminPassword);
			}
		}
	}
}