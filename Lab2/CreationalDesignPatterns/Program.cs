using System.Text;
using CreationalDesignPatterns.AbstractFactory;
using CreationalDesignPatterns.Builder;
using CreationalDesignPatterns.FactoryMethod;
using CreationalDesignPatterns.Singleton;
using User = CreationalDesignPatterns.Singleton.User;

//Singleton
var singleton = LoggerSingleton.GetLogger();
var user = new User(singleton, "Vasile", "Ceban");
user.PrintToConsole();

//Factory Method
var users = new List<BaseUser>
{
    new GoldUserCreator(),
    new SilverUserCreator()
};

foreach (var baseUser in users)
{
    Console.WriteLine(
        baseUser.SendData("Some external data")
    );
}

//Builder
//in my case it is a fluent builder

var userBuilder = new UserBuilder("John", "Snow");
var user1 = userBuilder
    .SetPhone("+37354363")
    .SetAge(19)
    .SetAddress("Chisinau")
    .Build();
userBuilder.Reset("Eleanor", "Rigby");
var user2 = userBuilder
    .SetAge(43)
    .Build();


//abstract factory
var archerFactory = new ArcherFactory();
var archer = new Soldier(archerFactory);

var modernFactory = new ModernSoldierFactory();
var modernSoldier = new Soldier(modernFactory);

archer.Attack();
archer.Defend();

modernSoldier.Attack();
modernSoldier.Defend();