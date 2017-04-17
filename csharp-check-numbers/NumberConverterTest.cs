using NUnit.Framework;

namespace csharp_check_numbers
{
    public class NumberConverterTest
    {
        [Test]
        public void zero()
        {
            Assert.That(NumberConverter.ToWords(0), Is.EqualTo("zero"));
        }

        /*
        [Test]
        public void single_digit()
        {
            Assert.That(NumberConverter.ToWords(1), Is.EqualTo("one"));
            Assert.That(NumberConverter.ToWords(9), Is.EqualTo("nine"));
        }

        [Test]
        public void special_case_two_digit()
        {
            Assert.That(NumberConverter.ToWords(10), Is.EqualTo("ten"));
            Assert.That(NumberConverter.ToWords(19), Is.EqualTo("nineteen"));
        }

        [Test]
        public void multiples_of_ten()
        {
            Assert.That(NumberConverter.ToWords(20), Is.EqualTo("twenty"));
            Assert.That(NumberConverter.ToWords(90), Is.EqualTo("ninety"));
        }

        [Test]
        public void not_multiples_of_ten_21_to_99()
        {
            Assert.That(NumberConverter.ToWords(21), Is.EqualTo("twenty-one"));
            Assert.That(NumberConverter.ToWords(55), Is.EqualTo("fifty-five"));
            Assert.That(NumberConverter.ToWords(99), Is.EqualTo("ninety-nine"));
        }

        [Test]
        public void hundreds()
        {
            Assert.That(NumberConverter.ToWords(100), Is.EqualTo("one hundred"));
            Assert.That(NumberConverter.ToWords(900), Is.EqualTo("nine hundred"));
        }

        [Test]
        public void not_multiples_of_one_hundred_LT_1000()
        {
            Assert.That(NumberConverter.ToWords(101), Is.EqualTo("one hundred one"));
            Assert.That(NumberConverter.ToWords(999), Is.EqualTo("nine hundred ninety-nine"));
        }

        [Test]
        public void thousands()
        {
            Assert.That(NumberConverter.ToWords(1000), Is.EqualTo("one thousand"));
            Assert.That(NumberConverter.ToWords(9000), Is.EqualTo("nine thousand"));
        }

        [Test]
        public void not_even_thousands()
        {
            Assert.That(NumberConverter.ToWords(9999), Is.EqualTo("nine thousand nine hundred ninety-nine"));
            Assert.That(NumberConverter.ToWords(9911), Is.EqualTo("nine thousand nine hundred eleven"));
        }

        [Test]
        public void tens_of_thousands()
        {
            Assert.That(NumberConverter.ToWords(10000), Is.EqualTo("ten thousand"));
            Assert.That(NumberConverter.ToWords(19000), Is.EqualTo("nineteen thousand"));
        }

        [Test]
        public void tens_of_thousands_and_some()
        {
            Assert.That(NumberConverter.ToWords(19999), Is.EqualTo("nineteen thousand nine hundred ninety-nine"));
        }

        [Test]
        public void hundred_thousand()
        {
            Assert.That(NumberConverter.ToWords(100000), Is.EqualTo("one hundred thousand"));
            Assert.That(NumberConverter.ToWords(700000), Is.EqualTo("seven hundred thousand"));
        }

        [Test]
        public void not_exactly_hundred_thousand()
        {
            Assert.That(NumberConverter.ToWords(198000), Is.EqualTo("one hundred ninety-eight thousand"));
            Assert.That(NumberConverter.ToWords(701020), Is.EqualTo("seven hundred one thousand twenty"));
        }

        [Test]
        public void millions()
        {
            Assert.That(NumberConverter.ToWords(1000000), Is.EqualTo("one million"));
        }
        */
    }
}
