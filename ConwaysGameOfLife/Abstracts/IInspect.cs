namespace ConwaysGameOfLife.Abstracts
{
    /// <summary>
    /// Represents an interface to inject a flag which indicates whether an object gets inspected
    /// </summary>
    internal interface IInspect
    {
        /// <summary>
        /// Indicates whether current object gets inspected
        /// </summary>
        public bool GetsInspected { get; set; }
    }
}
