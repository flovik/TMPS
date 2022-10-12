using CreationalDesignPatterns.Singleton;

//Singleton
var singleton = LoggerSingleton.GetLogger();
var user = new User(singleton, "Vasile", "Ceban");
user.PrintToConsole();

