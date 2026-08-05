public class Solution {

    public string Encode(IList<string> strs) {
        var encoded = "";
        foreach(var str in strs) {
            encoded += str.Length.ToString("D3") + str;            
        }
        return encoded;
    }

    public List<string> Decode(string s) {
        int index = 0;
        List<string> decoded = new List<string>();
        while(index < s.Length)
        {
            int listItemLength = int.Parse(s.Substring(index, 3));
            index += 3;
            decoded.Add(s.Substring(index, listItemLength));
            index += listItemLength;
        }
        return decoded;
   }
}
