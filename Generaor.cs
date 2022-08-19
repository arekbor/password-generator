using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Generator gen = new Generator();
        gen.WithSpecialCharacters = true;
        gen.WithNumbers = true;
        var result = gen.Make(50);
        Console.WriteLine(result);
    }
}
public class Generator{
    private char[] letters = 
        {'a','b','c','d','e','f','g','h','i','j','k'};
    
    private char[] speChar = 
        {'!','@','#','$','%','^','&','*','(',')'};
        
    private char[] numbers = 
        {'1','2','3','4','5','6','7','8','9','0'};
    
    private Random random = new Random();
    
    public bool WithSpecialCharacters 
        {private get; set;}
        
    public bool WithNumbers
        {private get; set;}
    private char[] _charMix;
        
    public string Make(int length){
        
        _charMix = new char[length];
        
        if(WithSpecialCharacters){
            letters = letters.Concat(speChar).ToArray();
        }
        if(WithNumbers){
            letters = letters.Concat(numbers).ToArray();
        }
        
        for(int i=0;i<length;i++){
            
            _charMix[i] = 
                letters[random.Next(letters.Length)];
        }
        return new string(_charMix);
    }
}
