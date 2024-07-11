using StaticVSInstance;
using System.ComponentModel.Design;

int numberInput1 = 0;
int numberInput2 = 0;
int result = 0;
double area = 0;
/*

Calculator c = new Calculator();
c.GetNumberInput("test");

Calculator c2 = new Calculator();
c2.GetNumberInput("dksfj");
c2.Count
*/
/*
Calculator mixed = new Calculator();
mixed.Title = "Hexenwerk!";
*/
// Wenn wir die Methoden des Taschenrechners statisch machen, müssen wir keine Instanz (Objekt) der Klasse Calculator (eg. var calc = new Calculator()) erstellen.
/*
Calculator calculator = new Calculator();
calculator.Title = "Mein cooler Taschenrechner";
Calculator.Title = "Geht nicht, weil keine Instanz.";
calculator.Count = "Gibt es nicht auf der Instanz...";
Calculator.Count = 10;

calculator.Add(10,20);

Calculator calculator1 = new Calculator();
calculator1.Add(20, 30);

Calculator calc1 = new Calculator();
Calculator calcSubtract = new Calculator();

*/

/*
 Beispiel für einen Datentyp (Klasse) mit statischen- und Instanzmembern. Member => Property, Methods, private Fields
 */
int x = 0;
x.ToString();
var parsed = int.Parse("1");


do
{
  Console.Clear();
  Console.WriteLine("Was willst du rechnen?");
  Console.WriteLine("\t1. Add\n\t2. Subtract\n\t3. Multiply\n\t4. Divide\n\t5. Calculate Area\n\t6. Calculate Perimeter");
  var menuInput = Console.ReadLine();
  int menuInputIndex = int.Parse(menuInput);

  if (menuInputIndex >= 1 && menuInputIndex <= 4)
  {
    numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein: ");
    numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein: ");
    Operator op = (Operator)menuInputIndex;
    switch (op)
    {
      case Operator.Add:
        Calculator.Calculate(numberInput1, numberInput2, Operator.Add);
        break;
      case Operator.Subtract:
        Calculator.Calculate(numberInput1, numberInput2, Operator.Subtract);
        break;
      case Operator.Multiply:
        Calculator.Calculate(numberInput1, numberInput2, Operator.Multiply);
        break;
      case Operator.Divide:
        Calculator.Calculate(numberInput1, numberInput2, Operator.Divide);
        break;
    }
  }
  else if (menuInputIndex == 5 || menuInputIndex == 6)
  {
    Console.WriteLine("Wähle die Form:");
    Console.WriteLine("\t1. Triangle\n\t2. Circle\n\t3. Rectangle");
    var shapeInput = Console.ReadLine();
    int shapeInputIndex = int.Parse(shapeInput);
    Shape shape = (Shape)shapeInputIndex;




    if (menuInputIndex == 5)
    {
      if (Shape.Triangle == shape)
      {
        double baseTriangle = Calculator.GetNumberInput("Gebe die Basis des Dreiecks ein: ");
        double heightTriangle = Calculator.GetNumberInput("Gebe die Höhe des Dreiecks ein: ");
        Calculator.CalculateArea(shape, baseTriangle, heightTriangle);
      }
      else if (Shape.Circle == shape)
      {
        double radiusCircle = Calculator.GetNumberInput("Gebe den Radius des Kreises ein: ");
        Calculator.CalculateArea(shape, radiusCircle);
      }
      else if (Shape.Rectangle == shape) 
      {
        double lengthRectangle = Calculator.GetNumberInput("Gebe die Länge des Rechtecks ein: ");
        double widthRectangle = Calculator.GetNumberInput("Gebe die Breite des Rechtecks ein: ");
        Calculator.CalculateArea(lengthRectangle, widthRectangle, shape);
      }    
    }
    else
    {
      if (Shape.Triangle == shape)
      {
        double side1 = Calculator.GetNumberInput("Gebe die erste Seite des Dreiecks ein: ");
        double side2 = Calculator.GetNumberInput("Gebe die zweite Seite des Dreiecks ein: ");
        double side3 = Calculator.GetNumberInput("Gebe die dritte Seite des Dreiecks ein: ");
        Calculator.CalculatePerimeter(shape, side1, side2, side3);
      }
      else if (Shape.Circle == shape)
      {
        double radiusCircle = Calculator.GetNumberInput("Gebe den Radius des Kreises ein: ");
        Calculator.CalculatePerimeter(shape, radiusCircle);
      }
      else if (Shape.Rectangle == shape)
      {
        double lengthRectangle = Calculator.GetNumberInput("Gebe die Länge des Rechtecks ein: ");
        double widthRectangle = Calculator.GetNumberInput("Gebe die Breite des Rechtecks ein: ");
        Calculator.CalculatePerimeter(shape, lengthRectangle, widthRectangle);
      }
    }
  }

} while (true);

// void test() { } // Program.test() // auch eine Methode, weil gehört zur Program-Klasse
