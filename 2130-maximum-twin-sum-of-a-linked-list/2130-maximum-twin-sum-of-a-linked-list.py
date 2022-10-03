# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def my_gen(self, values):
        for i, val in enumerate(values):
            yield i, val
    def pairSum(self, head):
        """
        :type head: Optional[ListNode]
        :rtype: int
        """
        next_node = head
        values = []
        while next_node != None:
            values.append(next_node.val)
            next_node = next_node.next
        n = len(values)
        greatest_twin_sum = 0
        for i, val in self.my_gen(values):
            if values[i] + values[n - 1 - i] > greatest_twin_sum:
                greatest_twin_sum = values[i] + values[n - 1 - i]
        return greatest_twin_sum
        