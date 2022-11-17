using UnitTestConsole;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void tinh_luong_coban_gv()
        {

            Teacher t = new Teacher();
            t.ID = 1;
            t.Name = "ANV";
            t.UnionMember = false;
            t.Seniority = 1;
            double salary = t.GetSalary();
            Assert.AreEqual("28625",salary);

        }
    }
}