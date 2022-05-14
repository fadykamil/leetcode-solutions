/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int PairSum(ListNode head)
    {
        var result = 0;
        var lst = GetList(head);
        var n = lst.Count;
        
        for (int i = 0; i < n/2; i++)
        {
            var twinVal = lst[n - 1 - i];
            
            var sum = twinVal + lst[i];
            result = Math.Max(sum, result);
        }
        
        return result;
    }
    public List<int> GetList(ListNode head)
    {
        var result = new List<int>();
        while (head != null)
        {
            result.Add(head.val);
            head = head.next;
        }
        return result;
    }
}