using System;

namespace ConsoleMenu

class ConsoleMenu
{

   public static void NewSpace(int CordX, int CordY) // void to create a space with border
    {
        Console.Clear();
        
        for (int i = 0; i < CordY; i++)
        {
            for (int j = 0; j < CordX; j++)
            {
                if (i == 0 || i == CordY - 1 || j == 0 || j == CordX - 1)
                {
                    if (i == 0 || i == CordY - 1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    Console.Write(' ');
                }
            }

            Console.WriteLine();
        }
    }
    

    public static void NewHorizontalCutSpace(int CordX, int CordY, int CutCord) // void to create a space with cut on horizontal
   {
        Console.Clear();
        
        for (int i = 0; i < CordY; i++)
        {
            for (int j = 0; j < CordX; j++)
            {
                if (i == 0 || i == CordY - 1 || j == 0 || j == CordX - 1)
                {
                    if (i == 0 || i == CordY - 1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("|");
                    }
                }
                else if (i == CutCord)
                {
                    Console.Write('-');
                }
                else
                {
                    Console.Write(' ');
                }
            }

            Console.WriteLine();
        }
    }

    public static void NewVerticalCutSpace(int CordX, int CordY, int CutCord) // void to create a space with cut on vertical 
    {
        Console.Clear();
        
        for (int i = 0; i < CordY; i++)
        {
            for (int j = 0; j < CordX; j++)
            {
                if (i == 0 || i == CordY - 1 || j == 0 || j == CordX - 1)
                {
                    if (i == 0 || i == CordY - 1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("|");
                    }
                }
                else if (j == CutCord)
                {
                    Console.Write('|');
                }
                else
                {
                    Console.Write(' ');
                }
            }

            Console.WriteLine();
        }
    }


    public static void VerticalCutSpace(int CordY, int CutCord) // void to cut a space on vertical
    {
        for (int v = 1; v < CordY - 1; v++) 
        {
            Console.SetCursorPosition(CutCord, v); 
            Console.Write("|");
        }
    }
    
    public static void HorizontalCutSpace(int CordX, int CutCord) // void to cut a space on horizontal
    {
        for (int h = 1; h < CordX - 1; h++) 
        {
            Console.SetCursorPosition(h, CutCord); 
            Console.Write("-");
        }
    }

    
    public static void WriteTextAt(int x, int y, string text) // // void to write text on space
    {
        Console.SetCursorPosition(x, y);
        Console.Write(text);
        Console.CursorVisible = false;
    }
}
