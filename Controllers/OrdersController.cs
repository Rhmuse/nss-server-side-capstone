using KrustyKrab.Data;
using KrustyKrab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KrustyKrab.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private KrustyKrabDbContext _dbContext;

    public OrdersController(KrustyKrabDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var orders = _dbContext.Orders
            .Include(o => o.Burgers)
            .ThenInclude(b => b.BurgerToppings)
            .ThenInclude(bt => bt.Topping)
            .Include(o => o.Sides)
            .ThenInclude(s => s.Side)
            .Include(o => o.Drinks)
            .ThenInclude(d => d.Drink)
            .Include(o => o.OrderType)
            .Include(o => o.OrderCombos)
            .ThenInclude(oc => oc.OrderDrink)
            .Include(o => o.OrderCombos)
            .ThenInclude(oc => oc.OrderSide)
            .Include(o => o.OrderCombos)
            .ThenInclude(oc => oc.Burger)
            .ToList();
        return Ok(orders);
    }

    [HttpPost]
    public IActionResult Post(OrderDto orderDto)
    {
        _dbContext.Orders.Add(orderDto.Order);

        orderDto.OrderDrinkDtos.ForEach(d =>
        {
            OrderDrink newOrderDrink = new()
            {
                DrinkId = d.DrinkId,
                OrderId = orderDto.Order.Id,
                Quantity = d.Quantity,
                SizeId = d.SizeId,

            };
            _dbContext.OrderDrinks.Add(newOrderDrink);
            System.Console.WriteLine("stop");
        });

        orderDto.OrderSideDtos.ForEach(s =>
        {
            OrderSide newOrderSide = new()
            {
                SideId = s.SideId,
                OrderId = orderDto.Order.Id,
                Quantity = s.Quantity,
                SizeId = s.SizeId
            };
            _dbContext.OrderSides.Add(newOrderSide);
        });

        orderDto.BurgerDtos.ForEach(b =>
        {
            Burger newBurger = new()
            {
                OrderId = orderDto.Order.Id,
                Quantity = b.Quantity
            };
            _dbContext.Burgers.Add(newBurger);

            b.BurgerToppingDtos.ForEach(bt =>
            {
                BurgerTopping newBurgerTopping = new()
                {
                    BurgerId = newBurger.Id,
                    ToppingId = bt.ToppingId,
                    Extra = bt.Extra,
                };
                _dbContext.BurgerToppings.Add(newBurgerTopping);
            });
        });

        orderDto.ComboDtos.ForEach(c =>
        {
            OrderCombo newOrderCombo = new()
            {
                ComboId = c.Id,
                OrderId = orderDto.Order.Id,
                Quantity = c.Quantity,
            };
            _dbContext.OrderCombos.Add(newOrderCombo);

            OrderDrink newOrderDrink = new()
            {
                OrderId = orderDto.Order.Id,
                DrinkId = c.OrderDrinkDto.DrinkId,
                SizeId = c.OrderDrinkDto.SizeId,
                OrderComboId = newOrderCombo.Id,
                Quantity = c.Quantity,
                IsInCombo = true,
            };
            _dbContext.OrderDrinks.Add(newOrderDrink);

            OrderSide newOrderSide = new()
            {
                OrderId = orderDto.Order.Id,
                SideId = c.OrderSideDto.SideId,
                SizeId = c.OrderSideDto.SizeId,
                OrderComboId = newOrderCombo.Id,
                Quantity = c.Quantity,
                IsInCombo = true,

            };
            _dbContext.OrderSides.Add(newOrderSide);

            Burger newBurger = new()
            {
                OrderId = orderDto.Order.Id,
                Quantity = c.Quantity,
                IsInCombo = true,
            };
            _dbContext.Burgers.Add(newBurger);
            c.BurgerDto.BurgerToppingDtos.ForEach(bt =>
            {
                BurgerTopping newBurgerTopping = new()
                {
                    BurgerId = newBurger.Id,
                    ToppingId = bt.ToppingId,
                    Extra = bt.Extra,
                };
                _dbContext.BurgerToppings.Add(newBurgerTopping);
            });
        });
        _dbContext.SaveChanges();
        return Ok();
    }
}