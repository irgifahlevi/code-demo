using System;

public class Shop
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public int Price { get; set; }

	public static void Main(string[] args)
	{
		Shop s = new Shop();
		Console.WriteLine(s.Name);
	}
}
