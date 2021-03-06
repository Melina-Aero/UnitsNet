﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In physics and engineering, in particular fluid dynamics and hydrometry, the volumetric flow rate, (also known as volume flow rate, rate of fluid flow or volume velocity) is the volume of fluid which passes through a given surface per unit time. The SI unit is m³/s (cubic meters per second). In US Customary Units and British Imperial Units, volumetric flow rate is often expressed as ft³/s (cubic feet per second). It is usually represented by the symbol Q.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Flow : IComparable, IComparable<Flow>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Flow from nullable CentilitersPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCentilitersPerMinute(QuantityValue? centilitersperminute)
        {
            return centilitersperminute.HasValue ? FromCentilitersPerMinute(centilitersperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicDecimetersPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicDecimetersPerMinute(QuantityValue? cubicdecimetersperminute)
        {
            return cubicdecimetersperminute.HasValue ? FromCubicDecimetersPerMinute(cubicdecimetersperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicFeetPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicFeetPerHour(QuantityValue? cubicfeetperhour)
        {
            return cubicfeetperhour.HasValue ? FromCubicFeetPerHour(cubicfeetperhour.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicFeetPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicFeetPerMinute(QuantityValue? cubicfeetperminute)
        {
            return cubicfeetperminute.HasValue ? FromCubicFeetPerMinute(cubicfeetperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicFeetPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicFeetPerSecond(QuantityValue? cubicfeetpersecond)
        {
            return cubicfeetpersecond.HasValue ? FromCubicFeetPerSecond(cubicfeetpersecond.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicMetersPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicMetersPerHour(QuantityValue? cubicmetersperhour)
        {
            return cubicmetersperhour.HasValue ? FromCubicMetersPerHour(cubicmetersperhour.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicMetersPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicMetersPerMinute(QuantityValue? cubicmetersperminute)
        {
            return cubicmetersperminute.HasValue ? FromCubicMetersPerMinute(cubicmetersperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicMetersPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicMetersPerSecond(QuantityValue? cubicmeterspersecond)
        {
            return cubicmeterspersecond.HasValue ? FromCubicMetersPerSecond(cubicmeterspersecond.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicYardsPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicYardsPerHour(QuantityValue? cubicyardsperhour)
        {
            return cubicyardsperhour.HasValue ? FromCubicYardsPerHour(cubicyardsperhour.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicYardsPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicYardsPerMinute(QuantityValue? cubicyardsperminute)
        {
            return cubicyardsperminute.HasValue ? FromCubicYardsPerMinute(cubicyardsperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable CubicYardsPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromCubicYardsPerSecond(QuantityValue? cubicyardspersecond)
        {
            return cubicyardspersecond.HasValue ? FromCubicYardsPerSecond(cubicyardspersecond.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable DecilitersPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromDecilitersPerMinute(QuantityValue? decilitersperminute)
        {
            return decilitersperminute.HasValue ? FromDecilitersPerMinute(decilitersperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable KilolitersPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromKilolitersPerMinute(QuantityValue? kilolitersperminute)
        {
            return kilolitersperminute.HasValue ? FromKilolitersPerMinute(kilolitersperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable LitersPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromLitersPerHour(QuantityValue? litersperhour)
        {
            return litersperhour.HasValue ? FromLitersPerHour(litersperhour.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable LitersPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromLitersPerMinute(QuantityValue? litersperminute)
        {
            return litersperminute.HasValue ? FromLitersPerMinute(litersperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable LitersPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromLitersPerSecond(QuantityValue? literspersecond)
        {
            return literspersecond.HasValue ? FromLitersPerSecond(literspersecond.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable MicrolitersPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromMicrolitersPerMinute(QuantityValue? microlitersperminute)
        {
            return microlitersperminute.HasValue ? FromMicrolitersPerMinute(microlitersperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable MillilitersPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromMillilitersPerMinute(QuantityValue? millilitersperminute)
        {
            return millilitersperminute.HasValue ? FromMillilitersPerMinute(millilitersperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable MillionUsGallonsPerDay.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromMillionUsGallonsPerDay(QuantityValue? millionusgallonsperday)
        {
            return millionusgallonsperday.HasValue ? FromMillionUsGallonsPerDay(millionusgallonsperday.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable NanolitersPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromNanolitersPerMinute(QuantityValue? nanolitersperminute)
        {
            return nanolitersperminute.HasValue ? FromNanolitersPerMinute(nanolitersperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable OilBarrelsPerDay.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromOilBarrelsPerDay(QuantityValue? oilbarrelsperday)
        {
            return oilbarrelsperday.HasValue ? FromOilBarrelsPerDay(oilbarrelsperday.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable UsGallonsPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromUsGallonsPerHour(QuantityValue? usgallonsperhour)
        {
            return usgallonsperhour.HasValue ? FromUsGallonsPerHour(usgallonsperhour.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable UsGallonsPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromUsGallonsPerMinute(QuantityValue? usgallonsperminute)
        {
            return usgallonsperminute.HasValue ? FromUsGallonsPerMinute(usgallonsperminute.Value) : default(Flow?);
        }

        /// <summary>
        ///     Get nullable Flow from nullable UsGallonsPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Flow? FromUsGallonsPerSecond(QuantityValue? usgallonspersecond)
        {
            return usgallonspersecond.HasValue ? FromUsGallonsPerSecond(usgallonspersecond.Value) : default(Flow?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="FlowUnit" /> to <see cref="Flow" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Flow unit value.</returns>
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Flow? From(QuantityValue? value, FlowUnit fromUnit)
        {
            return value.HasValue ? new Flow((double)value.Value, fromUnit) : default(Flow?);
        }

        #endregion

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(FlowUnit unit, [CanBeNull] IFormatProvider provider)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #region Arithmetic Operators

        public static Flow operator -(Flow right)
        {
            return new Flow(-right.Value, right.Unit);
        }

        public static Flow operator +(Flow left, Flow right)
        {
            return new Flow(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Flow operator -(Flow left, Flow right)
        {
            return new Flow(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Flow operator *(double left, Flow right)
        {
            return new Flow(left * right.Value, right.Unit);
        }

        public static Flow operator *(Flow left, double right)
        {
            return new Flow(left.Value * right, left.Unit);
        }

        public static Flow operator /(Flow left, double right)
        {
            return new Flow(left.Value / right, left.Unit);
        }

        public static double operator /(Flow left, Flow right)
        {
            return left.CubicMetersPerSecond / right.CubicMetersPerSecond;
        }

        #endregion

        public static bool operator <=(Flow left, Flow right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Flow left, Flow right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Flow left, Flow right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Flow left, Flow right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(Flow, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public static bool operator ==(Flow left, Flow right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(Flow, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public static bool operator !=(Flow left, Flow right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Flow Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<Flow, FlowUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    FlowUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromCubicMetersPerSecond(x.CubicMetersPerSecond + y.CubicMetersPerSecond));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out Flow result)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            try
            {
                result = Parse(str, provider);
                return true;
            }
            catch
            {
                result = default(Flow);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        [Obsolete("Use overload that takes IFormatProvider instead of culture name. This method was only added to support WindowsRuntimeComponent and will be removed from .NET Framework targets.")]
        public static FlowUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static FlowUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<FlowUnit>(str.Trim());

            if (unit == FlowUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized FlowUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(FlowUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(FlowUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(FlowUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}
