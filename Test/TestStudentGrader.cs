using Code;

namespace Test
{
    public class TestStudentGrader
    {
        StudentGrader studentGrader;
        [SetUp]
        public void Setup()
        {
            studentGrader = new();
        }
        [Test]
        public void TestStudentRateFBy0()
        {
            Assert.AreEqual("F", studentGrader.StudentRate(0));
        }
        [Test]
        public void TestStudentRateFBy40()
        {
            Assert.AreEqual("F", studentGrader.StudentRate(40));
        }
        [Test]
        public void TestStudentRateDBy41()
        {
            Assert.AreEqual("D", studentGrader.StudentRate(41));
        }
        [Test]
        public void TestStudentRateDBy60()
        {
            Assert.AreEqual("D", studentGrader.StudentRate(60));
        }
        [Test]
        public void TestStudentRateCBy61()
        {
            Assert.AreEqual("C", studentGrader.StudentRate(61));
        }
        [Test]
        public void TestStudentRateCBy70()
        {
            Assert.AreEqual("C", studentGrader.StudentRate(70));
        }
        [Test]
        public void TestStudentRateBBy71()
        {
            Assert.AreEqual("B", studentGrader.StudentRate(71));
        }
        [Test]
        public void TestStudentRateBBy80()
        {
            Assert.AreEqual("B", studentGrader.StudentRate(80));
        }
        [Test]
        public void TestStudentRateABy81()
        {
            Assert.AreEqual("A", studentGrader.StudentRate(81));
        }
        [Test]
        public void TestStudentRateABy100()
        {
            Assert.AreEqual("A", studentGrader.StudentRate(100));
        }
        [Test]
        public void TestStudentRateExceptionByNegative()
        {
            Assert.Throws<ArgumentException>(() => studentGrader.StudentRate(-1));
        }
        [Test]
        public void TestStudentRateExceptionBy101()
        {
            Assert.Throws<ArgumentException>(() => studentGrader.StudentRate(101));
        }
    }
}
