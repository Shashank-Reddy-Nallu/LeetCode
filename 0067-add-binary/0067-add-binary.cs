public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length-1;
        int j = b.Length-1;
        int carry = 0;
        StringBuilder sb = new StringBuilder();
        while (i>=0 || j>=0 || carry>0){
            int sum = carry;
            if(i>=0){
                sum += a[i] == '1' ? 1 : 0;
                i-=1;
            }
            if(j>=0){
                sum += b[j] == '1' ? 1 : 0;
                j-=1;
            }

            sb.Append(sum%2 == 1 ? '1' : '0');
            carry = sum/2;
        }

        StringBuilder res = new StringBuilder();
        for (int ni=sb.Length-1; ni>=0; ni--){
            res.Append(sb[ni]);
        }

        return res.ToString();
    }
}