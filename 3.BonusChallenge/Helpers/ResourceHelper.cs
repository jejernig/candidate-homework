using System;
using System.Collections.Generic;
using System.Linq;

public static class ResourceHelper {

    //just copying from project 2
    public static IEnumerable<IEnumerable<string>> Output(IEnumerable<string> input)
    {
        var output = new List<List<string>>();

        // YOUR CODE GOES HERE
        var stringDict = new Dictionary<string, List<String>>();


        foreach (var word in input)
        {
            //null check for empty word
            if (string.IsNullOrEmpty(word))
                continue;

            var sorted = string.Concat(word.ToLower().OrderBy(c => c));

            //check if sorted already is in the string dictionary and add it to the list
            //otherwise create a new value in the dictionary for word loop
            if (stringDict.ContainsKey(sorted))
            {
                stringDict[sorted].Add(word);
            }
            else
            {
                stringDict[sorted] = new List<String> { word };
            }
        }

        //output needs to be a list and sorted alphabetically
        output = stringDict.Values.OrderBy(l => l[0]).ToList();

        //a little massaging of the output to fit into the model
        return output.Select(list => list.ToList()).ToList();
    }
}
