//------------------------------------------------------------------------------
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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In computing and telecommunications, a unit of information is the capacity of some standard data storage system or communication channel, used to measure the capacities of other systems and channels. In information theory, units of information are also used to measure the information contents or entropy of random variables.
    /// </summary>
    public struct  Information
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly InformationUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public InformationUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Information(double value, InformationUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static InformationUnit BaseUnit { get; } = InformationUnit.Bit;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Information MaxValue { get; } = new Information(79228162514264337593543950335d, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Information MinValue { get; } = new Information(-79228162514264337593543950335d, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Information Zero { get; } = new Information(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Information in Bits.
        /// </summary>
        public double Bits => As(InformationUnit.Bit);

        /// <summary>
        ///     Get Information in Bytes.
        /// </summary>
        public double Bytes => As(InformationUnit.Byte);

        /// <summary>
        ///     Get Information in Exabits.
        /// </summary>
        public double Exabits => As(InformationUnit.Exabit);

        /// <summary>
        ///     Get Information in Exabytes.
        /// </summary>
        public double Exabytes => As(InformationUnit.Exabyte);

        /// <summary>
        ///     Get Information in Exbibits.
        /// </summary>
        public double Exbibits => As(InformationUnit.Exbibit);

        /// <summary>
        ///     Get Information in Exbibytes.
        /// </summary>
        public double Exbibytes => As(InformationUnit.Exbibyte);

        /// <summary>
        ///     Get Information in Gibibits.
        /// </summary>
        public double Gibibits => As(InformationUnit.Gibibit);

        /// <summary>
        ///     Get Information in Gibibytes.
        /// </summary>
        public double Gibibytes => As(InformationUnit.Gibibyte);

        /// <summary>
        ///     Get Information in Gigabits.
        /// </summary>
        public double Gigabits => As(InformationUnit.Gigabit);

        /// <summary>
        ///     Get Information in Gigabytes.
        /// </summary>
        public double Gigabytes => As(InformationUnit.Gigabyte);

        /// <summary>
        ///     Get Information in Kibibits.
        /// </summary>
        public double Kibibits => As(InformationUnit.Kibibit);

        /// <summary>
        ///     Get Information in Kibibytes.
        /// </summary>
        public double Kibibytes => As(InformationUnit.Kibibyte);

        /// <summary>
        ///     Get Information in Kilobits.
        /// </summary>
        public double Kilobits => As(InformationUnit.Kilobit);

        /// <summary>
        ///     Get Information in Kilobytes.
        /// </summary>
        public double Kilobytes => As(InformationUnit.Kilobyte);

        /// <summary>
        ///     Get Information in Mebibits.
        /// </summary>
        public double Mebibits => As(InformationUnit.Mebibit);

        /// <summary>
        ///     Get Information in Mebibytes.
        /// </summary>
        public double Mebibytes => As(InformationUnit.Mebibyte);

        /// <summary>
        ///     Get Information in Megabits.
        /// </summary>
        public double Megabits => As(InformationUnit.Megabit);

        /// <summary>
        ///     Get Information in Megabytes.
        /// </summary>
        public double Megabytes => As(InformationUnit.Megabyte);

        /// <summary>
        ///     Get Information in Pebibits.
        /// </summary>
        public double Pebibits => As(InformationUnit.Pebibit);

        /// <summary>
        ///     Get Information in Pebibytes.
        /// </summary>
        public double Pebibytes => As(InformationUnit.Pebibyte);

        /// <summary>
        ///     Get Information in Petabits.
        /// </summary>
        public double Petabits => As(InformationUnit.Petabit);

        /// <summary>
        ///     Get Information in Petabytes.
        /// </summary>
        public double Petabytes => As(InformationUnit.Petabyte);

        /// <summary>
        ///     Get Information in Tebibits.
        /// </summary>
        public double Tebibits => As(InformationUnit.Tebibit);

        /// <summary>
        ///     Get Information in Tebibytes.
        /// </summary>
        public double Tebibytes => As(InformationUnit.Tebibyte);

        /// <summary>
        ///     Get Information in Terabits.
        /// </summary>
        public double Terabits => As(InformationUnit.Terabit);

        /// <summary>
        ///     Get Information in Terabytes.
        /// </summary>
        public double Terabytes => As(InformationUnit.Terabyte);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Information from Bits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromBits(double bits) => new Information(bits, InformationUnit.Bit);

        /// <summary>
        ///     Get Information from Bytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromBytes(double bytes) => new Information(bytes, InformationUnit.Byte);

        /// <summary>
        ///     Get Information from Exabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromExabits(double exabits) => new Information(exabits, InformationUnit.Exabit);

        /// <summary>
        ///     Get Information from Exabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromExabytes(double exabytes) => new Information(exabytes, InformationUnit.Exabyte);

        /// <summary>
        ///     Get Information from Exbibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromExbibits(double exbibits) => new Information(exbibits, InformationUnit.Exbibit);

        /// <summary>
        ///     Get Information from Exbibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromExbibytes(double exbibytes) => new Information(exbibytes, InformationUnit.Exbibyte);

        /// <summary>
        ///     Get Information from Gibibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromGibibits(double gibibits) => new Information(gibibits, InformationUnit.Gibibit);

        /// <summary>
        ///     Get Information from Gibibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromGibibytes(double gibibytes) => new Information(gibibytes, InformationUnit.Gibibyte);

        /// <summary>
        ///     Get Information from Gigabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromGigabits(double gigabits) => new Information(gigabits, InformationUnit.Gigabit);

        /// <summary>
        ///     Get Information from Gigabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromGigabytes(double gigabytes) => new Information(gigabytes, InformationUnit.Gigabyte);

        /// <summary>
        ///     Get Information from Kibibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromKibibits(double kibibits) => new Information(kibibits, InformationUnit.Kibibit);

        /// <summary>
        ///     Get Information from Kibibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromKibibytes(double kibibytes) => new Information(kibibytes, InformationUnit.Kibibyte);

        /// <summary>
        ///     Get Information from Kilobits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromKilobits(double kilobits) => new Information(kilobits, InformationUnit.Kilobit);

        /// <summary>
        ///     Get Information from Kilobytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromKilobytes(double kilobytes) => new Information(kilobytes, InformationUnit.Kilobyte);

        /// <summary>
        ///     Get Information from Mebibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromMebibits(double mebibits) => new Information(mebibits, InformationUnit.Mebibit);

        /// <summary>
        ///     Get Information from Mebibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromMebibytes(double mebibytes) => new Information(mebibytes, InformationUnit.Mebibyte);

        /// <summary>
        ///     Get Information from Megabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromMegabits(double megabits) => new Information(megabits, InformationUnit.Megabit);

        /// <summary>
        ///     Get Information from Megabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromMegabytes(double megabytes) => new Information(megabytes, InformationUnit.Megabyte);

        /// <summary>
        ///     Get Information from Pebibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromPebibits(double pebibits) => new Information(pebibits, InformationUnit.Pebibit);

        /// <summary>
        ///     Get Information from Pebibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromPebibytes(double pebibytes) => new Information(pebibytes, InformationUnit.Pebibyte);

        /// <summary>
        ///     Get Information from Petabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromPetabits(double petabits) => new Information(petabits, InformationUnit.Petabit);

        /// <summary>
        ///     Get Information from Petabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromPetabytes(double petabytes) => new Information(petabytes, InformationUnit.Petabyte);

        /// <summary>
        ///     Get Information from Tebibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromTebibits(double tebibits) => new Information(tebibits, InformationUnit.Tebibit);

        /// <summary>
        ///     Get Information from Tebibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromTebibytes(double tebibytes) => new Information(tebibytes, InformationUnit.Tebibyte);

        /// <summary>
        ///     Get Information from Terabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromTerabits(double terabits) => new Information(terabits, InformationUnit.Terabit);

        /// <summary>
        ///     Get Information from Terabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromTerabytes(double terabytes) => new Information(terabytes, InformationUnit.Terabyte);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="InformationUnit" /> to <see cref="Information" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Information unit value.</returns>
        public static Information From(double value, InformationUnit fromUnit)
        {
            return new Information(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(InformationUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Information ToUnit(InformationUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new Information(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case InformationUnit.Bit: return _value;
                case InformationUnit.Byte: return _value*8d;
                case InformationUnit.Exabit: return (_value) * 1e18d;
                case InformationUnit.Exabyte: return (_value*8d) * 1e18d;
                case InformationUnit.Exbibit: return (_value) * (1024d * 1024 * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Exbibyte: return (_value*8d) * (1024d * 1024 * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Gibibit: return (_value) * (1024d * 1024 * 1024);
                case InformationUnit.Gibibyte: return (_value*8d) * (1024d * 1024 * 1024);
                case InformationUnit.Gigabit: return (_value) * 1e9d;
                case InformationUnit.Gigabyte: return (_value*8d) * 1e9d;
                case InformationUnit.Kibibit: return (_value) * 1024d;
                case InformationUnit.Kibibyte: return (_value*8d) * 1024d;
                case InformationUnit.Kilobit: return (_value) * 1e3d;
                case InformationUnit.Kilobyte: return (_value*8d) * 1e3d;
                case InformationUnit.Mebibit: return (_value) * (1024d * 1024);
                case InformationUnit.Mebibyte: return (_value*8d) * (1024d * 1024);
                case InformationUnit.Megabit: return (_value) * 1e6d;
                case InformationUnit.Megabyte: return (_value*8d) * 1e6d;
                case InformationUnit.Pebibit: return (_value) * (1024d * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Pebibyte: return (_value*8d) * (1024d * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Petabit: return (_value) * 1e15d;
                case InformationUnit.Petabyte: return (_value*8d) * 1e15d;
                case InformationUnit.Tebibit: return (_value) * (1024d * 1024 * 1024 * 1024);
                case InformationUnit.Tebibyte: return (_value*8d) * (1024d * 1024 * 1024 * 1024);
                case InformationUnit.Terabit: return (_value) * 1e12d;
                case InformationUnit.Terabyte: return (_value*8d) * 1e12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(InformationUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case InformationUnit.Bit: return baseUnitValue;
                case InformationUnit.Byte: return baseUnitValue/8d;
                case InformationUnit.Exabit: return (baseUnitValue) / 1e18d;
                case InformationUnit.Exabyte: return (baseUnitValue/8d) / 1e18d;
                case InformationUnit.Exbibit: return (baseUnitValue) / (1024d * 1024 * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Exbibyte: return (baseUnitValue/8d) / (1024d * 1024 * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Gibibit: return (baseUnitValue) / (1024d * 1024 * 1024);
                case InformationUnit.Gibibyte: return (baseUnitValue/8d) / (1024d * 1024 * 1024);
                case InformationUnit.Gigabit: return (baseUnitValue) / 1e9d;
                case InformationUnit.Gigabyte: return (baseUnitValue/8d) / 1e9d;
                case InformationUnit.Kibibit: return (baseUnitValue) / 1024d;
                case InformationUnit.Kibibyte: return (baseUnitValue/8d) / 1024d;
                case InformationUnit.Kilobit: return (baseUnitValue) / 1e3d;
                case InformationUnit.Kilobyte: return (baseUnitValue/8d) / 1e3d;
                case InformationUnit.Mebibit: return (baseUnitValue) / (1024d * 1024);
                case InformationUnit.Mebibyte: return (baseUnitValue/8d) / (1024d * 1024);
                case InformationUnit.Megabit: return (baseUnitValue) / 1e6d;
                case InformationUnit.Megabyte: return (baseUnitValue/8d) / 1e6d;
                case InformationUnit.Pebibit: return (baseUnitValue) / (1024d * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Pebibyte: return (baseUnitValue/8d) / (1024d * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Petabit: return (baseUnitValue) / 1e15d;
                case InformationUnit.Petabyte: return (baseUnitValue/8d) / 1e15d;
                case InformationUnit.Tebibit: return (baseUnitValue) / (1024d * 1024 * 1024 * 1024);
                case InformationUnit.Tebibyte: return (baseUnitValue/8d) / (1024d * 1024 * 1024 * 1024);
                case InformationUnit.Terabit: return (baseUnitValue) / 1e12d;
                case InformationUnit.Terabyte: return (baseUnitValue/8d) / 1e12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

