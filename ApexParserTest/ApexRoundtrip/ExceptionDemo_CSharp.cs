namespace ApexSharpDemo.ApexCode
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.Extensions;
    using Apex.System;
    using SObjects;

    public class ExceptionDemo
    {
        public static void CatchDemo()
        {
            try
            {
                ThrowDemo();
            }
            catch (MathException e)
            {
                System.Debug(e.GetMessage());
            }
            finally
            {
                System.Debug("Finally");
            }
        }

        public static void ThrowDemo()
        {
            throw new MathException("something bad happened!");
        }
    }
}
