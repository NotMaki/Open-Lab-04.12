using System;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int sum;

            sum = (nums.Length + 1) * (nums.Length + 2) / 2;

            foreach (int nm in nums)
            {
                sum = sum - nm;
            }

            return sum;
        }
    }
}
