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
    ///     The SpecificEnergy
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Specific_energy
    /// </remarks>
    public struct  SpecificEnergy
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly SpecificEnergyUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public SpecificEnergyUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public SpecificEnergy(double value, SpecificEnergyUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static SpecificEnergyUnit BaseUnit { get; } = SpecificEnergyUnit.JoulePerKilogram;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static SpecificEnergy MaxValue { get; } = new SpecificEnergy(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static SpecificEnergy MinValue { get; } = new SpecificEnergy(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static SpecificEnergy Zero { get; } = new SpecificEnergy(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get SpecificEnergy in BtuPerPound.
        /// </summary>
        public double BtuPerPound => As(SpecificEnergyUnit.BtuPerPound);

        /// <summary>
        ///     Get SpecificEnergy in CaloriesPerGram.
        /// </summary>
        public double CaloriesPerGram => As(SpecificEnergyUnit.CaloriePerGram);

        /// <summary>
        ///     Get SpecificEnergy in GigawattDaysPerKilogram.
        /// </summary>
        public double GigawattDaysPerKilogram => As(SpecificEnergyUnit.GigawattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in GigawattDaysPerShortTon.
        /// </summary>
        public double GigawattDaysPerShortTon => As(SpecificEnergyUnit.GigawattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy in GigawattDaysPerTonne.
        /// </summary>
        public double GigawattDaysPerTonne => As(SpecificEnergyUnit.GigawattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy in GigawattHoursPerKilogram.
        /// </summary>
        public double GigawattHoursPerKilogram => As(SpecificEnergyUnit.GigawattHourPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in JoulesPerKilogram.
        /// </summary>
        public double JoulesPerKilogram => As(SpecificEnergyUnit.JoulePerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in KilocaloriesPerGram.
        /// </summary>
        public double KilocaloriesPerGram => As(SpecificEnergyUnit.KilocaloriePerGram);

        /// <summary>
        ///     Get SpecificEnergy in KilojoulesPerKilogram.
        /// </summary>
        public double KilojoulesPerKilogram => As(SpecificEnergyUnit.KilojoulePerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in KilowattDaysPerKilogram.
        /// </summary>
        public double KilowattDaysPerKilogram => As(SpecificEnergyUnit.KilowattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in KilowattDaysPerShortTon.
        /// </summary>
        public double KilowattDaysPerShortTon => As(SpecificEnergyUnit.KilowattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy in KilowattDaysPerTonne.
        /// </summary>
        public double KilowattDaysPerTonne => As(SpecificEnergyUnit.KilowattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy in KilowattHoursPerKilogram.
        /// </summary>
        public double KilowattHoursPerKilogram => As(SpecificEnergyUnit.KilowattHourPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in MegajoulesPerKilogram.
        /// </summary>
        public double MegajoulesPerKilogram => As(SpecificEnergyUnit.MegajoulePerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in MegawattDaysPerKilogram.
        /// </summary>
        public double MegawattDaysPerKilogram => As(SpecificEnergyUnit.MegawattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in MegawattDaysPerShortTon.
        /// </summary>
        public double MegawattDaysPerShortTon => As(SpecificEnergyUnit.MegawattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy in MegawattDaysPerTonne.
        /// </summary>
        public double MegawattDaysPerTonne => As(SpecificEnergyUnit.MegawattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy in MegawattHoursPerKilogram.
        /// </summary>
        public double MegawattHoursPerKilogram => As(SpecificEnergyUnit.MegawattHourPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in TerawattDaysPerKilogram.
        /// </summary>
        public double TerawattDaysPerKilogram => As(SpecificEnergyUnit.TerawattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in TerawattDaysPerShortTon.
        /// </summary>
        public double TerawattDaysPerShortTon => As(SpecificEnergyUnit.TerawattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy in TerawattDaysPerTonne.
        /// </summary>
        public double TerawattDaysPerTonne => As(SpecificEnergyUnit.TerawattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy in WattDaysPerKilogram.
        /// </summary>
        public double WattDaysPerKilogram => As(SpecificEnergyUnit.WattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy in WattDaysPerShortTon.
        /// </summary>
        public double WattDaysPerShortTon => As(SpecificEnergyUnit.WattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy in WattDaysPerTonne.
        /// </summary>
        public double WattDaysPerTonne => As(SpecificEnergyUnit.WattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy in WattHoursPerKilogram.
        /// </summary>
        public double WattHoursPerKilogram => As(SpecificEnergyUnit.WattHourPerKilogram);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get SpecificEnergy from BtuPerPound.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromBtuPerPound(double btuperpound) => new SpecificEnergy(btuperpound, SpecificEnergyUnit.BtuPerPound);

        /// <summary>
        ///     Get SpecificEnergy from CaloriesPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromCaloriesPerGram(double caloriespergram) => new SpecificEnergy(caloriespergram, SpecificEnergyUnit.CaloriePerGram);

        /// <summary>
        ///     Get SpecificEnergy from GigawattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromGigawattDaysPerKilogram(double gigawattdaysperkilogram) => new SpecificEnergy(gigawattdaysperkilogram, SpecificEnergyUnit.GigawattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from GigawattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromGigawattDaysPerShortTon(double gigawattdayspershortton) => new SpecificEnergy(gigawattdayspershortton, SpecificEnergyUnit.GigawattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy from GigawattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromGigawattDaysPerTonne(double gigawattdayspertonne) => new SpecificEnergy(gigawattdayspertonne, SpecificEnergyUnit.GigawattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy from GigawattHoursPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromGigawattHoursPerKilogram(double gigawatthoursperkilogram) => new SpecificEnergy(gigawatthoursperkilogram, SpecificEnergyUnit.GigawattHourPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from JoulesPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromJoulesPerKilogram(double joulesperkilogram) => new SpecificEnergy(joulesperkilogram, SpecificEnergyUnit.JoulePerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from KilocaloriesPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromKilocaloriesPerGram(double kilocaloriespergram) => new SpecificEnergy(kilocaloriespergram, SpecificEnergyUnit.KilocaloriePerGram);

        /// <summary>
        ///     Get SpecificEnergy from KilojoulesPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromKilojoulesPerKilogram(double kilojoulesperkilogram) => new SpecificEnergy(kilojoulesperkilogram, SpecificEnergyUnit.KilojoulePerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from KilowattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromKilowattDaysPerKilogram(double kilowattdaysperkilogram) => new SpecificEnergy(kilowattdaysperkilogram, SpecificEnergyUnit.KilowattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from KilowattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromKilowattDaysPerShortTon(double kilowattdayspershortton) => new SpecificEnergy(kilowattdayspershortton, SpecificEnergyUnit.KilowattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy from KilowattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromKilowattDaysPerTonne(double kilowattdayspertonne) => new SpecificEnergy(kilowattdayspertonne, SpecificEnergyUnit.KilowattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy from KilowattHoursPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromKilowattHoursPerKilogram(double kilowatthoursperkilogram) => new SpecificEnergy(kilowatthoursperkilogram, SpecificEnergyUnit.KilowattHourPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from MegajoulesPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromMegajoulesPerKilogram(double megajoulesperkilogram) => new SpecificEnergy(megajoulesperkilogram, SpecificEnergyUnit.MegajoulePerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from MegawattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromMegawattDaysPerKilogram(double megawattdaysperkilogram) => new SpecificEnergy(megawattdaysperkilogram, SpecificEnergyUnit.MegawattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from MegawattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromMegawattDaysPerShortTon(double megawattdayspershortton) => new SpecificEnergy(megawattdayspershortton, SpecificEnergyUnit.MegawattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy from MegawattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromMegawattDaysPerTonne(double megawattdayspertonne) => new SpecificEnergy(megawattdayspertonne, SpecificEnergyUnit.MegawattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy from MegawattHoursPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromMegawattHoursPerKilogram(double megawatthoursperkilogram) => new SpecificEnergy(megawatthoursperkilogram, SpecificEnergyUnit.MegawattHourPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from TerawattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromTerawattDaysPerKilogram(double terawattdaysperkilogram) => new SpecificEnergy(terawattdaysperkilogram, SpecificEnergyUnit.TerawattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from TerawattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromTerawattDaysPerShortTon(double terawattdayspershortton) => new SpecificEnergy(terawattdayspershortton, SpecificEnergyUnit.TerawattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy from TerawattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromTerawattDaysPerTonne(double terawattdayspertonne) => new SpecificEnergy(terawattdayspertonne, SpecificEnergyUnit.TerawattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy from WattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromWattDaysPerKilogram(double wattdaysperkilogram) => new SpecificEnergy(wattdaysperkilogram, SpecificEnergyUnit.WattDayPerKilogram);

        /// <summary>
        ///     Get SpecificEnergy from WattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromWattDaysPerShortTon(double wattdayspershortton) => new SpecificEnergy(wattdayspershortton, SpecificEnergyUnit.WattDayPerShortTon);

        /// <summary>
        ///     Get SpecificEnergy from WattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromWattDaysPerTonne(double wattdayspertonne) => new SpecificEnergy(wattdayspertonne, SpecificEnergyUnit.WattDayPerTonne);

        /// <summary>
        ///     Get SpecificEnergy from WattHoursPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEnergy FromWattHoursPerKilogram(double watthoursperkilogram) => new SpecificEnergy(watthoursperkilogram, SpecificEnergyUnit.WattHourPerKilogram);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SpecificEnergyUnit" /> to <see cref="SpecificEnergy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>SpecificEnergy unit value.</returns>
        public static SpecificEnergy From(double value, SpecificEnergyUnit fromUnit)
        {
            return new SpecificEnergy(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(SpecificEnergyUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public SpecificEnergy ToUnit(SpecificEnergyUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new SpecificEnergy(convertedValue, unit);
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
                SpecificEnergyUnit.BtuPerPound => _value*2326.000075362,
                SpecificEnergyUnit.CaloriePerGram => _value*4.184e3,
                SpecificEnergyUnit.GigawattDayPerKilogram => (_value*(24*3.6e3)) * 1e9d,
                SpecificEnergyUnit.GigawattDayPerShortTon => (_value*((24*3.6e3)/9.0718474e2)) * 1e9d,
                SpecificEnergyUnit.GigawattDayPerTonne => (_value*((24*3.6e3)/1e3)) * 1e9d,
                SpecificEnergyUnit.GigawattHourPerKilogram => (_value*3.6e3) * 1e9d,
                SpecificEnergyUnit.JoulePerKilogram => _value,
                SpecificEnergyUnit.KilocaloriePerGram => (_value*4.184e3) * 1e3d,
                SpecificEnergyUnit.KilojoulePerKilogram => (_value) * 1e3d,
                SpecificEnergyUnit.KilowattDayPerKilogram => (_value*(24*3.6e3)) * 1e3d,
                SpecificEnergyUnit.KilowattDayPerShortTon => (_value*((24*3.6e3)/9.0718474e2)) * 1e3d,
                SpecificEnergyUnit.KilowattDayPerTonne => (_value*((24*3.6e3)/1e3)) * 1e3d,
                SpecificEnergyUnit.KilowattHourPerKilogram => (_value*3.6e3) * 1e3d,
                SpecificEnergyUnit.MegajoulePerKilogram => (_value) * 1e6d,
                SpecificEnergyUnit.MegawattDayPerKilogram => (_value*(24*3.6e3)) * 1e6d,
                SpecificEnergyUnit.MegawattDayPerShortTon => (_value*((24*3.6e3)/9.0718474e2)) * 1e6d,
                SpecificEnergyUnit.MegawattDayPerTonne => (_value*((24*3.6e3)/1e3)) * 1e6d,
                SpecificEnergyUnit.MegawattHourPerKilogram => (_value*3.6e3) * 1e6d,
                SpecificEnergyUnit.TerawattDayPerKilogram => (_value*(24*3.6e3)) * 1e12d,
                SpecificEnergyUnit.TerawattDayPerShortTon => (_value*((24*3.6e3)/9.0718474e2)) * 1e12d,
                SpecificEnergyUnit.TerawattDayPerTonne => (_value*((24*3.6e3)/1e3)) * 1e12d,
                SpecificEnergyUnit.WattDayPerKilogram => _value*(24*3.6e3),
                SpecificEnergyUnit.WattDayPerShortTon => _value*((24*3.6e3)/9.0718474e2),
                SpecificEnergyUnit.WattDayPerTonne => _value*((24*3.6e3)/1e3),
                SpecificEnergyUnit.WattHourPerKilogram => _value*3.6e3,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(SpecificEnergyUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                SpecificEnergyUnit.BtuPerPound => baseUnitValue/2326.000075362,
                SpecificEnergyUnit.CaloriePerGram => baseUnitValue/4.184e3,
                SpecificEnergyUnit.GigawattDayPerKilogram => (baseUnitValue/(24*3.6e3)) / 1e9d,
                SpecificEnergyUnit.GigawattDayPerShortTon => (baseUnitValue/((24*3.6e3)/9.0718474e2)) / 1e9d,
                SpecificEnergyUnit.GigawattDayPerTonne => (baseUnitValue/((24*3.6e3)/1e3)) / 1e9d,
                SpecificEnergyUnit.GigawattHourPerKilogram => (baseUnitValue/3.6e3) / 1e9d,
                SpecificEnergyUnit.JoulePerKilogram => baseUnitValue,
                SpecificEnergyUnit.KilocaloriePerGram => (baseUnitValue/4.184e3) / 1e3d,
                SpecificEnergyUnit.KilojoulePerKilogram => (baseUnitValue) / 1e3d,
                SpecificEnergyUnit.KilowattDayPerKilogram => (baseUnitValue/(24*3.6e3)) / 1e3d,
                SpecificEnergyUnit.KilowattDayPerShortTon => (baseUnitValue/((24*3.6e3)/9.0718474e2)) / 1e3d,
                SpecificEnergyUnit.KilowattDayPerTonne => (baseUnitValue/((24*3.6e3)/1e3)) / 1e3d,
                SpecificEnergyUnit.KilowattHourPerKilogram => (baseUnitValue/3.6e3) / 1e3d,
                SpecificEnergyUnit.MegajoulePerKilogram => (baseUnitValue) / 1e6d,
                SpecificEnergyUnit.MegawattDayPerKilogram => (baseUnitValue/(24*3.6e3)) / 1e6d,
                SpecificEnergyUnit.MegawattDayPerShortTon => (baseUnitValue/((24*3.6e3)/9.0718474e2)) / 1e6d,
                SpecificEnergyUnit.MegawattDayPerTonne => (baseUnitValue/((24*3.6e3)/1e3)) / 1e6d,
                SpecificEnergyUnit.MegawattHourPerKilogram => (baseUnitValue/3.6e3) / 1e6d,
                SpecificEnergyUnit.TerawattDayPerKilogram => (baseUnitValue/(24*3.6e3)) / 1e12d,
                SpecificEnergyUnit.TerawattDayPerShortTon => (baseUnitValue/((24*3.6e3)/9.0718474e2)) / 1e12d,
                SpecificEnergyUnit.TerawattDayPerTonne => (baseUnitValue/((24*3.6e3)/1e3)) / 1e12d,
                SpecificEnergyUnit.WattDayPerKilogram => baseUnitValue/(24*3.6e3),
                SpecificEnergyUnit.WattDayPerShortTon => baseUnitValue/((24*3.6e3)/9.0718474e2),
                SpecificEnergyUnit.WattDayPerTonne => baseUnitValue/((24*3.6e3)/1e3),
                SpecificEnergyUnit.WattHourPerKilogram => baseUnitValue/3.6e3,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

