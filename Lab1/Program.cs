using Lab1.D;
using Lab1.O;
using Lab1.S;


//S - a class should only do one job (responsibility), changind logic in one part will only
//affect that piece of the class
var pc1 = new PC("aerocool", "nvidia");
pc1.TurnOff();
pc1.TurnOn();
pc1.RenderImage();

var pc2 = new PC2("deepcool", new Videocard("amd")); //for rendering, Videocard has the new responsibility
pc2.TurnOff();
pc2.TurnOn();


//O - opne for extension, closed for modification
//for every new type of processor we will need to change the processor class
//minimum risk when adding new features
var pc3 = new OpenClosedPC("deepcool", new Processor("amd".ToLower(), 4));
var pc4 = new OpenClosedPC("deepcool", new Processor("intel".ToLower(), 6));
pc3.ChangeProcessor("elbrus", 12);

//don't change the code, add some new code
var pc5 = new OpenClosedPC2("aerocool", new AmdProcessor(6));
pc5 = new OpenClosedPC2("aerocool", new IntelProcessor(5));
pc5.ChangeIntelProcessor(12);


//L - any class must be direcly replaceable by any of its
//subclasses without error
//each subclass must maintain all behaviour from the base class
//along with any new behaviour


//I
//classes do not include behaviour they do not use
//any unused part should be removed into a separate method
//splits large methods into large


//D
//high-level modules shouldnt depend on low-level
//so to not change Car class and break O principle, we can create an interface for Engine that our Car will
//use 
var car1 = new Car();
car1.BurnFuel();
car1.TurnOn();

var car2 = new Car2(new BoschEngine());
car2.TurnOn();
car2 = new Car2(new RenaultEngine());
car2.TurnOn();