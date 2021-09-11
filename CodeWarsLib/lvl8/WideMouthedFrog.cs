using System;

public static class WideMouthedFrog{
    public static string Run(string animal){
        if(animal.ToLower() == "alligator") return "small";
        return "wide";
    }
}