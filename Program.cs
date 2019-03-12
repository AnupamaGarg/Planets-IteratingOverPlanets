using System;
using System.Collections.Generic;

namespace Planets_IteratingOverPlanets
{
    class Program

    {

        //  static void PrintPlanetDictionary(Dictionary<string,string> dict) {
        //     foreach(KeyValuePair<string, string> kvp in dict) {
        //         Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
        //     }

        // }
        static void Main(string[] args)
        {
             List<string> planetList = new List<string>(){"Mercury","Venus","Earth", "Mars","Jupiter","Saturn","Uranus","Neptune"};


             List<Dictionary<string,string>> probes = new List<Dictionary<string,string>>();
            //   probes.Add(new Dictionary<string,string>(){{"Mercury", "Mariner10"},
            //                                              {"Venus", "Mariner 2"}});
                                                            

                probes.Add(new Dictionary<string,string>(){{"Mercury", "Mariner10"}});
                probes.Add(new Dictionary<string,string>(){{"Mercury", "MESSENGER"}});
                probes.Add(new Dictionary<string,string>(){{"Venus", "Mariner 2"}});
                probes.Add(new Dictionary<string,string>(){{"Venus", "Cassini"}});
                probes.Add(new Dictionary<string,string>(){{"Earth","Viking"}});
                probes.Add(new Dictionary<string, string>(){{"Mars", "Curiosity"}});
                probes.Add(new Dictionary<string, string>(){{"Jupiter","Juno"}});
                probes.Add(new Dictionary<string,string>(){{"Saturn","Cassini"}});
                probes.Add(new Dictionary<string, string>(){{"Uranus","Voyager 2"}});
                probes.Add(new Dictionary<string, string>(){{"Neptune","Voyager 1"}});
                Console.WriteLine("------------Planets and their Probes-----------");
            
                foreach(Dictionary<string,string> probe in probes) {
                    // PrintPlanetDictionary(probe);

                    foreach(KeyValuePair<string, string> kvp in probe) {
                    Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
                }

                // Iterate over planetList, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.
                Console.WriteLine("---------Matching Probes---------------------");
            
            
                foreach (string planet in planetList) // iterate planets
                {
                    List<string> matchingProbes = new List<string>();

                    foreach(Dictionary<string, string> probe in probes) // iterate probes
                    {
                        foreach(KeyValuePair<string, string> kvp in probe) {
                         
            
                         /*
                            Does the current Dictionary contain the key of
                            the current planet? Investigate the ContainsKey()
                            method on a Dictionary.
                            If so, add the current spacecraft to `matchingProbes`.
                        */
                        if (probe.ContainsKey(planet)) {
                            // matchingProbes.Add(probe[planet]);
                            matchingProbes.Add(probe[kvp.Key]);
                            // Console.WriteLine( $" PROB For {planet} is {probe[kvp.Key]}");
                        }
                        }
                    }
                    foreach(string matchingProbe in matchingProbes) {
                        string PlanetsSpaceCrafts = String.Join(",", matchingProbes);
                            Console.WriteLine($"{planet}: {PlanetsSpaceCrafts}");
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
