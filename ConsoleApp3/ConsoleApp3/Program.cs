// See https://aka.ms/new-console-template for more information
//class Program
//{
//    static void Main()
//    {
//        var duck = new Duck();
//        duck.DidSound("duck duck");
//        var dog = new Dog();
//        dog.DidSound("hav hav");

//        Console.WriteLine("---------------------");
//        Animal animal = dog;
//        animal.DidSound("xx");

//        Console.WriteLine("----------------------");
//        duck.DidSound();
//        dog.DidSound();
//        animal.DidSound();
//        Animal animal2 = duck;
//        animal2.DidSound();

//    }
//}



//class Animal
//{
//    public virtual void DidSound(string sound)
//    {
//        System.Console.WriteLine("animal class- ses geldi: " + sound);
//    }

//    public virtual void DidSound()
//    {
//        System.Console.WriteLine("animal class- ses geldi: " + "Animal");
//    }
//}

//class Duck: Animal
//{
//    public override void DidSound(string sound)
//    {
//        Console.WriteLine("duck class - ses geldi: " + sound);
//        //base.DidSound(sound); 
//        //base demek hangi sınıftan kalıttıysan orası demek 
//        //burda duck ses geldi diyecek sonra animal ses geldi diyecek
//    }

//    public override void DidSound()
//    {
//        Console.WriteLine("duck class - ses geldi: " + "duck duck");
//        //base.DidSound(); 

//    }

//}

//class Dog: Animal
//{
//    public override void DidSound(string sound)
//    {
//        Console.WriteLine("dog class - ses geldi: " + sound);
//        //base.DidSound(sound);
//        //base demek hangi sınıftan kalıttıysan orası demek 
//        //burda dog ses geldi diyecek sonra animal ses geldi diyecek
//    }
//    public override void DidSound()
//    {
//        Console.WriteLine("dog class - ses geldi: " + "hav hav");
//        //base.DidSound(); 

//    }

//}

class Program
{
    static void Main()
    {
        IAnimal animal = new Person();
        animal.DidSound();
    }
    
}
    interface IAnimal
    {
        public string sound { get; set; }
        void DidSound();
    }

class Person : IAnimal 
    {
        public string sound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DidSound()
        {
            Console.WriteLine("ses geldi");
        }
    } 
       
    
    

