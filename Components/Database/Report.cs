//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clientFactory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        public Report(int senderId, string sender, int recipientId, string recipient, string description, string title,
     Attachments attach = null, ReportCategory repCat = null)
        {
            Sender_ID = senderId;
            Sender = sender;
            Recipient_ID = recipientId;
            Recipient = recipient;
            Description = description;
            //add title here
            Attachment = attach;
            ReportCategory = repCat;
        }

        public int Id { get; set; }
        public int Sender_ID { get; set; }
        public string Sender { get; set; }
        public int Recipient_ID { get; set; }
        public string Recipient { get; set; }
        public System.DateTime SendDate { get; set; }
        public bool isRead { get; set; }
        public bool isMark { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    
        public virtual Attachments Attachment { get; set; }
        public virtual ReportCategory ReportCategory { get; set; }
    }
}
