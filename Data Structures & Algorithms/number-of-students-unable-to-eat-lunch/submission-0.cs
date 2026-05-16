public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int numCircleStudents = students.Count(s => s == 0); // 2
        int numSquareStudents = students.Length - numCircleStudents; // 2

        foreach (int sandwich in sandwiches)
        {
            if (sandwich == 0)
            {
                if (numCircleStudents == 0)
                {
                    return numSquareStudents;
                }
                numCircleStudents--;
            }
            else
            {
                if (numSquareStudents == 0)
                {
                    return numCircleStudents;
                }
                numSquareStudents--;
            }
        }
        

        return 0; // no leftovers
    }
}