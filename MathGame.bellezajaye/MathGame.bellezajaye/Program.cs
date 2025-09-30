using MathGame;

var menu = new Menu();

var date = DateTime.UtcNow;

string name = Helpers.GetName();

//List<string> games = new List<string>(); // List<string> games = new() - shorthand
// var games = new List<string>(); // another way to declare List

menu.ShowMenu(name, date);
