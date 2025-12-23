using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cwiczenie2;

namespace Cw1Testy
{
    public class ArrayAnalyzerTesty
    {
        private ArrayAnalyzer _analyzer;
        
        
        [SetUp]
        public void Setup()
        {
            _analyzer = new ArrayAnalyzer();
        }

        [Test]
        public void ObliczSrednia_DlaLiczbCalkowitych_ZwracaPoprawnyWynik()
        {
            //Arrange 
            int[] dane = { 5, 10, 15 };
            double spodziewanyWynik = 10;
            //Act
            double rzeczywistyWynik = _analyzer.ObliczSrednia(dane);
            //Assert

            Assert.AreEqual(spodziewanyWynik, rzeczywistyWynik);
        }
    }
}
