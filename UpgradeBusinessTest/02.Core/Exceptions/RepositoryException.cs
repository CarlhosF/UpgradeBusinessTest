using System;

namespace UpgradeBusinessTest._02.Core.Exceptions
{
    public  class RepositoryException : Exception
    {
        public RepositoryException(string message) : base(message)
        {

        }
    }
}
