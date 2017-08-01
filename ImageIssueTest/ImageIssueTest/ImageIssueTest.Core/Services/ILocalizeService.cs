using System.Globalization;

namespace ImageIssueTest.Core.Services
{
	public interface ILocalizeService
	{
		CultureInfo GetCurrentCultureInfo();
	}
}
