# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def pairSum(self, head):
        """
        :type head: Optional[ListNode]
        :rtype: int
        """
        next_node = head
        n = 0
        values = []
        while next_node != None:
            n += 1
            values.append(next_node.val)
            next_node = next_node.next
        twin_sums = [values[i] + values[n - 1 - i] for i, val in enumerate(values)]
        return max(twin_sums)
        