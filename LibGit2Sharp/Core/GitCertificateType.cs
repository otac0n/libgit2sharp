namespace LibGit2Sharp.Core
{
    /// <summary>
    /// Git certificate types to present to the user
    /// </summary>
    internal enum GitCertificateType
    {
        /// <summary>
        /// The certificate is a x509 certificate
        /// </summary>
        X509 = 0,
        /// <summary>
        /// The "certificate" is in fact a hostkey identification for ssh.
        /// </summary>
        Hostkey = 1,
    }
}
