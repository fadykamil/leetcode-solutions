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
        greatest_twin_sum = 0
        for i, val in enumerate(values):
            twin = n - 1 - i
            if twin == 0:
                break
            if values[i] + values[twin] > greatest_twin_sum:
                greatest_twin_sum = values[i] + values[twin]
            
        return greatest_twin_sum
        