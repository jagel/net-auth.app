using domain.Application.ExceptionHandler;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace context.Tools
{
    public static class Converters
    {
        public static ValueConverter FromEnum<TEnum>() where TEnum : Enum
        {
            if (!typeof(TEnum).IsEnum)
                throw new ExceptionConvertion(
                    $"Parse Exception conversion error, trying to parse {typeof(TEnum).Name} to Enum",
                    $"{typeof(TEnum).Name} is not an Enum");

            var converter = new ValueConverter<TEnum, string>(
                    v => v.ToString(),
                    v => (TEnum)Enum.Parse(typeof(TEnum), v));

            return converter;
        }
    }
}
