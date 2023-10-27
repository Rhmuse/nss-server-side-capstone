using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using KrustyKrab.Models;

namespace KrustyKrab.Data;

public class KrustyKrabDbContext : IdentityDbContext<IdentityUser>
{
    private readonly IConfiguration _configuration;
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Burger> Burgers { get; set; }
    public DbSet<BurgerTopping> BurgerToppings { get; set; }
    public DbSet<OrderDrink> OrderDrinks { get; set; }
    public DbSet<OrderSide> OrderSides { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Side> Sides { get; set; }
    public DbSet<Drink> Drinks { get; set; }
    public DbSet<OrderType> OrderTypes { get; set; }
    public DbSet<Combo> Combos { get; set; }
    public DbSet<ComboItem> ComboItems { get; set; }
    public DbSet<Size> Sizes { get; set; }

    public KrustyKrabDbContext(DbContextOptions<KrustyKrabDbContext> context, IConfiguration config) : base(context)
    {
        _configuration = config;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Starting Ids
        //// Ids
        // Userprofile
        Guid patrickUPId = Guid.NewGuid();
        Guid squidwardUPId = Guid.NewGuid();
        // IdentityUser 
        string spongebobId = Guid.NewGuid().ToString();
        string mrkrabsId = Guid.NewGuid().ToString();
        string squidwardId = Guid.NewGuid().ToString();
        string patrickId = Guid.NewGuid().ToString();
        // IdentityRole
        string employeeIRId = Guid.NewGuid().ToString();
        // Combos
        Guid krabbyPattyComboId = Guid.NewGuid();
        Guid doubleKrabbyPattyComboId = Guid.NewGuid();
        // Burgers
        Guid firstBurgerId = Guid.NewGuid();
        Guid firstComboBurgerId = Guid.NewGuid();
        Guid secondComboBurgerId = Guid.NewGuid();
        // Drinks
        Guid drKelpId = Guid.NewGuid();
        Guid dietDrKelpId = Guid.NewGuid();
        Guid redTidepId = Guid.NewGuid();
        Guid kelpShakeId = Guid.NewGuid();
        Guid seafoamSodaId = Guid.NewGuid();
        Guid waterId = Guid.NewGuid();
        // Orders
        Guid firstOrderId = Guid.NewGuid();
        // Sides
        Guid coralBitsId = Guid.NewGuid();
        Guid barnacleRingsId = Guid.NewGuid();
        Guid kelpFriesId = Guid.NewGuid();
        Guid oysterSkinsId = Guid.NewGuid();
        Guid seaweedSaladId = Guid.NewGuid();
        // OrderTypes
        Guid hereId = Guid.NewGuid();
        Guid togoId = Guid.NewGuid();
        Guid pickupId = Guid.NewGuid();
        // OrderDrinks
        Guid orderDrinkId = Guid.NewGuid();
        // OrderSide 
        Guid orderSideId = Guid.NewGuid();
        // Toppings
        Guid lettuceId = Guid.NewGuid();
        Guid tomatoId = Guid.NewGuid();
        Guid pickleId = Guid.NewGuid();
        Guid onionId = Guid.NewGuid();
        Guid mustardId = Guid.NewGuid();
        Guid ketchupId = Guid.NewGuid();
        Guid secretSauceId = Guid.NewGuid();
        Guid pattyId = Guid.NewGuid();
        Guid bunId = Guid.NewGuid();
        Guid cheeseId = Guid.NewGuid();
        // Sizes
        Guid smallId = Guid.NewGuid();
        Guid mediumId = Guid.NewGuid();
        Guid largeId = Guid.NewGuid();
        #endregion

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole[]
        {
           new IdentityRole{ Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", Name = "Admin", NormalizedName = "admin" },
           new IdentityRole{ Id = employeeIRId, Name = "Employee", NormalizedName = "employee"},
        });



        modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser[]
        {
            new IdentityUser{ Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", UserName = "Administrator", Email = "admina@strator.comx", PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])},
            new IdentityUser{ Id = spongebobId, UserName = "ssquarepants", Email = "jellyfanatic12@goofygoober.com", PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])},
            new IdentityUser{ Id = mrkrabsId, UserName = "ekrabs", Email = "saltydog@seamail.com", PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])},
            new IdentityUser{ Id = squidwardId, UserName = "stentacles", Email = "stentacles2@seamail.com", PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])},
            new IdentityUser{ Id = patrickId, UserName = "pstar", Email = "patrickstar@goofygoober.com", PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])},
        });

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>[]
        {
            new IdentityUserRole<string>{ RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f" },
            new IdentityUserRole<string>{ RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", UserId = mrkrabsId },
            new IdentityUserRole<string>{ RoleId = employeeIRId, UserId = spongebobId},
            new IdentityUserRole<string>{ RoleId = employeeIRId, UserId = squidwardId}
        });

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
        {
            new UserProfile { Id = Guid.NewGuid(), IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", FirstName = "Admina", LastName = "Strator", Address = "101 Main Street"},
            new UserProfile { Id = Guid.NewGuid(), IdentityUserId = spongebobId, FirstName = "SpongeBob", LastName = "SquarePants", Address = "124 Conch Street"},
            new UserProfile { Id = squidwardUPId, IdentityUserId = squidwardId, FirstName = "Squidward", LastName = "Tentacles", Address = "122 Conch Street"},
            new UserProfile { Id = Guid.NewGuid(), IdentityUserId = mrkrabsId, FirstName = "Eugene", LastName = "Krabs", Address = "3541 Anchor Way"},
            new UserProfile { Id = patrickUPId, IdentityUserId = patrickId, FirstName = "Patrick", LastName = "Star", Address = "120 Conch Street"},
        });

        modelBuilder.Entity<Burger>().HasData(new Burger[]
        {
            new Burger{ Id = firstBurgerId, Quantity = 1, OrderId = firstOrderId },
            new Burger{ Id = firstComboBurgerId, Quantity = 1, Name = "krabby patty" },
            new Burger{ Id = secondComboBurgerId, Quantity = 1, Name = "double krabby patty" }
        });

        modelBuilder.Entity<Combo>().HasData(new Combo[]
        {
            new Combo{ Id = krabbyPattyComboId,  Name = "krabby patty combo", Discount = -1.00F, BurgerId = firstComboBurgerId },
            new Combo{ Id = doubleKrabbyPattyComboId,  Name = "double krabby patty combo", Discount = -1.25F, BurgerId = secondComboBurgerId },
        });

        modelBuilder.Entity<BurgerTopping>().HasData(new BurgerTopping[]
        {
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = secretSauceId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = lettuceId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = tomatoId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = pickleId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = onionId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = pattyId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = pattyId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = ketchupId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = mustardId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = secondComboBurgerId, ToppingId = bunId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstComboBurgerId, ToppingId = secretSauceId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstComboBurgerId, ToppingId = lettuceId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstComboBurgerId, ToppingId = tomatoId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstComboBurgerId, ToppingId = pickleId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstComboBurgerId, ToppingId = onionId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstComboBurgerId, ToppingId = pattyId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstComboBurgerId, ToppingId = ketchupId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstComboBurgerId, ToppingId = mustardId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstComboBurgerId, ToppingId = bunId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = secretSauceId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = lettuceId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = tomatoId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = pickleId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = onionId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = pattyId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = pattyId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = ketchupId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = mustardId },
            new BurgerTopping{ Id = Guid.NewGuid(), BurgerId = firstBurgerId, ToppingId = bunId },
        });

        modelBuilder.Entity<Drink>().HasData(new Drink[]
        {
            new Drink{ Id = drKelpId, Name = "dr. kelp", Price = 1.00F },
            new Drink{ Id = dietDrKelpId, Name = "diet dr. kelp", Price = 1.00F },
            new Drink{ Id = redTidepId, Name = "red tide", Price = 1.00F },
            new Drink{ Id = kelpShakeId, Name = "kelp shake", Price = 1.50F },
            new Drink{ Id = seafoamSodaId, Name = "seafoam soda", Price = 1.00F },
            new Drink{ Id = waterId, Name = "water", Price = 0.10F }
        });

        modelBuilder.Entity<Order>().HasData(new Order[]
        {
            new Order{ Id = firstOrderId, CustomerId = patrickUPId, EmployeeId = squidwardUPId, OrderTypeId = hereId }
        });

        modelBuilder.Entity<OrderDrink>().HasData(new OrderDrink[]
        {
            new OrderDrink{ Id = orderDrinkId, DrinkId = redTidepId, OrderId = firstOrderId, Quantity = 1, SizeId = mediumId }
        });

        modelBuilder.Entity<OrderSide>().HasData(new OrderSide[]
        {
            new OrderSide{ Id = orderSideId, OrderId = firstOrderId, SideId = coralBitsId, Quantity = 1, SizeId = largeId }
        });

        modelBuilder.Entity<OrderType>().HasData(new OrderType[]
        {
            new OrderType{ Id = hereId, Name = "here"},
            new OrderType{ Id = togoId, Name = "togo"},
            new OrderType{ Id = pickupId, Name = "pickup"},

        });

        modelBuilder.Entity<Side>().HasData(new Side[]
        {
            new Side{ Id = coralBitsId, Name = "coral bits", Price = 1.25F },
            new Side{ Id = barnacleRingsId, Name = "barnacle rings", Price = 1.25F },
            new Side{ Id = kelpFriesId, Name = "kelp fries", Price = 1.25F },
            new Side{ Id = oysterSkinsId, Name = "oyster skins", Price = 1.25F },
            new Side{ Id = seaweedSaladId, Name = "seaweed salad", Price =  2.00F}
        });

        modelBuilder.Entity<Topping>().HasData(new Topping[]
        {
            new Topping{ Id = lettuceId, Name = "lettuce", Price = .05F},
            new Topping{ Id = tomatoId, Name = "tomato", Price = .05F},
            new Topping{ Id = pickleId, Name = "pickle", Price = .05F},
            new Topping{ Id = onionId, Name = "onion", Price = .05F},
            new Topping{ Id = mustardId, Name = "mustard", Price = 0},
            new Topping{ Id = ketchupId, Name = "ketchup", Price = 0},
            new Topping{ Id = secretSauceId, Name = "secret sauce", Price = 0},
            new Topping{ Id = pattyId, Name = "patty", Price = 1.00F},
            new Topping{ Id = bunId, Name = "bun", Price = .20F},
            new Topping{ Id = cheeseId, Name = "sea cheese", Price = .25F}
        });

        modelBuilder.Entity<ComboItem>().HasData(new ComboItem[]
        {
           new ComboItem{ Id = Guid.NewGuid(), ComboId = doubleKrabbyPattyComboId, ItemId = firstBurgerId, OrderId = firstOrderId },
           new ComboItem{ Id = Guid.NewGuid(), ComboId = doubleKrabbyPattyComboId, ItemId = orderSideId, OrderId = firstOrderId },
           new ComboItem{ Id = Guid.NewGuid(), ComboId = doubleKrabbyPattyComboId, ItemId = orderDrinkId,  OrderId = firstOrderId }
        });

        modelBuilder.Entity<Size>().HasData(new Size[]
        {
            new Size{ Id = smallId, Name = "small", ShortHand = "sm", Price = 0},
            new Size{ Id = mediumId, Name = "medium", ShortHand = "md", Price = 0.20F},
            new Size{ Id = largeId, Name = "large", ShortHand = "lg", Price= 0.45F}
        });
    }
}