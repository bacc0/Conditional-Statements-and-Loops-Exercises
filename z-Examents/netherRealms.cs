using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class NetherRealms
{
    public static void Main()
    {
        var demons = Console.ReadLine()
                            .Split
                            (new char[] { ' ', ',' }
                            , StringSplitOptions
                            .RemoveEmptyEntries);
        
        var demHealth = new SortedDictionary<string, int>();
        var demDamage = new SortedDictionary<string, double>();

        var patern = @"-?\d+\.?\d*";
        var regex = new Regex(patern);

        foreach (var demon in demons)
        {

            var health = demon
                .Where(x => !char.IsDigit(x)
                       && x != '+' && x != '-'
                       && x != '*' && x != '/'
                       && x != '.')
                     .Sum(x => x);

            demHealth[demon] = health;


            var matches = regex.Matches(demon);

            var damage = 0.0;

            foreach (Match match in matches)
            {
                damage += double.Parse(match.Value);
            }

            foreach (var x in demon)
            {
                if (x == '*')
                {
                    damage *= 2;
                }
                if (x == '/')
                {
                    damage /= 2;
                }
            }

            demDamage[demon] = damage;

        }

        foreach (var x in demHealth)
        {
            Console.WriteLine($"{x.Key} - {x.Value} health, {demDamage[x.Key]:F2} damage");
        }
    }
}
