using System.Text.RegularExpressions;

namespace INVZAV.lib.Classes
{
	public static partial class CellsConverter
	{
		private static readonly Regex regex_twoCells = TwoCellsRegex();
		private static readonly Regex regex_oneCell = OneCellRegex();
		public static (long inv, long zav) INVZAVConvert(string cells, out bool isBoth)
		{
			if (cells.Length == 0)
			{
				isBoth = false;
				return (0, 0);
			}
			long inv, zav = 0;
			Match m = regex_twoCells.Match(cells);
			GroupCollection gc = m.Groups;
			if (isBoth = m.Success)
			{
				_ = long.TryParse(gc[1].Value, out inv);
				_ = long.TryParse(gc[2].Value, out zav);
			}
			else _ = long.TryParse(regex_oneCell.Match(cells).Value, out inv);
			return (inv, zav);
		}
		public static string INVZAVFormat(long inv, long zav) => $"инв.№{(inv == 0 ? "" : inv)}, зав.№{(zav == 0 ? "" : zav)};";
		public static string INVZAVFormat((long inv, long zav) tuple) => INVZAVFormat(tuple.inv, tuple.zav);
		public static string AutoINVZAV(string cells) => INVZAVFormat(INVZAVConvert(cells, out _));

		[GeneratedRegex(@"(?<inv>\d+)\s(?<zav>\d+)")]
		private static partial Regex TwoCellsRegex();
		[GeneratedRegex(@"(?<inv>\d+)")]
		private static partial Regex OneCellRegex();
	}
}
