using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEnerio.Components
{
    public partial class PCGatoComponent : Component
    {
        public PCGatoComponent()
        {
            InitializeComponent();
        }

        public PCGatoComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }

    namespace ProductNamespace
    {
        abstract class Product
        {
            protected string product_name;
            protected int product_price;
            protected int product_quantity;

            public Product(string name, int price, int quantity)
            {
                product_name = name;
                product_price = price;
                product_quantity = quantity;
            }

            public abstract double getTotalPrice();

            public abstract void setPayment(double amount);
        }
        /*
        class DiscountedItem : Product
        {
            private double item_discount;
            private double discounted_price;
            private double payment_amount;
            private double change;

            public DiscountedItem(string name, int price, int quantity, double discount) : base(name, price, quantity)
            {
                item_discount = discount;
            }

            public override double getTotalPrice()
            {
                return discounted_price = (item_price - (item_price * (item_discount / 100))) * item_quantity;
            }

            public override void setPayment(double amount)
            {
                payment_amount = amount;
            }

            public double getChange()
            {
                return change = payment_amount - discounted_price;
            }
        }*/
    }
}
