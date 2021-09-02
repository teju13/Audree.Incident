using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Audree.Incident.Infrastructure.ToDo
{
    public class CommonEnum
    {
        public enum Messages
        {
            [Display(Name = "Created Successfully")]
            CustomCreated,
            [Display(Name = "Already Exists")]
            AlreadyExists,
            [Display(Name = "Updated Successfully")]
            CustomUpdated,
            [Display(Name = "Saved Successfully.")]
            Saved,
            [Display(Name = "Deleted Successfully.")]
            Deleted,
            [Display(Name = "No changes found.")]
            Nochanges,
            [Display(Name = "No Data found.")]
            Nodatafound,
            [Display(Name = "Unable to Save")]
            UnabletoSave,
            [Display(Name = "Initated Sucessfully.")]
            InitatedSucess,
            [Display(Name = "Records Processed.")]
            RecordsProcessed,
            [Display(Name = "Ok")]
            Ok,
            [Display(Name = "Success")]
            Success,
            [Display(Name = "Fail")]
            Fail,
            [Display(Name = "Removed Successfully")]
            CustomRemoved,
            [Display(Name = "User Not Available")]
            UserNotAvailable,
        }
        public enum EnumUserActionsDBValue
        {
            [Display(Name = "Created")]
            Created = 1,
            [Display(Name = "Modified")]
            Modified = 2,
            [Display(Name = "Enabled")]
            Enabled = 3,
            [Display(Name = "Released")]
            Released = 4,
            [Display(Name = "Standard Data")]
            Standard = 5,
            [Display(Name = "Disabled")]
            Disabled = 6,
            [Display(Name = "Blocked")]
            Blocked = 7,
            [Display(Name = "Permanent Disabled")]
            PermanentDisable = 8,
            [Display(Name = "Update Permanent Disabled")]
            UpdatePermanentDisable = 9,
            [Display(Name = "Approved")]
            Approved = 9,
            [Display(Name = "Reviewed")]
            Reviewed = 9,

            [Display(Name = "Returned")]
            Returned = 12,
            [Display(Name = "Rejected")]
            Rejected = 13,

            [Display(Name = "Closed")]
            Closed = 14,
            [Display(Name = "Deleted")]
            Deleted = 1,
        }
    }
}
