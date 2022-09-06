using System;


namespace R5T.L0023
{
    /// <summary>
    /// An minimal class containing:
    /// * Instance Field
    /// * Instance Property
    /// * Instance Method
    /// * Static Field
    /// * Static Property
    /// * Static Method
    /// </summary>
    public class ClassA
    {
        #region Static

#pragma warning disable CA2211 // Non-constant fields should not be visible
        public static string StaticField;
#pragma warning restore CA2211 // Non-constant fields should not be visible

        public static string StaticProperty { get; set; }


        public static void StaticMethod(string argument)
        {
            Console.WriteLine($"In {nameof(ClassA)}.{nameof(ClassA.StaticMethod)}: {argument}.");
        }

        #endregion


        public string InstanceField;

        public static string InstanceProperty { get; set; }


        public static void InstanceMethod(string argument)
        {
            Console.WriteLine($"In {nameof(ClassA)}.{nameof(ClassA.InstanceMethod)}: {argument}.");
        }
    }
}
