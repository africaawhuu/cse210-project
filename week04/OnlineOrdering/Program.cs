using System;
using System.Collections.Generic;

namespace EncapsulationOnlineOrdering
{
    // =========================================================================
    // ADDRESS CLASS
    // =========================================================================
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;
        }

        public bool IsInUSA()
        {
            return _country.Trim().Equals("USA", StringComparison.OrdinalIgnoreCase) ||
                   _country.Trim().Equals("United States", StringComparison.OrdinalIgnoreCase);
        }

        public string GetFormattedAddress()
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }
    }

    // =========================================================================
    // CUSTOMER CLASS
    // =========================================================================
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }

        public string GetName()
        {
            return _name;
        }

        public Address GetAddress()
        {
            return _address;
        }
    }

    // =========================================================================
    // PRODUCT CLASS
    // =========================================================================
    public class Product
    {
        private string _name;
        private string _productId;
        private double _price;
        private int _quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        public double GetTotalCost()
        {
            return _price * _quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }
    }

    // =========================================================================
    // ORDER CLASS
    // =========================================================================
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalCost()
        {
            double subtotal = 0;
            foreach (Product product in _products)
            {
                subtotal += product.GetTotalCost();
            }

            double shippingCost = _customer.IsInUSA() ? 5.00 : 35.00;
            return subtotal + shippingCost;
        }

        public string GetPackingLabel()
        {
            string label = "PACKING LABEL:\n";
            foreach (Product product in _products)
            {
                label += $"  - [ID: {product.GetProductId()}] {product.GetName()}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            string label = "SHIPPING LABEL:\n";
            label += $"  {_customer.GetName()}\n";
            label += $"  {_customer.GetAddress().GetFormattedAddress().Replace("\n", "\n  ")}\n";
            return label;
        }
    }

    // =========================================================================
    // MAIN PROGRAM EXECUTION
    // =========================================================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ONLINE ORDERING SYSTEM REPORT\n");

            // -----------------------------------------------------------------
            // ORDER 1: Domestic USA Customer
            // -----------------------------------------------------------------
            Address address1 = new Address("730 S 2nd W", "Rexburg", "ID", "USA");
            Customer customer1 = new Customer("Africaawhuu E'dahunsi", address1);
            Order order1 = new Order(customer1);

            order1.AddProduct(new Product("Mechanical Keyboard", "KBD-101", 79.99, 1));
            order1.AddProduct(new Product("Ergonomic Mouse", "MSE-202", 29.50, 1));
            order1.AddProduct(new Product("USB-C Cable (6ft)", "CBL-303", 8.99, 2));

            DisplayOrderDetails(order1, 1);

            // -----------------------------------------------------------------
            // ORDER 2: International Customer
            // -----------------------------------------------------------------
            Address address2 = new Address("15 Marina Road", "Lagos", "Lagos State", "Nigeria");
            Customer customer2 = new Customer("Amina Bello", address2);
            Order order2 = new Order(customer2);

            order2.AddProduct(new Product("27-inch 4K Monitor", "MON-404", 320.00, 1));
            order2.AddProduct(new Product("Monitor Desk Mount", "MNT-505", 45.00, 1));

            DisplayOrderDetails(order2, 2);
        }

        static void DisplayOrderDetails(Order order, int orderNum)
        {
            Console.WriteLine($"=================== ORDER #{orderNum} ===================");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"TOTAL PRICE: ${order.CalculateTotalCost():F2}");
            Console.WriteLine("=====================================================\n");
        }
    }
}