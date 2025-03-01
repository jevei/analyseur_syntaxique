﻿using System;
using System.Linq;

namespace Analyseur_Syntaxique
{
    class InstructionAffectation
    {
        private Variable variable;
        private ExpressionArithmetique expression;

        public InstructionAffectation(string var, string expr)
        {
            Setup(var, expr);
        }

        private void Setup(string var, string expr)
        {
            variable = new Variable(var);
            if (Program.variableList.Contains(variable) == false)
            {
                Console.WriteLine("Erreur: Variable " + variable.ToString() + " n'existe pas!");
                Environment.Exit(0);
            }
            if (expr.ElementAt(expr.Length - 1) == 59)
            {
                expr = expr.Remove(expr.Length - 2);
            }
            expression = new ExpressionArithmetique(expr);
        }

        public override string ToString()
        {
            return variable.ToString() + " = " + expression.ToString();
        }
    }
}
