
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `completed:request[calculate:quality]` - COMPLETED:REQUEST[CALCULATE:QUALITY]<br/>
    /// * `completed:request[create:task]` - COMPLETED:REQUEST[CREATE:TASK]<br/>
    /// * `completed:request[export:annotations]` - COMPLETED:REQUEST[EXPORT:ANNOTATIONS]<br/>
    /// * `completed:request[export:backup]` - COMPLETED:REQUEST[EXPORT:BACKUP]<br/>
    /// * `completed:request[export:dataset]` - COMPLETED:REQUEST[EXPORT:DATASET]<br/>
    /// * `completed:request[merge:job]` - COMPLETED:REQUEST[MERGE:JOB]<br/>
    /// * `completed:request[merge:task]` - COMPLETED:REQUEST[MERGE:TASK]<br/>
    /// * `create:comment` - CREATE:COMMENT<br/>
    /// * `create:invitation` - CREATE:INVITATION<br/>
    /// * `create:issue` - CREATE:ISSUE<br/>
    /// * `create:job` - CREATE:JOB<br/>
    /// * `create:membership` - CREATE:MEMBERSHIP<br/>
    /// * `create:project` - CREATE:PROJECT<br/>
    /// * `create:task` - CREATE:TASK<br/>
    /// * `delete:comment` - DELETE:COMMENT<br/>
    /// * `delete:invitation` - DELETE:INVITATION<br/>
    /// * `delete:issue` - DELETE:ISSUE<br/>
    /// * `delete:job` - DELETE:JOB<br/>
    /// * `delete:membership` - DELETE:MEMBERSHIP<br/>
    /// * `delete:project` - DELETE:PROJECT<br/>
    /// * `delete:task` - DELETE:TASK<br/>
    /// * `update:comment` - UPDATE:COMMENT<br/>
    /// * `update:issue` - UPDATE:ISSUE<br/>
    /// * `update:job` - UPDATE:JOB<br/>
    /// * `update:membership` - UPDATE:MEMBERSHIP<br/>
    /// * `update:organization` - UPDATE:ORGANIZATION<br/>
    /// * `update:project` - UPDATE:PROJECT<br/>
    /// * `update:task` - UPDATE:TASK
    /// </summary>
    public enum EventsEnum
    {
        /// <summary>
        /// request[calculate:quality]` - COMPLETED:REQUEST[CALCULATE:QUALITY]
        /// </summary>
        Completed_requestcalculate_quality,
        /// <summary>
        /// request[create:task]` - COMPLETED:REQUEST[CREATE:TASK]
        /// </summary>
        Completed_requestcreate_task,
        /// <summary>
        /// request[export:annotations]` - COMPLETED:REQUEST[EXPORT:ANNOTATIONS]
        /// </summary>
        Completed_requestexport_annotations,
        /// <summary>
        /// request[export:backup]` - COMPLETED:REQUEST[EXPORT:BACKUP]
        /// </summary>
        Completed_requestexport_backup,
        /// <summary>
        /// request[export:dataset]` - COMPLETED:REQUEST[EXPORT:DATASET]
        /// </summary>
        Completed_requestexport_dataset,
        /// <summary>
        /// request[merge:job]` - COMPLETED:REQUEST[MERGE:JOB]
        /// </summary>
        Completed_requestmerge_job,
        /// <summary>
        /// request[merge:task]` - COMPLETED:REQUEST[MERGE:TASK]
        /// </summary>
        Completed_requestmerge_task,
        /// <summary>
        /// comment` - CREATE:COMMENT
        /// </summary>
        Create_comment,
        /// <summary>
        /// invitation` - CREATE:INVITATION
        /// </summary>
        Create_invitation,
        /// <summary>
        /// issue` - CREATE:ISSUE
        /// </summary>
        Create_issue,
        /// <summary>
        /// job` - CREATE:JOB
        /// </summary>
        Create_job,
        /// <summary>
        /// membership` - CREATE:MEMBERSHIP
        /// </summary>
        Create_membership,
        /// <summary>
        /// project` - CREATE:PROJECT
        /// </summary>
        Create_project,
        /// <summary>
        /// request[create:task]` - COMPLETED:REQUEST[CREATE:TASK]
        /// </summary>
        Create_task,
        /// <summary>
        /// comment` - DELETE:COMMENT
        /// </summary>
        Delete_comment,
        /// <summary>
        /// invitation` - DELETE:INVITATION
        /// </summary>
        Delete_invitation,
        /// <summary>
        /// issue` - DELETE:ISSUE
        /// </summary>
        Delete_issue,
        /// <summary>
        /// job` - DELETE:JOB
        /// </summary>
        Delete_job,
        /// <summary>
        /// membership` - DELETE:MEMBERSHIP
        /// </summary>
        Delete_membership,
        /// <summary>
        /// project` - DELETE:PROJECT
        /// </summary>
        Delete_project,
        /// <summary>
        /// task` - DELETE:TASK
        /// </summary>
        Delete_task,
        /// <summary>
        /// comment` - UPDATE:COMMENT
        /// </summary>
        Update_comment,
        /// <summary>
        /// issue` - UPDATE:ISSUE
        /// </summary>
        Update_issue,
        /// <summary>
        /// job` - UPDATE:JOB
        /// </summary>
        Update_job,
        /// <summary>
        /// membership` - UPDATE:MEMBERSHIP
        /// </summary>
        Update_membership,
        /// <summary>
        /// organization` - UPDATE:ORGANIZATION
        /// </summary>
        Update_organization,
        /// <summary>
        /// project` - UPDATE:PROJECT
        /// </summary>
        Update_project,
        /// <summary>
        /// task` - UPDATE:TASK
        /// </summary>
        Update_task,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsEnum value)
        {
            return value switch
            {
                EventsEnum.Completed_requestcalculate_quality => "completed:request[calculate:quality]",
                EventsEnum.Completed_requestcreate_task => "completed:request[create:task]",
                EventsEnum.Completed_requestexport_annotations => "completed:request[export:annotations]",
                EventsEnum.Completed_requestexport_backup => "completed:request[export:backup]",
                EventsEnum.Completed_requestexport_dataset => "completed:request[export:dataset]",
                EventsEnum.Completed_requestmerge_job => "completed:request[merge:job]",
                EventsEnum.Completed_requestmerge_task => "completed:request[merge:task]",
                EventsEnum.Create_comment => "create:comment",
                EventsEnum.Create_invitation => "create:invitation",
                EventsEnum.Create_issue => "create:issue",
                EventsEnum.Create_job => "create:job",
                EventsEnum.Create_membership => "create:membership",
                EventsEnum.Create_project => "create:project",
                EventsEnum.Create_task => "create:task",
                EventsEnum.Delete_comment => "delete:comment",
                EventsEnum.Delete_invitation => "delete:invitation",
                EventsEnum.Delete_issue => "delete:issue",
                EventsEnum.Delete_job => "delete:job",
                EventsEnum.Delete_membership => "delete:membership",
                EventsEnum.Delete_project => "delete:project",
                EventsEnum.Delete_task => "delete:task",
                EventsEnum.Update_comment => "update:comment",
                EventsEnum.Update_issue => "update:issue",
                EventsEnum.Update_job => "update:job",
                EventsEnum.Update_membership => "update:membership",
                EventsEnum.Update_organization => "update:organization",
                EventsEnum.Update_project => "update:project",
                EventsEnum.Update_task => "update:task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed:request[calculate:quality]" => EventsEnum.Completed_requestcalculate_quality,
                "completed:request[create:task]" => EventsEnum.Completed_requestcreate_task,
                "completed:request[export:annotations]" => EventsEnum.Completed_requestexport_annotations,
                "completed:request[export:backup]" => EventsEnum.Completed_requestexport_backup,
                "completed:request[export:dataset]" => EventsEnum.Completed_requestexport_dataset,
                "completed:request[merge:job]" => EventsEnum.Completed_requestmerge_job,
                "completed:request[merge:task]" => EventsEnum.Completed_requestmerge_task,
                "create:comment" => EventsEnum.Create_comment,
                "create:invitation" => EventsEnum.Create_invitation,
                "create:issue" => EventsEnum.Create_issue,
                "create:job" => EventsEnum.Create_job,
                "create:membership" => EventsEnum.Create_membership,
                "create:project" => EventsEnum.Create_project,
                "create:task" => EventsEnum.Create_task,
                "delete:comment" => EventsEnum.Delete_comment,
                "delete:invitation" => EventsEnum.Delete_invitation,
                "delete:issue" => EventsEnum.Delete_issue,
                "delete:job" => EventsEnum.Delete_job,
                "delete:membership" => EventsEnum.Delete_membership,
                "delete:project" => EventsEnum.Delete_project,
                "delete:task" => EventsEnum.Delete_task,
                "update:comment" => EventsEnum.Update_comment,
                "update:issue" => EventsEnum.Update_issue,
                "update:job" => EventsEnum.Update_job,
                "update:membership" => EventsEnum.Update_membership,
                "update:organization" => EventsEnum.Update_organization,
                "update:project" => EventsEnum.Update_project,
                "update:task" => EventsEnum.Update_task,
                _ => null,
            };
        }
    }
}