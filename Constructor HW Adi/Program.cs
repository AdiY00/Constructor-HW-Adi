//(8.)
ConsolePlus a1 = new ConsolePlus();
ConsolePlus a2 = new ConsolePlus("Hello World!");
ConsolePlus a3 = new ConsolePlus(12, 13);
Console.WriteLine();


//(9.)
Console.Write("Enter amount of names to enter: ");
int n = 1;
int.TryParse(Console.ReadLine(),out n);

string[] names = new string[n];
Person[] people = new Person[n];

Console.WriteLine($"Enter {n} names, press 'Enter' after each one to submit:");
for (int i = 0; i < n; i++)
{
    names[i] = Console.ReadLine();
    people[i] = new Person(names[i]); 
}
Console.WriteLine();

foreach (Person person in people) Console.WriteLine(person.name_);

Console.WriteLine();

string[] randomNames = new string[n];
Person[] randomPeople = new Person[n];
int[] ages = new int[n];

Random random = new Random();
for (int i = 0; i < n; i++)
{
    randomNames[i] = names[random.Next(0,n)];
    ages[i] = random.Next(0, 100);
    randomPeople[i] = new Person(randomNames[i],ages[i]);
}

foreach (Person person in randomPeople) Console.WriteLine($"Name: \"{person.name_}\". Age: {person.age_}");


//(10.)

Phone[] phones = new Phone[]
{
    new Phone("Google", "Pixel 7 Pro", 899),
    new Phone("Samsung", "Galxay 22 Ultra", 999),
    new Phone("Apple", "Iphone 14 Pro Max", 1099),
    new Phone() // would be the same as the first phone
};

foreach (Phone phone in phones) Console.WriteLine($"{phone.Brand} {phone.Model} {phone.Price}$");






//7.

class Car
{
    public string Brand;

    public Car(string brand)
    {
        Brand = brand;
    }

    public string GetBrand() => Brand;
}


//8.

class ConsolePlus
{
    public ConsolePlus()
    {
        Console.WriteLine("default");
    }

    public ConsolePlus(string s)
    {
        Console.WriteLine(s);
    }

    public ConsolePlus(int a, int b)
    {
        Console.WriteLine(a+b);
    }
}


//9.

class Person
{
    public string name_;
    public int age_;

    public Person(string name)
    {
        this.name_ = name;
    }

    public Person(string name, int age) : this(name)
    {
        this.age_ = age;
    }

}

//10.

class Phone
{
    public string Brand, Model;
    public int Price;
    static bool firstPhone = true;

    static string firstBrand = "", firstModel = "";
    static int firstPrice = 0;

    public Phone(string brand, string model, int price)
    {
        this.Brand = brand;
        this.Model = model;
        this.Price = price;

        if (firstPhone) (firstBrand, firstModel, firstPrice) = (brand, model, price);

        firstPhone = false;
    }

    public Phone():this(firstBrand, firstModel, firstPrice) {}

}