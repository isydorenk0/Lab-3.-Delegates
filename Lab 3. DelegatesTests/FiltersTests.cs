using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class FiltersTests
    {
        [TestMethod()]
        public void GetFilterTest_NoFilter()
        {
            List<Message> messages =  ProcessFile.ProcessMessages("MessagesTest.csv", 20, 0);
            FiltersFlds filterFlds = new FiltersFlds(null, DateTime.MinValue, DateTime.MaxValue, null, "And");
            Filters filter = new Filters();
            var query = filter.GetFilter(filterFlds, messages);

            Assert.AreEqual(20, query.Count());
        }

        [TestMethod()]
        public void GetFilterTest_FilterDates()
        {
            List<Message> messages = ProcessFile.ProcessMessages("MessagesTest.csv", 20, 0);
            DateTime minDate = Convert.ToDateTime("02-10-2020");
            DateTime maxDate = Convert.ToDateTime("04-10-2020"); ;
            FiltersFlds filterFlds = new FiltersFlds(null, minDate, maxDate, null, "And");
            Filters filter = new Filters();
            var query = filter.GetFilter(filterFlds, messages);

            Assert.AreEqual(12, query.Count());
        }
        [TestMethod()]
        public void GetFilterTest_FilterDatesANDNumber()
        {
            List<Message> messages = ProcessFile.ProcessMessages("MessagesTest.csv", 20, 0);
            DateTime minDate = Convert.ToDateTime("02-10-2020");
            DateTime maxDate = Convert.ToDateTime("04-10-2020"); ;
            FiltersFlds filterFlds = new FiltersFlds("1", minDate, maxDate, null, "AND");
            Filters filter = new Filters();
            var query = filter.GetFilter(filterFlds, messages);

            Assert.AreEqual(3, query.Count());
        }
        [TestMethod()]
        public void GetFilterTest_FilterDatesORNumber()
        {
            List<Message> messages = ProcessFile.ProcessMessages("MessagesTest.csv", 20, 0);
            DateTime minDate = Convert.ToDateTime("02-10-2020");
            DateTime maxDate = Convert.ToDateTime("04-10-2020"); ;
            FiltersFlds filterFlds = new FiltersFlds("1", minDate, maxDate, null, "OR");
            Filters filter = new Filters();
            var query = filter.GetFilter(filterFlds, messages);

            Assert.AreEqual(14, query.Count());
        }
        [TestMethod()]
        public void GetFilterTest_FilterDatesANDNumberANDText()
        {
            List<Message> messages = ProcessFile.ProcessMessages("MessagesTest.csv", 20, 0);
            DateTime minDate = Convert.ToDateTime("02-10-2020");
            DateTime maxDate = Convert.ToDateTime("02-10-2020"); ;
            FiltersFlds filterFlds = new FiltersFlds("1", minDate, maxDate, "ge 1", "AND");
            Filters filter = new Filters();
            var query = filter.GetFilter(filterFlds, messages);

            Assert.AreEqual(0, query.Count());
        }
        [TestMethod()]
        public void GetFilterTest_FilterDatesORNumberORText()
        {
            List<Message> messages = ProcessFile.ProcessMessages("MessagesTest.csv", 20, 0);
            DateTime minDate = Convert.ToDateTime("02-10-2020");
            DateTime maxDate = Convert.ToDateTime("02-10-2020"); ;
            FiltersFlds filterFlds = new FiltersFlds("1", minDate, maxDate, "ge 10", "OR");
            Filters filter = new Filters();
            var query = filter.GetFilter(filterFlds, messages);

            Assert.AreEqual(9, query.Count());
        }
    }
}