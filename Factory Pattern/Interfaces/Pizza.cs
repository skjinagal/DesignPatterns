using Factory_Pattern.Interfaces;
using Factory_Pattern.Ingredients;
using System.Security.Cryptography.X509Certificates;
namespace Factory_Pattern.Interfaces
{
    public abstract class Pizza
    {
        Dough dough;
        Sauce sauce;
        Cheese cheese;
        public abstract string GetDescription();
        public abstract double GetCost();

        public abstract void prepair();
    }
}