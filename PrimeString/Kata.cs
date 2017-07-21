namespace PrimeString
{
	public class Kata
	{
		public bool PrimeString(string s)
		{
			if (s.Length <= 1)
				return true;
			for (int i = 1; i <= s.Length/2; i++)
			{
				var patern = s.Substring(0, i);
				var tmp = s;
				if (tmp.Replace(patern, string.Empty) == string.Empty)
					return false;
			}
			return true;
		}
	}
}