﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Slack
{
	public class UnixDateTimeConverter : DateTimeConverterBase
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			long ticks;
			if (value is DateTime)
			{
				var epoc = new DateTime(1970, 1, 1);
				var delta = (DateTime)value - epoc;
				if (delta.TotalSeconds < 0)
					throw new ArgumentOutOfRangeException(nameof(value));
				ticks = (long)delta.TotalSeconds;
			}
			else
			{
				throw new Exception("Expected date object value.");
			}
			writer.WriteValue(ticks);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue,JsonSerializer serializer)
		{
			if (reader.TokenType != JsonToken.Integer)
				throw new Exception($"Unexpected token parsing date. Expected Integer, got {reader.TokenType}.");

			var ticks = (long)reader.Value;

			var date = new DateTime(1970, 1, 1);
			date = date.AddSeconds(ticks);

			return date;
		}
	}
}
