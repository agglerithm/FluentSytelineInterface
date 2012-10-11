namespace SytelineInterface.Dsl.Commands
{
    using Queries;

    public class UserSessionValues : IdoCommandBuilder
    {
        public UserSessionValues( ) : base(UserSession.IDO_NAME)
        {
        }

        public UserSessionValues ConnectionID(string value)
        {
            AddValue(UserSession.ConnectionID, value);
            return this;
        }
    }
}