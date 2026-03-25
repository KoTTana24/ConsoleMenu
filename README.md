# ConsoleMenu
## This is a C# library to make a split menu in console 



# Functions and what it do


### NewSpace - create new space with border(x,y)


### NewVerticalCutSpace - create new space with cut on vertical(x,y, CordinateOfCut)
### NewHorizontalCutSpace - create new space with cut on horizontal(x,y, CordinateOfCut)


### VerticalCutSpace - cut space on vertical by cordinate (x,CordinateOfCut)
### HorizontalCutSpace - cut space on horizontal by cordinate (x,CordinateOfCut)


### WriteTextAt - write text at space by cordinate (x,y, "text")

# Program with ConsoleMenu

```
        NewSpace(44,24); // create space 44x24
        
        VerticalCutSpace(24,22); // cut created space on vertical by 22 X cordinate
        
        WriteTextAt(10, 0, "Numbers "); // write "Numbers " at 10 X, 0 Y(header)
        WriteTextAt(30, 0, "Sum"); // write "Sum" at 30 X, 0 Y(header)
        WriteTextAt(10, 2, "1  1 "); // write "1 1" at 10 X, 2 Y
        WriteTextAt(30, 2, "2"); // write "2" at 30 X, 2 Y
        WriteTextAt(10, 4, "3  3 ");
        WriteTextAt(30, 4, "6");
        WriteTextAt(10, 6, "14  14 ");
        WriteTextAt(30, 6, "28");
        WriteTextAt(10, 8, "5  5 ");
        WriteTextAt(30, 8, "10");
```
### program output:
```
----------Numbers ------------Sum-----------
|                     |                    |
|         1  1        |       2            |
|                     |                    |
|         3  3        |       6            |
|                     |                    |
|         14  14      |       28           |
|                     |                    |
|         5  5        |       10           |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
|                     |                    |
--------------------------------------------
```
