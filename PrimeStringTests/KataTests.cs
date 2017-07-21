using NUnit.Framework;

namespace PrimeString.Tests
{
	[TestFixture()]
	public class KataTests
	{
		[TestCase("x", ExpectedResult = true, TestName = "Input_x_shouldBe_true")]
		[TestCase("abac", ExpectedResult = true, TestName = "Input_abac_shouldBe_true")]
		[TestCase("abab", ExpectedResult = false, TestName = "Input_abab_shouldBe_false")]
		[TestCase("aaaa", ExpectedResult = false, TestName = "Input_aaaa_shouldBe_false")]
		[TestCase("abc", ExpectedResult = true, TestName = "Input_abc_shouldBe_true")]
		[TestCase("fdsyffdsyffdsyffdsyffdsyf", ExpectedResult = false, TestName = "Input_fdsyffdsyffdsyffdsyffdsyf_shouldBe_false")]
		[TestCase("utdutdtdutd", ExpectedResult = true, TestName = "Input_utdutdtdutd_shouldBe_true")]
		[TestCase("abba", ExpectedResult = true, TestName = "Input_abba_shouldBe_true")]
		public bool PrimeStringTest(string input)
		{
			var target = new Kata();
			return target.PrimeString(input);
		}
	}
}