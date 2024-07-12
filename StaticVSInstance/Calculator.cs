namespace StaticVSInstance
{
  public static class Calculator
  {
    /* Properties
    public string Title { get; set; }
    public int InstanceCount { get; set; }
    public string Title { get; set; }
    */
    public static int Count { get; set; }

    // Methoden
    public static int GetNumberInput(string inputPrompt) // Funktionssignatur -> Methodensignatur
    { // Function-Body -> Funktionskörper
      Console.Write(inputPrompt);
      return int.Parse(Console.ReadLine());
    }

    /* Calculate()
    Refactoring -> Umschreiben vom Code zum Verbessern der Performance, Lesbarkeit oder auch Wartbarkeit */
    public static int Calculate(int numberInput1, int numberInput2, Operator op) 
    {
      int result = 0;
      Count++;
      Console.ForegroundColor = ConsoleColor.Magenta;
      switch (op)
      {
        case Operator.Add:
          result = numberInput1 + numberInput2;
          Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
          break;
        case Operator.Subtract:
          result = numberInput1 - numberInput2;
          Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
          break;
        case Operator.Multiply:
          result = numberInput1 * numberInput2;
          Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
          break;
        case Operator.Divide:
          result = numberInput1 / numberInput2;
          Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
          break;
      }
      Console.ResetColor();
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }
    public static void CalculateFläche(Shape shape, double baseDreieck, double heightDreieck)
    {
      double fläche = 0;
      switch (shape)
      {
        case Shape.Dreieck:
          fläche = 0.5 * baseDreieck * heightDreieck;
          break;
      }
      Console.WriteLine($"Die Fläche des {shape} beträgt: {fläche}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
    }
    public static void CalculateFläche(Shape shape, double radiusKreis)
    {
      double fläche = 0;
      switch (shape)
      {
        case Shape.Kreis:
          fläche = Math.PI * radiusKreis * radiusKreis;
          break;
      }
      Console.WriteLine($"Die Fläche des {shape} beträgt: {fläche}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
    }
    public static void CalculateFläche(double widthRechtecken, double lengthRechtecken, Shape shape)
    {
      double fläche = 0;
      switch (shape)
      {
        case Shape.Rechtecken:
          fläche = lengthRechtecken * widthRechtecken;
          break;
      }
      Console.WriteLine($"Die Fläche des {shape} beträgt: {fläche}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
    }
    public static void CalculatePerimeter(Shape shape, double side1, double side2,  double side3)
    {
      double perimeter = 0;
      switch (shape)
      {
        case Shape.Dreieck:

          perimeter = side1 + side2 + side3;
          break;
      }
      Console.WriteLine($"Der Umfang des {shape} beträgt: {perimeter}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
    }
    public static void CalculatePerimeter(Shape shape, double radiusKreis)
    {
      double perimeter = 0;
      switch (shape)
      {

        case Shape.Kreis:

          perimeter = 2 * Math.PI * radiusKreis;
          break;
      }
      Console.WriteLine($"Der Umfang des {shape} beträgt: {perimeter}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
    }
    public static void CalculatePerimeter(Shape shape, double lengthRechtecken, double widthRechtecken)
    {
      double perimeter = 0;
      switch (shape)
      {

        case Shape.Rechtecken:
          perimeter = 2 * (lengthRechtecken + widthRechtecken);
          break;
      }
      Console.WriteLine($"Der Umfang des {shape} beträgt: {perimeter}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
    }
    public static int Add(int numberInput1, int numberInput2)
    {
      Count++;
      var result = numberInput1 + numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static int Subtract(int numberInput1, int numberInput2) 
    {
      Count++;
      var result = numberInput1 - numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static int Multiply(int numberInput1, int numberInput2)
    {
      Count++;
      var result = numberInput1 * numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static int Divide(int numberInput1, int numberInput2)
    {
      Count++;
      var result = numberInput1 / numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }
    /// <summary>
    /// Das hier ist wie Add(), aber wird über die Instanz der Klasse (konkretes Objekt eg. "calc1.AddInstance") aufgerufen. Der InstanceCount ist für jede Instanz (Objekt) unterschiedlich (eg. calc1.InstanceCount != calc2.InstanceCount)
    /// </summary>
    /// <param name="numberInput1"></param>
    /// <param name="numberInput2"></param>
    /// <returns></returns>
    /*
    public int AddInstance(int numberInput1, int numberInput2)
    {
      InstanceCount++;
      var result = numberInput1 + numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
      return result;
    }
    */


  }
  public enum Operator
  {
    Add = 1,
    Subtract = 2,
    Multiply = 3,
    Divide = 4,
  }
  public enum Shape
  {
    Dreieck = 1,
    Kreis = 2,
    Rechtecken = 3
  }
}