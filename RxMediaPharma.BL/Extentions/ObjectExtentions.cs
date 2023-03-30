using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL
{
	public static class ObjectExtensions
	{
		public static T As<T>(this object obj)
			where T : class
		{
			return (T)obj;
		}

		public static T To<T>(this object obj)
			where T : struct
		{
			try
			{
				if (obj == null) return default(T);

				if (obj == DBNull.Value) return default(T);

				if (typeof(T) == typeof(Guid) || typeof(T) == typeof(TimeSpan))
				{
					return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(obj.ToString());
				}

				if (typeof(T).IsEnum)
				{
					if (Enum.IsDefined(typeof(T), obj))
					{
						return (T)Enum.Parse(typeof(T), obj.ToString());
					}

					throw new ArgumentException($"Enum type undefined '{obj}'.");
				}

				return (T)Convert.ChangeType(obj, typeof(T), CultureInfo.GetCultureInfo("tr-TR"));
			}
			catch (Exception ex)
			{

				//throw;
			}
			return default(T);

		}

		public static bool IsIn<T>(this T item, params T[] list)
		{
			return list.Contains(item);
		}

		public static bool IsNull(this object obj)
		{
			return obj == null;
		}

		public static bool IsNotNull(this object obj)
		{
			return obj != null;
		}

		public static bool IsDBNull<T>(this T obj) where T : class
		{
			return Convert.IsDBNull(obj);
		}

		public static bool IsDefault<T>(this T obj)
		{
			return obj.Equals(default(T));
		}

		public static object GetPropertyValue<T>(this T obj, string propertyName)
		{
			Type type = obj.GetType();
			PropertyInfo property = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
			return property.GetValue(obj, null);
		}

		public static decimal MoneyToDec(this object obj)
		{
			return obj.ToString().Replace(NumberFormatInfo.CurrentInfo.CurrencySymbol, "").Trim().To<decimal>();
		}

		public static bool IsAttributeDefined(this object obj, Type attributeType, bool inherit)
		{
			return obj.GetType().IsDefined(attributeType, inherit);
		}

		public static bool IsAttributeDefined<T>(this object obj, bool inherit) where T : Attribute
		{
			return obj.GetType().IsDefined(typeof(T), inherit);
		}

		public static T GetCustomAttribute<T>(this object obj) where T : Attribute
		{
			var type = obj.GetType();

			return (T)(type.IsEnum ? Attribute.GetCustomAttribute(type.GetField(obj.ToString()), typeof(T)) : Attribute.GetCustomAttribute(type, typeof(T)));
		}

		public static T GetCustomAttribute<T>(this object obj, bool inherit) where T : Attribute
		{
			var type = obj.GetType();

			return (T)(type.IsEnum ? Attribute.GetCustomAttribute(type.GetField(obj.ToString()), typeof(T), inherit) : Attribute.GetCustomAttribute(type, typeof(T), inherit));
		}

		public static bool IsTypeOf<T>(this T obj, Type type)
		{
			return obj.GetType() == type;
		}

		public static bool IsAssignableFrom<T>(this object obj)
		{
			Type type = obj.GetType();
			return type.IsAssignableFrom(typeof(T));
		}

		public static bool IsAssignableFrom(this object obj, Type targetType)
		{
			Type type = obj.GetType();
			return type.IsAssignableFrom(targetType);
		}

		public static PropertyInfo[] GetProperties(this object obj)
		{
			return obj.GetType().GetProperties();
		}

		public static PropertyInfo GetProperty<T>(this T obj, string name)
		{
			return obj.GetType().GetProperty(name);
		}

		public static PropertyInfo GetProperty<T>(this T obj, string name, BindingFlags bindingAttr)
		{
			return obj.GetType().GetProperty(name, bindingAttr);
		}

		public static void CopyPropertiesFrom(this object self, object parent)
		{
			if (parent == null) return;
			var fromProperties = parent.GetType().GetProperties();
			var toProperties = self.GetType().GetProperties();

			foreach (var fromProperty in fromProperties)
			{
				foreach (var toProperty in toProperties)
				{
					if (fromProperty.Name == toProperty.Name)
					{
						if (fromProperty.PropertyType == toProperty.PropertyType)
						{
							toProperty.SetValue(self, fromProperty.GetValue(parent));
						}
						else if (toProperty.PropertyType.IsGenericType && toProperty.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
						{
							if (fromProperty.PropertyType == Nullable.GetUnderlyingType(toProperty.PropertyType))
							{
								toProperty.SetValue(self, fromProperty.GetValue(parent));
							}
						}

						break;
					}
				}
			}
		}

		public static dynamic ToDynamic<T>(this T obj)
		{
			IDictionary<string, object> expando = new ExpandoObject();

			foreach (var propertyInfo in typeof(T).GetProperties())
			{
				var currentValue = propertyInfo.GetValue(obj);
				expando.Add(propertyInfo.Name, currentValue);
			}
			return expando as ExpandoObject;
		}

		public static bool IsChanged(this object obj, object newObj)
		{
			bool result = false;
			var oldType = obj.GetType();
			var newType = newObj.GetType();
			if (oldType != newType) return result;

			var oldProperties = oldType.GetProperties();
			var newProperties = newType.GetProperties();

			foreach (var oldProperty in oldProperties)
			{
				if (oldProperty.IsDefined(typeof(Attribute))) continue;

				var matchingProperty = newProperties.FirstOrDefault(x => x.Name == oldProperty.Name && x.PropertyType == oldProperty.PropertyType);
				if (matchingProperty == null) continue;
				var oldValue = oldProperty.GetValue(obj)?.ToString() ?? "";
				var newValue = matchingProperty.GetValue(newObj)?.ToString() ?? "";
				if (oldValue != newValue)
				{
					result = true;
					break;
				}
			}

			return result;
		}

		public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool condition, Func<TSource, bool> predicate)
		{
			return condition ? source.Where(predicate) : source;
		}
	}
}
