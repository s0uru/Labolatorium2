﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class Calculator
    {
        public Operators? Operator { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        
        public String Op
        {
            get
            {
                switch (Operator)
                {
                    case Operators.Add:
                        return "+";
                    case Operators.Sub:
                        return "-";
                    case Operators.Nul:
                        return "*";
                    case Operators.Div:
                        return "/";
                    default:
                        return "";
                }
            }
        }
        
        public bool IsValid()
        {
            return Operator != null && X != null && Y != null;
        }

        public double Calculate()
        {
            if (!IsValid()) 
                throw new InvalidOperationException("Invalid input or operator");

            switch (Operator)
            {
                case Operators.Add:
                    return (double)(X + Y);
                case Operators.Sub:
                    return (double)(X - Y);
                case Operators.Nul:
                    return (double)(X * Y);
                case Operators.Div:
                    if (Y == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    return (double)(X / Y);
                default:
                    return double.NaN;
            }
        }
    }
    public enum Operators
    {
        Add,
        Sub,
        Nul,
        Div
    }

}