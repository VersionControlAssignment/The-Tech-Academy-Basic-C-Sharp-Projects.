﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    public class MathMethods
    {
        //Create a class. In that class, create a void method that takes two integers as parameters.
        //Have the method do a math operation on the first integer and display the second integer to the screen.
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }
        public static int Defense(int defense)
        {
            int enemy_str = 7;
            int weapon_mt = 11;
            int triangle_bonus = -1;
            int crit_coeff = 1;
            int damage = (enemy_str + (weapon_mt + triangle_bonus) - defense) * crit_coeff;
            return damage;
        }
        public static int Attack(int strength)
        {
            int enemy_def = 4;
            int weapon_mt = 8;
            int triangle_bonus = 1;
            int crit_coeff = 3;
            int damage = (strength + (weapon_mt + triangle_bonus) - enemy_def) * crit_coeff;
            return damage;
        }
    }
}