using System;
using NUnit.Framework;

namespace NUnit_TriangleType_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCase(3, 4, 5, ExpectedResult =TriangleType.SCALENE, TestName = "classify_AsScalene_WhenTheThreeSidesAreDifferent(3, 4, 5)", Description = "bla bla")]
        [TestCase(2, 2,2, ExpectedResult = TriangleType.EQUILATERAL, TestName = "classify_AsScalene_WhenTheThreeSidesAreDifferent(2, 2, 2)")]
        [TestCase(3, 3, 4, ExpectedResult = TriangleType.ISOSCELES, TestName = "classify_AsIsosceles_WhenTwoSidesAreEqual(3, 3, 4)")]
        [TestCase(3, 3, 4, ExpectedResult = TriangleType.ISOSCELES, TestName = "classify_AsIsosceles_WhenTwoSidesAreEqual(3, 4, 3)")]
        public TriangleType classifyValidTriangle(int a, int b, int c)
        {
            Console.WriteLine("a = "+a+", b = "+b+ ", c = "+c);
            TriangleType triangleType = TriangleTypeClassifier.classify(a, b, c);
            Console.WriteLine("Actual output is " + triangleType);
            return triangleType;
            
        }


        [Test]
        [TestCase(0, 3, 4, TestName = "classify_AsInvalid_WhenAnySideIsZero(0, 3, 4)")]
        [TestCase(0, 0, 0, TestName = "classify_AsInvalid_WhenAnySideIsZero(0, 0, 0)")]
        [TestCase(-1, 3, 4,TestName = "classify_AsInvalid_WhenAnySideIsNegative(-1, 3, 4)")]
        [TestCase(-1, -1, -1, TestName = "classify_AsInvalid_WhenAnySideIsNegative(-1, -1, -1)")]
        [TestCase(1, 2, 3, TestName = "classify_AsInvalid_WhenTheSumOfTwoSidesIsEqualToTheThird(1, 2, 3)")]
        [TestCase(1, 2, 4, TestName = "classify_AsInvalid_WhenTheSumOfTwoSidesIsLessThanTheThird(1, 2, 4)")]
        public void classifyInvalidTriangle(int a, int b, int c)
        {
            Assert.That(() => TriangleTypeClassifier.classify(a, b, c), Throws.TypeOf<InvalidOperationException>());

        }


    



    }
}