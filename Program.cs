﻿using learnCSharpBasics.LearnTypeSystem;

namespace learnCSharpBasics;

public class Base { }

public class Derived : Base { }

class Program
{
    static void Main(string[] args)
    {
        //IsOperator.run();
        //AsOperator.run();
        //CastExpression.run();
        //TypeOfOperator.run();
        TypeSystem.run();
    }

}