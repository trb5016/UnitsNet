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
    ///     The volume concentration (not to be confused with volume fraction) is defined as the volume of a constituent divided by the total volume of the mixture.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Concentration#Volume_concentration
    /// </remarks>
    public struct  VolumeConcentration
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly VolumeConcentrationUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public VolumeConcentrationUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public VolumeConcentration(double value, VolumeConcentrationUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static VolumeConcentrationUnit BaseUnit { get; } = VolumeConcentrationUnit.DecimalFraction;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static VolumeConcentration MaxValue { get; } = new VolumeConcentration(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static VolumeConcentration MinValue { get; } = new VolumeConcentration(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static VolumeConcentration Zero { get; } = new VolumeConcentration(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get VolumeConcentration in CentilitersPerLiter.
        /// </summary>
        public double CentilitersPerLiter => As(VolumeConcentrationUnit.CentilitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration in CentilitersPerMililiter.
        /// </summary>
        public double CentilitersPerMililiter => As(VolumeConcentrationUnit.CentilitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration in DecilitersPerLiter.
        /// </summary>
        public double DecilitersPerLiter => As(VolumeConcentrationUnit.DecilitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration in DecilitersPerMililiter.
        /// </summary>
        public double DecilitersPerMililiter => As(VolumeConcentrationUnit.DecilitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration in DecimalFractions.
        /// </summary>
        public double DecimalFractions => As(VolumeConcentrationUnit.DecimalFraction);

        /// <summary>
        ///     Get VolumeConcentration in LitersPerLiter.
        /// </summary>
        public double LitersPerLiter => As(VolumeConcentrationUnit.LitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration in LitersPerMililiter.
        /// </summary>
        public double LitersPerMililiter => As(VolumeConcentrationUnit.LitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration in MicrolitersPerLiter.
        /// </summary>
        public double MicrolitersPerLiter => As(VolumeConcentrationUnit.MicrolitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration in MicrolitersPerMililiter.
        /// </summary>
        public double MicrolitersPerMililiter => As(VolumeConcentrationUnit.MicrolitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration in MillilitersPerLiter.
        /// </summary>
        public double MillilitersPerLiter => As(VolumeConcentrationUnit.MillilitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration in MillilitersPerMililiter.
        /// </summary>
        public double MillilitersPerMililiter => As(VolumeConcentrationUnit.MillilitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration in NanolitersPerLiter.
        /// </summary>
        public double NanolitersPerLiter => As(VolumeConcentrationUnit.NanolitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration in NanolitersPerMililiter.
        /// </summary>
        public double NanolitersPerMililiter => As(VolumeConcentrationUnit.NanolitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration in PartsPerBillion.
        /// </summary>
        public double PartsPerBillion => As(VolumeConcentrationUnit.PartPerBillion);

        /// <summary>
        ///     Get VolumeConcentration in PartsPerMillion.
        /// </summary>
        public double PartsPerMillion => As(VolumeConcentrationUnit.PartPerMillion);

        /// <summary>
        ///     Get VolumeConcentration in PartsPerThousand.
        /// </summary>
        public double PartsPerThousand => As(VolumeConcentrationUnit.PartPerThousand);

        /// <summary>
        ///     Get VolumeConcentration in PartsPerTrillion.
        /// </summary>
        public double PartsPerTrillion => As(VolumeConcentrationUnit.PartPerTrillion);

        /// <summary>
        ///     Get VolumeConcentration in Percent.
        /// </summary>
        public double Percent => As(VolumeConcentrationUnit.Percent);

        /// <summary>
        ///     Get VolumeConcentration in PicolitersPerLiter.
        /// </summary>
        public double PicolitersPerLiter => As(VolumeConcentrationUnit.PicolitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration in PicolitersPerMililiter.
        /// </summary>
        public double PicolitersPerMililiter => As(VolumeConcentrationUnit.PicolitersPerMililiter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get VolumeConcentration from CentilitersPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromCentilitersPerLiter(double centilitersperliter) => new VolumeConcentration(centilitersperliter, VolumeConcentrationUnit.CentilitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration from CentilitersPerMililiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromCentilitersPerMililiter(double centiliterspermililiter) => new VolumeConcentration(centiliterspermililiter, VolumeConcentrationUnit.CentilitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration from DecilitersPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromDecilitersPerLiter(double decilitersperliter) => new VolumeConcentration(decilitersperliter, VolumeConcentrationUnit.DecilitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration from DecilitersPerMililiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromDecilitersPerMililiter(double deciliterspermililiter) => new VolumeConcentration(deciliterspermililiter, VolumeConcentrationUnit.DecilitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration from DecimalFractions.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromDecimalFractions(double decimalfractions) => new VolumeConcentration(decimalfractions, VolumeConcentrationUnit.DecimalFraction);

        /// <summary>
        ///     Get VolumeConcentration from LitersPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromLitersPerLiter(double litersperliter) => new VolumeConcentration(litersperliter, VolumeConcentrationUnit.LitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration from LitersPerMililiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromLitersPerMililiter(double literspermililiter) => new VolumeConcentration(literspermililiter, VolumeConcentrationUnit.LitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration from MicrolitersPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromMicrolitersPerLiter(double microlitersperliter) => new VolumeConcentration(microlitersperliter, VolumeConcentrationUnit.MicrolitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration from MicrolitersPerMililiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromMicrolitersPerMililiter(double microliterspermililiter) => new VolumeConcentration(microliterspermililiter, VolumeConcentrationUnit.MicrolitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration from MillilitersPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromMillilitersPerLiter(double millilitersperliter) => new VolumeConcentration(millilitersperliter, VolumeConcentrationUnit.MillilitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration from MillilitersPerMililiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromMillilitersPerMililiter(double milliliterspermililiter) => new VolumeConcentration(milliliterspermililiter, VolumeConcentrationUnit.MillilitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration from NanolitersPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromNanolitersPerLiter(double nanolitersperliter) => new VolumeConcentration(nanolitersperliter, VolumeConcentrationUnit.NanolitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration from NanolitersPerMililiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromNanolitersPerMililiter(double nanoliterspermililiter) => new VolumeConcentration(nanoliterspermililiter, VolumeConcentrationUnit.NanolitersPerMililiter);

        /// <summary>
        ///     Get VolumeConcentration from PartsPerBillion.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromPartsPerBillion(double partsperbillion) => new VolumeConcentration(partsperbillion, VolumeConcentrationUnit.PartPerBillion);

        /// <summary>
        ///     Get VolumeConcentration from PartsPerMillion.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromPartsPerMillion(double partspermillion) => new VolumeConcentration(partspermillion, VolumeConcentrationUnit.PartPerMillion);

        /// <summary>
        ///     Get VolumeConcentration from PartsPerThousand.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromPartsPerThousand(double partsperthousand) => new VolumeConcentration(partsperthousand, VolumeConcentrationUnit.PartPerThousand);

        /// <summary>
        ///     Get VolumeConcentration from PartsPerTrillion.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromPartsPerTrillion(double partspertrillion) => new VolumeConcentration(partspertrillion, VolumeConcentrationUnit.PartPerTrillion);

        /// <summary>
        ///     Get VolumeConcentration from Percent.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromPercent(double percent) => new VolumeConcentration(percent, VolumeConcentrationUnit.Percent);

        /// <summary>
        ///     Get VolumeConcentration from PicolitersPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromPicolitersPerLiter(double picolitersperliter) => new VolumeConcentration(picolitersperliter, VolumeConcentrationUnit.PicolitersPerLiter);

        /// <summary>
        ///     Get VolumeConcentration from PicolitersPerMililiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeConcentration FromPicolitersPerMililiter(double picoliterspermililiter) => new VolumeConcentration(picoliterspermililiter, VolumeConcentrationUnit.PicolitersPerMililiter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VolumeConcentrationUnit" /> to <see cref="VolumeConcentration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>VolumeConcentration unit value.</returns>
        public static VolumeConcentration From(double value, VolumeConcentrationUnit fromUnit)
        {
            return new VolumeConcentration(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(VolumeConcentrationUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public VolumeConcentration ToUnit(VolumeConcentrationUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new VolumeConcentration(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                VolumeConcentrationUnit.CentilitersPerLiter => (_value) * 1e-2d,
                VolumeConcentrationUnit.CentilitersPerMililiter => (_value/1e-3) * 1e-2d,
                VolumeConcentrationUnit.DecilitersPerLiter => (_value) * 1e-1d,
                VolumeConcentrationUnit.DecilitersPerMililiter => (_value/1e-3) * 1e-1d,
                VolumeConcentrationUnit.DecimalFraction => _value,
                VolumeConcentrationUnit.LitersPerLiter => _value,
                VolumeConcentrationUnit.LitersPerMililiter => _value/1e-3,
                VolumeConcentrationUnit.MicrolitersPerLiter => (_value) * 1e-6d,
                VolumeConcentrationUnit.MicrolitersPerMililiter => (_value/1e-3) * 1e-6d,
                VolumeConcentrationUnit.MillilitersPerLiter => (_value) * 1e-3d,
                VolumeConcentrationUnit.MillilitersPerMililiter => (_value/1e-3) * 1e-3d,
                VolumeConcentrationUnit.NanolitersPerLiter => (_value) * 1e-9d,
                VolumeConcentrationUnit.NanolitersPerMililiter => (_value/1e-3) * 1e-9d,
                VolumeConcentrationUnit.PartPerBillion => _value/1e9,
                VolumeConcentrationUnit.PartPerMillion => _value/1e6,
                VolumeConcentrationUnit.PartPerThousand => _value/1e3,
                VolumeConcentrationUnit.PartPerTrillion => _value/1e12,
                VolumeConcentrationUnit.Percent => _value/1e2,
                VolumeConcentrationUnit.PicolitersPerLiter => (_value) * 1e-12d,
                VolumeConcentrationUnit.PicolitersPerMililiter => (_value/1e-3) * 1e-12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(VolumeConcentrationUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                VolumeConcentrationUnit.CentilitersPerLiter => (baseUnitValue) / 1e-2d,
                VolumeConcentrationUnit.CentilitersPerMililiter => (baseUnitValue*1e-3) / 1e-2d,
                VolumeConcentrationUnit.DecilitersPerLiter => (baseUnitValue) / 1e-1d,
                VolumeConcentrationUnit.DecilitersPerMililiter => (baseUnitValue*1e-3) / 1e-1d,
                VolumeConcentrationUnit.DecimalFraction => baseUnitValue,
                VolumeConcentrationUnit.LitersPerLiter => baseUnitValue,
                VolumeConcentrationUnit.LitersPerMililiter => baseUnitValue*1e-3,
                VolumeConcentrationUnit.MicrolitersPerLiter => (baseUnitValue) / 1e-6d,
                VolumeConcentrationUnit.MicrolitersPerMililiter => (baseUnitValue*1e-3) / 1e-6d,
                VolumeConcentrationUnit.MillilitersPerLiter => (baseUnitValue) / 1e-3d,
                VolumeConcentrationUnit.MillilitersPerMililiter => (baseUnitValue*1e-3) / 1e-3d,
                VolumeConcentrationUnit.NanolitersPerLiter => (baseUnitValue) / 1e-9d,
                VolumeConcentrationUnit.NanolitersPerMililiter => (baseUnitValue*1e-3) / 1e-9d,
                VolumeConcentrationUnit.PartPerBillion => baseUnitValue*1e9,
                VolumeConcentrationUnit.PartPerMillion => baseUnitValue*1e6,
                VolumeConcentrationUnit.PartPerThousand => baseUnitValue*1e3,
                VolumeConcentrationUnit.PartPerTrillion => baseUnitValue*1e12,
                VolumeConcentrationUnit.Percent => baseUnitValue*1e2,
                VolumeConcentrationUnit.PicolitersPerLiter => (baseUnitValue) / 1e-12d,
                VolumeConcentrationUnit.PicolitersPerMililiter => (baseUnitValue*1e-3) / 1e-12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

