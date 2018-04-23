namespace Northwind {
    using System;
    using DevExpress.Xpo;

    [Persistent("Customers")]
    public class Customer : XPLiteObject {
        public Customer(Session session) : base(session) { }

        string customerIDValue;
        [Key]
        public string CustomerID {
            get { return customerIDValue; }
            set { SetPropertyValue("CustomerID", ref customerIDValue, value); }
        }

        string contactTitleValue;
        public string ContactTitle {
            get { return contactTitleValue; }
            set { SetPropertyValue("ContactTitle", ref contactTitleValue, value); }
        }

        [Delayed]
        public string CompanyName {
            get { return GetDelayedPropertyValue<string>("CompanyName"); }
            set { SetDelayedPropertyValue("CompanyName", value); }
        }

        [Delayed]
        public string Address {
            get { return GetDelayedPropertyValue<string>("Address"); }
            set { SetDelayedPropertyValue("Address", value); }
        }        

        [Association("CustomerOrders", typeof(Order))]
        public XPCollection<Order> Orders {
            get {
                return GetCollection<Order>("Orders");
            }
        }
    }

    [Persistent("Orders")]
    public class Order : XPLiteObject {
        public Order(Session session) : base(session) { }

        [Key(true), Persistent]
        int OrderID = -1;

        [PersistentAlias("OrderID")]
        public int ID {
            get { return OrderID; }
        }

        DateTime shippedDateValue;
        public DateTime ShippedDate {
            get { return shippedDateValue; }
            set { SetPropertyValue("ShippedDate", ref shippedDateValue, value); }
        }

        Customer customerValue;
        [Persistent("CustomerID"), Association("CustomerOrders")]
        public Customer Customer {
            get { return customerValue; }
            set { SetPropertyValue("Customer", ref customerValue, value); }
        }
    }
}
