namespace SytelineInterface.Dsl.Queries
{
    using System;
    using Commands;
    using Core;

    public class UserSession : IdoConstants
    {
        public const string IDO_NAME = "ConnectionInformations";

        public const string ConnectionID = "ConnectionID";

        public const string CreateDate = "CreateDate";

        public const string CreatedBy = "CreatedBy";

        public const string InWorkflow = "InWorkflow";

        public const string NoteExists = "NoteExistsFlag";

        public const string RecordDate = "RecordDate";

        public const string RowPointer = "RowPointer";

        public const string Selected = "UbSelected";

        public const string UpdatedBy = "UpdatedBy";

        public const string UserName = "UserName";
    }
    public class UserSessionBuilder : IdoQueryBuilder<UserSessionBuilder, UserSessionExpressionBuilder>
    {
 

        public UserSessionBuilder(ExpressionInterpreter expression) : base(UserSession.IDO_NAME, expression)
        { 
        }

        public UserSessionBuilder ConnectionID { get { AddProperty(UserSession.ConnectionID); return this; } }
        public UserSessionBuilder CreateDate { get { AddProperty(UserSession.CreateDate); return this; } }
        public UserSessionBuilder CreatedBy { get { AddProperty(UserSession.CreatedBy); return this; } }
        public UserSessionBuilder InWorkflow { get { AddProperty(UserSession.InWorkflow); return this; } }
        public UserSessionBuilder NoteExists { get { AddProperty(UserSession.NoteExists); return this; } }
        public UserSessionBuilder RecordDate { get { AddProperty(UserSession.RecordDate); return this; } } 
        public UserSessionBuilder Selected { get { AddProperty(UserSession.Selected); return this; } }
        public UserSessionBuilder UpdatedBy { get { AddProperty(UserSession.UpdatedBy); return this; } }
        public UserSessionBuilder UserName { get { AddProperty(UserSession.UserName); return this; } }
    }

    public class UserSessionExpressionBuilder : FilterExpressionBuilder<UserSessionBuilder>
    {
    }
}