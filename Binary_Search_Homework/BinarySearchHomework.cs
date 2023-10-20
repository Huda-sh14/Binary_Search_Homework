using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework
{
    public class BinarySearchHomework
    {
        public static int TernarySearch(int[] A, int x)
        {
            int left = 0, right = A.Length - 1;

            while (left <= right)
            {
                int leftMid = left + (right - left) / 3;
                int rightMid = right - (right - left) / 3;

                // int leftMid = (2*left + right) / 3;
                // int rightMid = (left + 2*right) / 3;

                if (A[leftMid] == x)
                {
                    return leftMid;
                }
                else if (A[rightMid] == x)
                {
                    return rightMid;
                }
                else if (A[leftMid] > x)
                {
                    right = leftMid - 1;
                }
                else if (A[rightMid] < x)
                {
                    left = rightMid + 1;
                }
                else
                {
                    left = leftMid + 1;
                    right = rightMid - 1;
                }
            }
            return -1;
        }

        public static int GetRepeatTime(int[] nums, int target, bool is_search_first)
        {
            // search space is nums[left…right]
            int left = 0;
            int right = nums.Length + 1;

            // initialize the result by -1
            int result = -1;

            // loop till the search space is exhausted
            while (left <= right)
            {
                // find the mid-value in the search space and compares it with the target
                int mid = (left + right) / 2;

                // if the target is found, update the result
                if (target == nums[mid])
                {
                    result = mid;

                    // go on searching towards the left (lower indices)
                    if (is_search_first)
                    {
                        right = mid - 1;
                    }
                    // go on searching towards the right (higher indices)
                    else
                    {
                        left = mid + 1;
                    }
                }

                // if the target is less than the middle element, discard the right half
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                // if the target is more than the middle element, discard the left half
                else
                {
                    left = mid + 1;
                }
            }

            // return the found index or -1 if the element is not found
            return result;
        }
    }
}
