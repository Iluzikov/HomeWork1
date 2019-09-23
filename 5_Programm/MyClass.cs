using System;

// Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

// Лузиков Иван

public class Tools
{
	public void Pause()
	{
        Console.ReadKey();
	}

    public void PrintAll(string msg)
    {
        Console.WriteLine(msg);
    }

    public void PrintAll(string msg, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(msg);
    }
}
