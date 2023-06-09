
/**
 * Implements the core functionality for the self-assessment test in "The Art of Software Testing,
 * Second Edition" by Glenford Myers.
 * 
 * @author Brian Daugherty
 * 
 */
public enum TriangleType {
    INVALID, SCALENE, EQUILATERAL, ISOSCELES
}

public class TriangleTypeClassifier
{ 

    /**
     * Return the type of triangle that three provided lengths would form.
     * 
     * @param a
     *            length of the first side
     * @param b
     *            length of the second side
     * @param c
     *            length of the third side
     * 
     * @return
     *         <ul>
     *         <li>INVALID if the three lengths do not form a triangle.
     *         <li>EQUILATERAL if the three lengths are equal.
     *         <li>ISOSCELES if two lengths are equal.
     *         <li>SCALENE if all three lengths are different.
     *         </ul>
     * 
     */
    public static TriangleType classify(int a, int b, int c) {
        if (sidesFormATriangle(a, b, c)) {
            if (allSidesAreEqual(a, b, c)) {
                return TriangleType.EQUILATERAL;
            } else if (twoSidesAreEqual(a, b, c)) {
                return TriangleType.ISOSCELES;
            } else {
                return TriangleType.SCALENE;
            }
        } else {
            throw new System.InvalidOperationException("Sides do not form a triangle");
        }
    }

    private static bool twoSidesAreEqual(int a, int b, int c) {
        return a == b || b == c || c == a;
    }

    private static bool allSidesAreEqual(int a, int b, int c) {
        return a == b && b == c;
    }

    /**
     * To form a triangle, the sum of the lengths of any two sides must be greater than or equal
     * (i.e., degenerate) to the length of the third side. However, this implementation treats the
     * degenerate case (a + b = c) as invalid.
     * 
     * @return True if the sum of the lengths of any two sides is greater than the length of the
     *         third side.
     * 
     * TODO: Avoid overflow when side lengths == MAXINT
     */
    private static bool sidesFormATriangle(int a, int b, int c) {
        return a + b > c && b + c > a && a + c > b;
    }
}
