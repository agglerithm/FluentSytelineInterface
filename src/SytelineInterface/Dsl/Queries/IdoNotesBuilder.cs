using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    public class Notes : IdoConstants
    {
        public const string IDO_NAME = "SLObjectNotes";
        public const string CreateDate = "CreateDate";
        public const string CreatedBy = "CreatedBy";
        public const string DerContent = "DerContent";
        public const string DerDesc = "DerDesc";
        public const string DerOrigin = "DerOrigin";
        public const string DerReusable = "DerReusable";
        public const string DerSystem = "DerSystem";
        public const string DerType = "DerType";
        public const string InWorkflow = "InWorkflow";
        public const string NhNoteFlag = "NhNoteFlag";
        public const string NhObjectName = "NhObjectName";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string NoteHeaderToken = "NoteHeaderToken";
        public const string NoteType = "NoteType";
        public const string ObjectNoteToken = "ObjectNoteToken";
        public const string RecordDate = "RecordDate";
        public const string RefRowPointer = "RefRowPointer";
        public const string RowPointer = "RowPointer";
        public const string SpcnNoteContent = "SpcnNoteContent";
        public const string SpcnNoteDesc = "SpcnNoteDesc";
        public const string SpecificNoteToken = "SpecificNoteToken";
        public const string SysnNoteContent = "SysnNoteContent";
        public const string SysnNoteDesc = "SysnNoteDesc";
        public const string SystemNoteToken = "SystemNoteToken";
        public const string UBRefRowPointer = "UBRefRowPointer";
        public const string UBTableName = "UBTableName";
        public const string UpdatedBy = "UpdatedBy";
        public const string UserNoteToken = "UserNoteToken";
        public const string UsrnNoteContent = "UsrnNoteContent";
        public const string UsrnNoteDesc = "UsrnNoteDesc";


    }

    public class NotesBuilder
        : IdoQueryBuilder<NotesBuilder, SLObjectNotesFilterExpressionBuilder>
    {
        public NotesBuilder(IExpressionInterpreter interpreter) : base(Notes.IDO_NAME, interpreter) { }

        public NotesBuilder CreateDate { get { AddProperty(Notes.CreateDate); return this; } }
        public NotesBuilder CreatedBy { get { AddProperty(Notes.CreatedBy); return this; } }
        public NotesBuilder DerContent { get { AddProperty(Notes.DerContent); return this; } }
        public NotesBuilder DerDesc { get { AddProperty(Notes.DerDesc); return this; } }
        public NotesBuilder DerOrigin { get { AddProperty(Notes.DerOrigin); return this; } }
        public NotesBuilder DerReusable { get { AddProperty(Notes.DerReusable); return this; } }
        public NotesBuilder DerSystem { get { AddProperty(Notes.DerSystem); return this; } }
        public NotesBuilder DerType { get { AddProperty(Notes.DerType); return this; } }
        public NotesBuilder InWorkflow { get { AddProperty(Notes.InWorkflow); return this; } }
        public NotesBuilder NhNoteFlag { get { AddProperty(Notes.NhNoteFlag); return this; } }
        public NotesBuilder NhObjectName { get { AddProperty(Notes.NhObjectName); return this; } }
        public NotesBuilder NoteExistsFlag { get { AddProperty(Notes.NoteExistsFlag); return this; } }
        public NotesBuilder NoteHeaderToken { get { AddProperty(Notes.NoteHeaderToken); return this; } }
        public NotesBuilder NoteType { get { AddProperty(Notes.NoteType); return this; } }
        public NotesBuilder ObjectNoteToken { get { AddProperty(Notes.ObjectNoteToken); return this; } }
        public NotesBuilder RecordDate { get { AddProperty(Notes.RecordDate); return this; } }
        public NotesBuilder RefRowPointer { get { AddProperty(Notes.RefRowPointer); return this; } } 
        public NotesBuilder SpcnNoteContent { get { AddProperty(Notes.SpcnNoteContent); return this; } }
        public NotesBuilder SpcnNoteDesc { get { AddProperty(Notes.SpcnNoteDesc); return this; } }
        public NotesBuilder SpecificNoteToken { get { AddProperty(Notes.SpecificNoteToken); return this; } }
        public NotesBuilder SysnNoteContent { get { AddProperty(Notes.SysnNoteContent); return this; } }
        public NotesBuilder SysnNoteDesc { get { AddProperty(Notes.SysnNoteDesc); return this; } }
        public NotesBuilder SystemNoteToken { get { AddProperty(Notes.SystemNoteToken); return this; } }
        public NotesBuilder UBRefRowPointer { get { AddProperty(Notes.UBRefRowPointer); return this; } }
        public NotesBuilder UBTableName { get { AddProperty(Notes.UBTableName); return this; } }
        public NotesBuilder UpdatedBy { get { AddProperty(Notes.UpdatedBy); return this; } }
        public NotesBuilder UserNoteToken { get { AddProperty(Notes.UserNoteToken); return this; } }
        public NotesBuilder UsrnNoteContent { get { AddProperty(Notes.UsrnNoteContent); return this; } }
        public NotesBuilder UsrnNoteDesc { get { AddProperty(Notes.UsrnNoteDesc); return this; } }


    }

    public class SLObjectNotesFilterExpressionBuilder
        : FilterExpressionBuilder<NotesBuilder>
    {
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> CreateDate
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.CreateDate); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> CreatedBy
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.CreatedBy); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> DerContent
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.DerContent); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> DerDesc
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.DerDesc); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> DerOrigin
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.DerOrigin); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> DerReusable
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.DerReusable); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> DerSystem
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.DerSystem); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> DerType
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.DerType); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.InWorkflow); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> NhNoteFlag
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.NhNoteFlag); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> NhObjectName
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.NhObjectName); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.NoteExistsFlag); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> NoteHeaderToken
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.NoteHeaderToken); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> NoteType
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.NoteType); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> ObjectNoteToken
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.ObjectNoteToken); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.RecordDate); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> RefRowPointer
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.RefRowPointer); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.RowPointer); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> SpcnNoteContent
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.SpcnNoteContent); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> SpcnNoteDesc
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.SpcnNoteDesc); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> SpecificNoteToken
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.SpecificNoteToken); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> SysnNoteContent
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.SysnNoteContent); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> SysnNoteDesc
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.SysnNoteDesc); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> SystemNoteToken
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.SystemNoteToken); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> UBRefRowPointer
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.UBRefRowPointer); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> UBTableName
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.UBTableName); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> UpdatedBy
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.UpdatedBy); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> UserNoteToken
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.UserNoteToken); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> UsrnNoteContent
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.UsrnNoteContent); }
        }
        public FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder> UsrnNoteDesc
        {
            get { return new FilterExpression<NotesBuilder, SLObjectNotesFilterExpressionBuilder>(_builder, Notes.UsrnNoteDesc); }
        }


    }
}
