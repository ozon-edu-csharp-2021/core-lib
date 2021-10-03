namespace CSharpCourse.Core.Lib.Enums
{
    /// <summary>
    /// Тип мерча, выдаваемого сотруднику.
    /// </summary>
    public enum MerchType
    {
        /// <summary>
        /// Набор мерча, выдаваемый сотруднику при устройстве на работу.
        /// </summary>
        /// <remarks>
        /// Носочки и футболочка.
        /// </remarks>
        WelcomePack,
        
        /// <summary>
        /// Набор мерча, выдаваемый сотруднику при посещении конференции.
        /// </summary>
        /// <remarks>
        /// Толстовочка.
        /// </remarks>
        ConferencePack,
        
        /// <summary>
        /// Набор мерча, выдаваемый сотруднику при успешном прохождении испытательного срока.
        /// </summary>
        /// <remarks>
        /// Футболочка, толстовочка и портфельчик.
        /// </remarks>
        ProbationPeriodEndingPack
    }
}