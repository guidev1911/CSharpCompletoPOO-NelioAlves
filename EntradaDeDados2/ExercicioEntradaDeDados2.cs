using System;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;


Console.WriteLine("cw + tab = Console.Write line");
string rl = Console.ReadLine();//rl + tab = Console.ReadLine();
if (rl ==rl)//if + tab = if ()
{
    
}
if (rl==rl)//ife + tab = if e else
{
    
}
else
{
    
}
for (int i = 0; i < rl; i++)//for + tab = for i
{
    
}
//foreach (var item in )//foreach + tab  
{
    
}
try //try + tab = try catch
{
    
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//class cls + tab = class 
{
    
}


//        "Console WriteLine": {
//        "prefix": "cw",
//        "body": [
//        "Console.WriteLine(\"$1\");"
//        ],
//        "description": "Console.WriteLine"
//        },
//
//        "Console ReadLine": {
//        "prefix": "cr",
//        "body": [
//        "string $1 = Console.ReadLine();"
//        ],
//        "description": "Console.ReadLine"
//        },
//
//        "If simples": {
//        "prefix": "if",
//        "body": [
//        "if ($1)",
//        "{",
//        "    $0",
//        "}"
//        ],
//        "description": "if statement"
//        },
//
//        "If Else": {
//        "prefix": "ife",
//        "body": [
//        "if ($1)",
//        "{",
//        "    $2",
//        "}",
//        "else",
//        "{",
//        "    $0",
//        "}"
//        ],
//        "description": "if else statement"
//        },
//
//        "For": {
//        "prefix": "for",
//        "body": [
//        "for (int i = 0; i < $1; i++)",
//        "{",
//        "    $0",
//        "}"
//        ],
//        "description": "for loop"
//        },
//
//        "Foreach": {
//        "prefix": "foreach",
//        "body": [
//        "foreach (var item in $1)",
//        "{",
//        "    $0",
//        "}"
//        ],
//        "description": "foreach loop"
//        },
//
//        "Try Catch": {
//        "prefix": "try",
//        "body": [
//        "try",
//        "{",
//        "    $1",
//        "}",
//        "catch (Exception ex)",
//        "{",
//        "    Console.WriteLine(ex.Message);",
//        "}"
//        ],
//        "description": "try catch"
//        },
//
//        "Classe": {
//        "prefix": "cls",
//        "body": [
//        "class $1",
//        "{",
//        "    $0",
//        "}"
//        ],
//        "description": "class"
//        }
//        }
