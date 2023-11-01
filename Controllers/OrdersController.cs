using KrustyKrab.Data;
using KrustyKrab.Models;
using Microsoft.AspNetCore.Mvc;

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
        var orders = _dbContext.Orders;
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
            c.ComboItemDtos.ForEach(ci =>
            {
                ComboItem newComboItem = new()
                {
                    ComboId = c.Id,
                    ItemId = ci.OrderItemId,
                    OrderId = orderDto.Order.Id
                };
                _dbContext.ComboItems.Add(newComboItem);
            });
        });
        _dbContext.SaveChanges();
        return Ok();
    }
}