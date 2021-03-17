using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStoreAstykshan
{
    public class Class1
    {
        static int i = 0;
        public static void next()
        {
            Console.ReadLine();
            i++;
            Console.WriteLine("\nПродукты " + i);
        }
        class Task3
        {
            interface IProduct
            {
                double CalcProductPrice();
                double StrippingPowder();
            }
            class HouseholdChemicals
            {
                protected string name;
                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }
                protected string filter;
                public string Filter
                {
                    get { return filter; }
                    set { filter = value; }
                }
                protected int price;
                public int Price
                {
                    get { return price; }
                    set { price = value; }
                }
            }
            class Brand : HouseholdChemicals, IProduct
            {
                protected int quality;
                public Brand()
                {
                }
                public int Quality
                {
                    get { return quality; }
                    set { quality = value; }
                }
                protected double powder;
                private double stripping;

                public double Powder
                {
                    get { return powder; }
                    set { powder = value; }
                }
                double IProduct.StrippingPowder()
                {
                    powder = this.Powder + stripping;
                    return powder;
                }

                public double ProductPrice()
                {
                    throw new NotImplementedException();
                }
            }
            class Ariel : Product, Powder
            {
                int householdchemicals = 0;
                public Ariel(string _name, Magazin pub)
                {
                    name = _name;
                    stripping = 2;
                    powder = 7;
                    
                }
                void HandleCustomEvent(object sender, Product e)
                {
                    e.DoEvent();
                }
                public new void DoEvent()
                {
                    householdchemicals++;

                    product = powder + stripping + householdchemicals;
                }
                public int HouseholdChemicals
                {
                    get { return householdchemicals; }
                    set { householdchemicals = value; }
                }

                public int Product { get; private set; }
                public int Powder { get; private set; }
                public int Stripping { get; private set; }

                public static bool f = false;
                private string name;
                private int stripping;
                private int powder;
                private int product;

                double IProduct.StrippingPowder()
                {
                    Product = this.Powder + this.Stripping + householdchemicals;
                    return Product;
                }
            }
            class Magazin : EventArgs
            {
                public List<View> views = new List<View>();
                public Liquid liquid;
                private object manual;

                public Magazin(string nameOfLiquid)
                {
                    liquid = new Liquid(nameOfLiquid, this);
                }
                public void AddAsis(View a)
                {
                    views.Add(a);
                    OnRaiseCustomEvent(Liquid);
                }
                public event EventHandler<Liquid> RaiseCustomEvent;
                public void AddNewAssistant()
                {
                }
                protected virtual void OnRaiseCustomEvent(Liquid e)
                {
                    if (manual != null)
                    {

                        Manual(this, e);
                        Console.WriteLine("Новая вид порошка = " + e.Powder.ToString("f2"));
                    }
                }

                private void Manual(Magazin magazin, Liquid e)
                {
                    throw new NotImplementedException();
                }
            }
            public Task3()
            {
                Magazin magaz = new Magazin("Астыкжан");
                magaz.AddAsis(new Liquid());
                magaz.AddAsis(new Liquid());
                magaz.AddAsis(new Liquid());
            }
        }
        static void Main(string[] args)
        {
            next();
            { Task3 task = new Task3(); }

            next();
        }
    }
}
