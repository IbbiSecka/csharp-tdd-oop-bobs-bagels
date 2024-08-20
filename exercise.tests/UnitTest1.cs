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
        string removedItem = bagel.RemoveItem(item99);
        Assert.That(removedItem == "Item reomved");
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

    public void ChangeCapacityTest()
    {
        Basket bagelist = new Basket();
        Item item111 = new Item("NaBagel", 72, "AMU", "Spicy");
        Item item3 = new Item("Naaaagel", 12, "HMU", "LilSpice");
        Item item4 = new Item("BaBagel", 2, "RMU", "MaybeSpicy");
        bagelist.AddItem(item4);
        bagelist.AddItem(item3);
        bagelist.AddItem(item111);
        int originalCapacity = bagelist.CheckCapacity(); // = 3
        Assert.That(originalCapacity == 3);
        
        int changedCapacity = bagelist.ChangeMaxCapacity(originalCapacity);


        Assert.That(changedCapacity == 8);
    }
    [Test]
    public void existsRemovedItem()
    {
        Basket basket = new Basket();
        Item itemInList = new Item("BaBagel", 2, "RMU", "MaybeSpicy");
        Item itemNotInList = new Item("BaBagel", 3, "RMU", "MaybeSpicy");
        basket.AddItem(itemInList);


        string outputString = basket.RemoveItem(itemNotInList);
        string expectedString = "Item does not exist";

        Assert.That(outputString, Is.EqualTo(expectedString));

    }
    [Test]
    public void totalCostBasket()
    {
        Basket basket = new Basket();
        Item item1 = new Item("BaBagel", 2, "RMU", "MaybeSpicy");
        Item item2 = new Item("BaBagel", 8, "RMU", "MaybeSpicy");

        basket.AddItem(item2);
        basket.AddItem(item1);

        double actualTotal = basket.Total;
        double expectedTotal = 10;

        Assert.That(actualTotal, Is.EqualTo(expectedTotal));

    }
    [Test]
    public void checkItemPrice()
    {
        Basket basket = new Basket();
        Item item1 = new Item("BaBagel", 9.99, "RMU", "MaybeSpicy");

        double actualPrice = basket.itemPrice(item1);
        double expectedPrice = 9.99;

        Assert.That(actualPrice, Is.EqualTo(expectedPrice));
    }



}