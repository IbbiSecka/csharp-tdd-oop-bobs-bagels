using exercise.main;
using System.Security.Cryptography.X509Certificates;

namespace exercise.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddItems()
    {
        Basket bagel1 = new Basket();
        Item item1 = new Item("Bagel", 25, "MMU", "Plain");
        bool result = bagel1.AddItem(item1);
        
        Assert.IsTrue(result);

    }
    [Test]
    public void RemoveItems()
    {
        //Creates new instances of a bagel list and item
        Basket bagel = new Basket();
        Item item99 = new Item("Bagel", 25, "MMU", "Plain");
        //Checks if an item had been added
        bool addedItem = bagel.AddItem(item99);
        Assert.That(addedItem);
        //Checks if item is removed
        bool removedItem = bagel.RemoveItem(item99);
        Assert.That(removedItem);
    }
    [Test]
    public void checkCapacity()
    {
        Basket bagel = new Basket();
        Item item3 = new Item("Bagel", 25, "MMU", "Plain");
        Item item2 = new Item("NaBagel", 22, "AMU", "Spicy");

        bagel.AddItem(item2); 
        bagel.AddItem(item3);
        
        int resultCapacity = bagel.CheckCapacity();
        int expectedCapacity = 2;

        Assert.That(resultCapacity, Is.EqualTo(expectedCapacity));
    }
    [Test]

    public void maxCapacity()
    {
        Basket bagelist = new Basket();


    }

    [Test]
    public 

}