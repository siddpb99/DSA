public class Solution
{
    public int HammingWeight(int n)
    {
        int res = 0; // res me store krenege aur n ek numner hai to to jbtk >0 h tb tk chalega ye loop
        while (n > 0)
        {
            res = res + n % 2;// n%2 krne pe pta chalega last me 1 hai ya nhi
            n = n >> 1; // aur n ko right ahift kr denge by 1
        }
        return res;// return kr adnge res whi count h
    }
}