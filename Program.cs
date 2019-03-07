using System;
using System.Collections.Generic;

namespace Planets_IteratingOverPlanets
{
    class Program

    {

         static void PrintPlanetDictionary(Dictionary<string,string> dict) {
            foreach(KeyValuePair<string, string> kvp in dict) {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }
        static void Main(string[] args)
        {
             List<string> planetList = new List<string>(){"Mercury","Venus","Earth", "Mars","Jupiter","Saturn","Uranus","Neptune"};


             List<Dictionary<string,string>> probes = new List<Dictionary<string,string>>();
                probes.Add(new Dictionary<string,string>(){{"Mercury", "Mariner"}});
                probes.Add(new Dictionary<string,string>(){{"Venus", "Mariner 2"}});
                probes.Add(new Dictionary<string,string>(){{"Earth","International Space Station"}});
                probes.Add(new Dictionary<string, string>(){{"Mars", "Curiosity"}});
                probes.Add(new Dictionary<string, string>(){{"Mars", "Another SpaceCraft"}});
                probes.Add(new Dictionary<string, string>(){{"Jupiter","Juno"}});
                probes.Add(new Dictionary<string,string>(){{"Saturn","Cassini"}});
                probes.Add(new Dictionary<string, string>(){{"Uranus","Voyager 2"}});
                probes.Add(new Dictionary<string, string>(){{"Neptune","Voyager 1"}});
                Console.WriteLine("Planets and their Probes");
                Console.WriteLine("-----------------------------");
                foreach(Dictionary<string,string> probe in probes) {
                    PrintPlanetDictionary(probe);
                }

                // Iterate over planetList, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.
                Console.WriteLine("------------------------------");
                Console.WriteLine("Matching Probes");
                Console.WriteLine("-------------------------------");
                foreach (string planet in planetList) // iterate planets
                {
                    List<string> matchingProbes = new List<string>();

                    foreach(Dictionary<string, string> probe in probes) // iterate probes
                    {
                         /*
                            Does the current Dictionary contain the key of
                            the current planet? Investigate the ContainsKey()
                            method on a Dictionary.
                            If so, add the current spacecraft to `matchingProbes`.
                        */
                        if (probe.ContainsKey(planet)) {
                            matchingProbes.Add(probe[planet]);
                            // Console.WriteLine("it matches!");
                        }
                    }
                    foreach(string matchingProbe in matchingProbes) {
                        string SpaceCraft = String.Join(",", matchingProbes);
                            Console.WriteLine($"{planet}: {SpaceCraft}");
                        }

                    /*
                        Use String.Join(",", matchingProbes) as part of the
                        solution to get the output below. It's the C# way of
                        writing `array.join(",")` in JavaScript.
                    */
                    // Console.WriteLine($"{}: {}");
                }
        }
    }
}
