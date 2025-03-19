namespace Shamilova_ObrazPlus.Services
{
    /// <summary>
    /// Хранение лобальных переменных.
    /// </summary>
    public static class GlobalVariablesClass
    {
        /// <summary>
        /// Роль пользователя.
        /// </summary>
        public static string CurrentJobTitleOfEmployee{ get; set; } = JobTitlesClass.Guest;

    }
}
