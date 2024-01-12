using OrderRestaurant;
using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<User> users = new List<User>();
        List<Dish> dishes = new List<Dish>();
        List<Order> orders = new List<Order>();
        List<Menu> menus = new List<Menu>();
        List<Table> tables = new List<Table>();
        List<Payment> payments = new List<Payment>();
        List<Review> reviews = new List<Review>();
        List<Chef> chefs = new List<Chef>();
        List<Delivery> deliveries = new List<Delivery>();
        List<Tableware> tablewares = new List<Tableware>();
        List<Event> events = new List<Event>();
        List<Reservation> reservations = new List<Reservation>();
        List<PromoCode> promoCodes = new List<PromoCode>();
        List<Statistics> statistics = new List<Statistics>();

        // Создание объектов и вызов методов с вводом с консоли
        Console.Write("Enter user name: ");
        string userName = Console.ReadLine();
        Console.Write("Enter user email: ");
        string userEmail = Console.ReadLine();
        User user1 = new User(userName, userEmail);
        users.Add(user1);

        Console.Write("Enter dish name: ");
        string dishName = Console.ReadLine();
        Console.Write("Enter dish price: ");
        double dishPrice = Convert.ToDouble(Console.ReadLine());
        Dish dish1 = new Dish(dishName, dishPrice);
        dishes.Add(dish1);

        Menu menu1 = new Menu("Italian Delights");
        menu1.AddDish(dish1);
        menus.Add(menu1);

        Console.Write("Enter table number: ");
        int tableNumber = Convert.ToInt32(Console.ReadLine());
        Table table1 = new Table(tableNumber);
        tables.Add(table1);

        Order order1 = new Order(user1, table1);
        order1.AddDish(dish1);
        orders.Add(order1);

        Payment payment1 = new Payment(order1);
        payments.Add(payment1);
        payment1.DisplayPaymentDetails(); // Вывод информации о платеже

        Console.Write("Enter review comment: ");
        string reviewComment = Console.ReadLine();
        Review review1 = new Review(user1, reviewComment);
        reviews.Add(review1);

        // Добавим объекты и логику для новых классов
        Chef chef1 = new Chef("Chef John");
        chefs.Add(chef1);
        chef1.Cook(dish1);

        Delivery delivery1 = new Delivery("John's Delivery");
        deliveries.Add(delivery1);
        delivery1.Deliver(order1);

        Tableware tableware1 = new Tableware("Fancy Plates");
        tablewares.Add(tableware1);
        tableware1.SetTable(table1);

        Event event1 = new Event("Grand Opening");
        events.Add(event1);
        event1.AddParticipant(user1);

        Reservation reservation1 = new Reservation(user1, table1, DateTime.Now.AddDays(3));
        reservations.Add(reservation1);
        reservation1.ConfirmReservation();

        PromoCode promoCode1 = new PromoCode("SUMMER20", 0.2);
        promoCodes.Add(promoCode1);
        promoCode1.ApplyDiscount(order1);

        Statistics statistics1 = new Statistics();
        statistics.Add(statistics1);
        Statistics.UpdateStatistics(order1);

    }
}
