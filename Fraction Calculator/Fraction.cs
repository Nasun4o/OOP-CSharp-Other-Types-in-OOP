using System;

namespace FractionCalculator
{
    struct Fraction
    {
        // Fields
        private long numerator;
        private long denominator;

        // Properties
        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denominator value cannot be zero.");
                }
                else
                {
                    this.denominator = value;
                }
            }
        }

        public Decimal FractionResult
        {
            get
            {
                Decimal fractionResult = (Decimal)this.Numerator / (Decimal)this.Denominator;
                return fractionResult;
            }
        }

        // Constructor
        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        // Methods
        public static Fraction operator +(Fraction fractionOne, Fraction fractionTwo)
        {
            long resultDenominator = fractionOne.Denominator * fractionTwo.Denominator;
            if (CheckNumber(resultDenominator) == false)
            {
                throw new ArgumentOutOfRangeException("The number is too big.");
            }
            long resultNumerator = (fractionOne.Numerator * fractionTwo.Denominator) + (fractionTwo.Numerator * fractionOne.Denominator);
            if (CheckNumber(resultNumerator) == false)
            {
                throw new ArgumentOutOfRangeException("The number is too big.");
            }
            return new Fraction((long)resultNumerator, (long)resultDenominator);
        }

        public static Fraction operator -(Fraction fractionOne, Fraction fractionTwo)
        {
            long resultDenominator = fractionOne.Denominator * fractionTwo.Denominator;
            if (CheckNumber(resultDenominator) == false)
            {
                throw new ArgumentOutOfRangeException("The number is too big.");
            }
            long resultNumerator = (fractionOne.Numerator * fractionTwo.Denominator) - (fractionTwo.Numerator * fractionOne.Denominator);
            if (CheckNumber(resultNumerator) == false)
            {
                throw new ArgumentOutOfRangeException("The number is too big.");
            }
            return new Fraction((long)resultNumerator, (long)resultDenominator);
        }

        private static bool CheckNumber(long number)
        {
            if ((number > long.MaxValue) || (number < long.MinValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", this.FractionResult);
        }
    }
}