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
