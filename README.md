# LeetCode-GroupAnagrams-CS
A solution for LeetCode "Group Anagrams" in C#

## Explanation
In this problem you are given an array of strings and asked to return it as a list of lists of strings that are anagrams.

One solution to this problem involves creating a unique counters hashmap for each anagram although this creates a lot of lists to compare againist. Neatcode made a [video](https://www.youtube.com/watch?v=vzdNOK2oB2E) on this if you're interested in his solution. In C# this could result in some weird looking code and decided I can do better. My solution is faster than 76% of submissions and uses less memory than 95.34% of submissions.

My solution works as follows:

1. For each string sort it from A-Z with C#'s built-in sorting function
2. Create if the key exists or not and set the word into the right key
3. Iterate over the words Dictionary and return its lists in the requested object format.

**Stats**

Runtime: 225 ms, faster than 76.08% of C# online submissions for Group Anagrams.

Memory Usage: 49.7 MB, less than 95.34% of C# online submissions for Group Anagrams.

## Solution
```cs
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        var words = new Dictionary<string, List<string>>();
        
        foreach (var str in strs) {
            
            // Sort letters in the string to calculate its key
            var charactersToSort = str.ToArray();
            Array.Sort(charactersToSort);
            var sortedCharacters = new string(charactersToSort);
            
            // Assign word to the correct key (create if the key doesn't exist yet)
            if (words.ContainsKey(sortedCharacters)) {
                words[sortedCharacters].Add(str);
            } else {
                words.Add(sortedCharacters, new List<string>() { str });
            }
        }
        
        // Create the result object and add the lists into it
        IList<IList<string>> result = new List<IList<string>>();
        foreach (var item in words) {
            result.Add(item.Value);
        }
        
        // Return the result
        return result;
    }
}
```
