namespace LealPassword.Extensions
{
    internal enum OrderType
    {
        /// <summary>
        /// Sort by register name
        /// </summary>
        Default,
        /// <summary>
        /// Sort by register name in reverse
        /// </summary>
        InverseDefault,
        /// <summary>
        /// Sort by username
        /// </summary>
        Username,
        /// <summary>
        /// Sort by username in reverse
        /// </summary>
        InverseUsername, 
        /// <summary>
        /// Sort by email
        /// </summary>
        Email,
        /// <summary>
        /// Sort by email in reverse
        /// </summary>
        InverseEmail,
        /// <summary>
        /// Sort by tag
        /// </summary>
        Tag,
        /// <summary>
        /// Sort by tag in reverse
        /// </summary>
        InverseTag,
    }
}
