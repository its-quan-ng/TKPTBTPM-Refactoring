using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Before_ExtractMethod_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order("ORD-001", "Nguyen Thi Bich Quan");
            order.AddItem("Laptop", 15000000, 1);
            order.AddItem("Mouse", 250000, 2);
            order.AddItem("Keyboard", 800000, 1);

            order.PrintInvoice();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    class Order
    {
        public string OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order(string orderNumber, string customerName)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Items = new List<OrderItem>();
        }

        public void AddItem(string productName, double price, int quantity)
        {
            Items.Add(new OrderItem
            {
                ProductName = productName,
                Price = price,
                Quantity = quantity
            });
        }


        public void PrintInvoice()
        {
            Console.WriteLine("================================");
            Console.WriteLine("         HOA DON BAN HANG       ");
            Console.WriteLine("================================");

            Console.WriteLine($"Ma don hang: {OrderNumber}");
            Console.WriteLine($"Khach hang: {CustomerName}");
            Console.WriteLine($"Ngay lap: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("CHI TIET DON HANG:");
            foreach (var item in Items)
            {
                double itemTotal = item.Price * item.Quantity;
                Console.WriteLine($"- {item.ProductName}");
                Console.WriteLine($"  Gia: {item.Price:N0} VND x {item.Quantity}");
                Console.WriteLine($"  Thanh tien: {itemTotal:N0} VND");
            }
            Console.WriteLine("--------------------------------");

            double totalAmount = 0;
            foreach (var item in Items)
            {
                totalAmount += item.Price * item.Quantity;
            }
            double vat = totalAmount * 0.1;
            double finalAmount = totalAmount + vat;

            Console.WriteLine($"Tong tien hang: {totalAmount:N0} VND");
            Console.WriteLine($"VAT (10%): {vat:N0} VND");
            Console.WriteLine($"TONG CONG: {finalAmount:N0} VND");
            Console.WriteLine("================================");
        }
    }

    class OrderItem
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
