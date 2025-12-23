using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordManager;

namespace Testy
{
    public class PasswordManagerTesty
    {
        PasswordManagers _passwordManager;

        [SetUp]
        public void setup()
        {
            _passwordManager = new PasswordManagers();
        }

        [Test]
        public void SprawdzanieHasla_DlaSilnegoHasla_OczekiwanyWynikPozytywny()
        {
            string haslo = "Jan@12345";
            bool wynikRzeczywisty = _passwordManager.czyHasloJestSilne(haslo);

            Assert.IsTrue(wynikRzeczywisty);

        }

        [Test]
        public void SprawdzanieHasla_DlaKrotkiegoHasla_OczekiwanyWynikNegatywny()
        {
            string haslo = "Jan@1";
            bool wynikRzeczywisty = _passwordManager.czyHasloJestSilne(haslo);

            Assert.IsFalse(wynikRzeczywisty);

        }

        [Test]
        public void SprawdzanieHasla_DlaNiekapletnegoHasla_OczekiwanyWynikNegatywny()
        {
            string haslo = "Jan12345";
            bool wynikRzeczywisty = _passwordManager.czyHasloJestSilne(haslo);

            Assert.IsFalse(wynikRzeczywisty);

        }

        [Test]
        public void SprawdzanieHasla_DlaPustegoHasla_OczekiwanyWynikWyjatek()
        {
            string haslo = null;

            Assert.Throws<ArgumentNullException>(() => _passwordManager.czyHasloJestSilne(haslo));
        }
    }
}
