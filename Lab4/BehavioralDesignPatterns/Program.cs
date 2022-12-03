//template method - we have an algorithm that subclasses may or may not override, they can change their behaviour but not the algorithm's steps

using BehavioralDesignPatterns.TemplateMethod;

BreadTemplate bread = new WheatBread();
bread.PrepareBread();

bread = new RyeBread();
bread.PrepareBread();

//strategy 