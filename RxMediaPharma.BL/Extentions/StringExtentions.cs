using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

using Newtonsoft.Json;

namespace RxMediaPharma.BL
{
	public static class StringExtensions
	{
		public static bool IsNull(this string val)
		{
			return val == null;
		}

		public static bool IsNullOrEmpty(this string str)
		{
			return string.IsNullOrEmpty(str);
		}

		public static bool IsNotNullOrEmpty(this string str)
		{
			return !string.IsNullOrEmpty(str);
		}

		public static bool IsNullOrWhiteSpace(this string str)
		{
			return string.IsNullOrWhiteSpace(str);
		}

		public static string Left(this string str, int len)
		{
			if (str == null) throw new ArgumentNullException("str");

			if (str.Length < len)
				throw new ArgumentException("len");

			return str.Substring(0, len);
		}

		public static string Right(this string str, int len)
		{
			if (str == null)
				throw new ArgumentNullException("str");

			if (str.Length < len)
				throw new ArgumentException("len");

			return str.Substring(str.Length - len, len);
		}

		public static int ToInt32(this string value)
		{
			int.TryParse(value, out var number);
			return number;
		}

		public static long ToInt64(this string value)
		{
			long.TryParse(value, out var number);
			return number;
		}

		public static short ToInt16(this string value)
		{
			short.TryParse(value, out var number);
			return number;
		}

		public static decimal ToDecimal(this string value)
		{
			decimal.TryParse(value, out var number);
			return number;
		}

		public static bool ToBoolean(this string value)
		{
			bool.TryParse(value, out var result);
			return result;
		}

		public static byte ToByte(this string value)
		{
			byte.TryParse(value, out var result);
			return result;
		}

		public static double ToDouble(this string value)
		{
			double.TryParse(value, out var result);
			return result;
		}

		public static DateTime ToDateTime(this string value)
		{
			DateTime.TryParse(value, out var result);
			return result;
		}

		public static int? ToNullableInt32(this string value)
		{
			return int.TryParse(value, out var result) ? result : (int?)null;
		}

		public static long? ToNullableInt64(this string value)
		{
			return long.TryParse(value, out var result) ? result : (long?)null;
		}

		public static short? ToNullableInt16(this string value)
		{
			return short.TryParse(value, out var result) ? result : (short?)null;
		}

		public static decimal? ToNullableDecimal(this string value)
		{
			return decimal.TryParse(value, out var result) ? result : (decimal?)null;
		}

		public static bool? ToNullableBoolean(this string value)
		{
			return bool.TryParse(value, out var result) ? result : (bool?)null;
		}

		public static byte? ToNullableByte(this string value)
		{
			return byte.TryParse(value, out var result) ? result : (byte?)null;
		}

		public static double? ToNullableDouble(this string value)
		{
			return double.TryParse(value, out var result) ? result : (double?)null;
		}

		public static DateTime? ToNullableDateTime(this string value)
		{
			return DateTime.TryParse(value, out var result) ? result : new DateTime?();
		}

		public static string ConcatIf(this string str, bool condition, string added)
		{
			return condition ? string.Concat(str, added) : str;
		}

		public static string ConcatIf(this string str, bool condition, string added, string elseAdded)
		{
			return condition ? string.Concat(str, added) : string.Concat(str, elseAdded);
		}

		public static bool IsDateTime(this string data, string dateFormat)
		{
			return DateTime.TryParseExact(data, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None,
				out _);
		}

		public static string ToCamelCase(this string str, bool invariantCulture = true)
		{
			if (string.IsNullOrWhiteSpace(str))
				return str;

			if (str.Length == 1)
				return invariantCulture ? str.ToLowerInvariant() : str.ToLower();

			return (invariantCulture ? char.ToLowerInvariant(str[0]) : char.ToLower(str[0])) + str.Substring(1);
		}

		public static string ToCamelCase(this string str, CultureInfo culture)
		{
			if (string.IsNullOrWhiteSpace(str))
				return str;

			if (str.Length == 1)
				return str.ToLower(culture);

			return char.ToLower(str[0], culture) + str.Substring(1);
		}

		public static string ToSentenceCase(this string str, bool invariantCulture = false)
		{
			if (string.IsNullOrWhiteSpace(str))
				return str;

			return Regex.Replace(str, "[a-z][A-Z]",
				m => m.Value[0] + " " +
					 (invariantCulture ? char.ToLowerInvariant(m.Value[1]) : char.ToLower(m.Value[1])));
		}

		public static string ToSentenceCase(this string str, CultureInfo culture)
		{
			if (string.IsNullOrWhiteSpace(str)) return str;
			return Regex.Replace(str, "[a-z][A-Z]", m => m.Value[0] + " " + char.ToLower(m.Value[1], culture));
		}

		public static T ToEnum<T>(this string value)
			where T : struct
		{
			if (value == null) throw new ArgumentNullException(nameof(value));
			return (T)Enum.Parse(typeof(T), value);
		}

		public static T ToEnum<T>(this string value, bool ignoreCase) where T : struct
		{
			return value == null
				? throw new ArgumentNullException(nameof(value))
				: (T)Enum.Parse(typeof(T), value, ignoreCase);
		}

		public static string ToPascalCase(this string str, bool invariantCulture = true)
		{
			if (string.IsNullOrWhiteSpace(str))
				return str;

			if (str.Length == 1)
				return invariantCulture ? str.ToUpperInvariant() : str.ToUpper();

			return (invariantCulture ? char.ToUpperInvariant(str[0]) : char.ToUpper(str[0])) + str.Substring(1);
		}

		public static string ToPascalCase(this string str, CultureInfo culture)
		{
			return string.IsNullOrWhiteSpace(str)
				? str
				: (str.Length == 1 ? str.ToUpper(culture) : char.ToUpper(str[0], culture) + str.Substring(1));
		}

		public static string Replace(this string s, params char[] chars)
		{
			return chars.Aggregate(s, (current, c) => current.Replace(c.ToString(CultureInfo.InvariantCulture), ""));
		}

		public static string RemoveChars(this string s, params char[] chars)
		{
			var sb = new StringBuilder(s.Length);
			foreach (char c in s.Where(c => !chars.Contains(c)))
			{
				sb.Append(c);
			}

			return sb.ToString();
		}

		public static bool IsEmailAddress(this string email)
		{
			if (email.IsNullOrEmpty()) return false;
			string pattern =
				"^[a-zA-Z][\\w\\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\\w\\.-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z\\.]*[a-zA-Z]$";
			return Regex.Match(email, pattern).Success;
		}


		public static bool IsNumeric(this string val)
		{
			bool isNum = double.TryParse(val, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out _);
			return isNum;
		}

		public static bool IsInteger(this string val)
		{
			bool isNum = int.TryParse(val, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out _);
			return isNum;
		}

		public static string GetDefaultIfEmpty(this string myValue, string defaultValue)
		{
			if (!string.IsNullOrEmpty(myValue))
			{
				myValue = myValue.Trim();
				return myValue.Length > 0 ? myValue : defaultValue;
			}

			return defaultValue;
		}

		public static string GetEmptyStringIfNull(this string val)
		{
			return (val != null ? val.Trim() : "");
		}

		public static string GetNullIfEmptyString(this string myValue)
		{
			if (myValue == null || myValue.Length <= 0)
			{
				return null;
			}

			myValue = myValue.Trim();
			if (myValue.Length > 0)
			{
				return myValue;
			}

			return null;
		}


		/// <summary>
		///     Reverse back or forward slashes
		/// </summary>
		/// <param name="val">string</param>
		/// <param name="direction">
		///     0 - replace forward slash with back
		///     1 - replace back with forward slash
		/// </param>
		/// <returns></returns>
		public static string ReverseSlash(this string val, int direction)
		{
			switch (direction)
			{
				case 0:
					return val.Replace(@"/", @"\");
				case 1:
					return val.Replace(@"\", @"/");
				default:
					return val;
			}
		}

		public static string ReplaceLineFeeds(this string val)
		{
			return Regex.Replace(val, @"^[\r\n]+|\.|[\r\n]+$", "");
		}


		public static bool IsMinLength(this string val, int minCharLength)
		{
			return val != null && val.Length >= minCharLength;
		}


		public static bool IsMaxLength(this string val, int maxCharLength)
		{
			return val != null && val.Length <= maxCharLength;
		}

		public static bool IsLength(this string val, int minCharLength, int maxCharLength)
		{
			return val != null && val.Length >= minCharLength && val.Length <= maxCharLength;
		}

		public static string NormalizeLineEndings(this string str)
		{
			return str.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", Environment.NewLine);
		}

		public static string[] Split(this string str, string separator)
		{
			return str.Split(new[] { separator }, StringSplitOptions.None);
		}

		public static string[] Split(this string str, string separator, StringSplitOptions options)
		{
			return str.Split(new[] { separator }, options);
		}

		public static string[] SplitToLines(this string str)
		{
			return str.Split(Environment.NewLine);
		}

		public static string[] SplitToLines(this string str, StringSplitOptions options)
		{
			return str.Split(Environment.NewLine, options);
		}

		public static string Truncate(this string str, int maxLength)
		{
			return str == null ? null : (str.Length <= maxLength ? str : str.Left(maxLength));
		}

		public static string Format(this string value, object arg0)
		{
			return string.Format(value, arg0);
		}

		public static string Format(this string value, params object[] args)
		{
			return string.Format(value, args);
		}

		public static string FirstCharacter(this string val)
		{
			return (!string.IsNullOrEmpty(val))
				? (val.Length >= 1)
					? val.Substring(0, 1)
					: val
				: null;
		}

		public static string LastCharacter(this string val)
		{
			return (!string.IsNullOrEmpty(val))
				? (val.Length >= 1)
					? val.Substring(val.Length - 1, 1)
					: val
				: null;
		}

		public static byte[] ToBytes(this string val)
		{
			var bytes = new byte[val.Length * sizeof(char)];
			Buffer.BlockCopy(val.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}

		public static string Reverse(this string val)
		{
			var chars = new char[val.Length];
			for (int i = val.Length - 1, j = 0; i >= 0; --i, ++j)
			{
				chars[j] = val[i];
			}

			val = new String(chars);
			return val;
		}

		public static int CountOccurrences(this string val, string stringToMatch)
		{
			return Regex.Matches(val, stringToMatch, RegexOptions.IgnoreCase).Count;
		}

		public static bool IsAlpha(this string val)
		{
			if (string.IsNullOrEmpty(val))
			{
				return false;
			}

			return val.Trim().Replace(" ", "").All(Char.IsLetter);
		}

		public static bool IsAlphaNumeric(this string val)
		{
			if (string.IsNullOrEmpty(val))
			{
				return false;
			}

			return val.Trim().Replace(" ", "").All(Char.IsLetterOrDigit);
		}

		public static string ToMd5(this string str)
		{
			using (var md5 = MD5.Create())
			{
				var inputBytes = Encoding.UTF8.GetBytes(str);
				var hashBytes = md5.ComputeHash(inputBytes);

				var sb = new StringBuilder();
				foreach (var hashByte in hashBytes)
					sb.Append(hashByte.ToString("X2"));

				return sb.ToString();
			}
		}

		public static string CreateHashSha512(string val)
		{
			if (string.IsNullOrEmpty(val))
			{
				throw new ArgumentException("val");
			}

			var sb = new StringBuilder();
			using (SHA512 hash = SHA512.Create())
			{
				byte[] data = hash.ComputeHash(val.ToBytes());
				foreach (byte b in data)
				{
					sb.Append(b.ToString("x2"));
				}
			}

			return sb.ToString();
		}

		public static string CreateHashSha256(string val)
		{
			if (string.IsNullOrEmpty(val))
			{
				throw new ArgumentException("val");
			}

			var sb = new StringBuilder();
			using (SHA256 hash = SHA256.Create())
			{
				byte[] data = hash.ComputeHash(val.ToBytes());
				foreach (byte b in data)
				{
					sb.Append(b.ToString("x2"));
				}
			}

			return sb.ToString();
		}

		public static string SplitAndGetElement(this string str, string separator, int order)
		{
			var list = str.Split(separator);
			if (!list.IsNull() && order <= list.Length)
			{
				return order <= 0 ? list[0] : list[order - 1];
			}

			return string.Empty;
		}

		public static string GetDigits(this string val)
		{
			return new string(val.Where(char.IsDigit).ToArray());
		}

		public static string GetLetterAndDigits(this string val)
		{
			return new string(val.Where(char.IsLetterOrDigit).ToArray());
		}

		public static string GetBarcode(this string val)
		{
			return new string(val.Where(c => char.IsLetterOrDigit(c) || c == '{' || c == '}').ToArray());
		}

		public static string Base64Encode(this string val)
		{
			var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(val);
			return System.Convert.ToBase64String(plainTextBytes);
		}

		public static string Base64Decode(this string val)
		{
			var base64EncodedBytes = System.Convert.FromBase64String(val);
			return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
		}

		public static string AppendTimeStamp(this string val, DateTime dateTime)
		{
			return string.Concat(
				Path.GetFileNameWithoutExtension(val),
				dateTime.ToString("yyyyMMddHHmmss"),
				Path.GetExtension(val)
			);
		}

		public static string ToFormattedJson(this string val)
		{
			if (val.IsNullOrEmpty()) return val;
			var obj = JsonConvert.DeserializeObject(val);
			var formatted = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
			return formatted;
		}

		public static string SyntaxHighlightJson(this string val)
		{
			if (val.IsNullOrEmpty()) return val;
			var str = Regex.Replace(
				val,
				@"(¤(\\u[a-zA-Z0-9]{4}|\\[^u]|[^\\¤])*¤(\s*:)?|\b(true|false|null)\b|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)"
					.Replace('¤', '"'),
				match =>
				{
					var cls = "number";
					var color = "style='color:red'";
					var indent = "";
					if (Regex.IsMatch(match.Value, @"^¤".Replace('¤', '"')))
					{
						cls = Regex.IsMatch(match.Value, ":$") ? "key" : "string";
					}
					else if (Regex.IsMatch(match.Value, "true|false"))
					{
						cls = "boolean";
					}
					else if (Regex.IsMatch(match.Value, "null"))
					{
						cls = "null";
					}

					if (cls == "key")
					{
						color = "style='color:black;'";
					}

					return (cls == "key" ? "<br/>" : "") + "<span " + color + " class=\"" + cls + "\">" + match +
						   "</span>";
				});

			return $@"<html><body>{str}</body></html>";
		}

		public static string RemoveHTMLTags(this string val)
		{
			return Regex.Replace(val, "<.*?>", string.Empty);
		}

		public static string SpecialCharacterScrubber(this string val)
		{
			if (val.IsNullOrEmpty()) return val;
			val = val.Replace("{", "{{");
			val = val.Replace("}", "}}");
			return val;
		}
	}
}
