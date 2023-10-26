using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capcity)
        {
            Capacity = capcity;
            Inbox = new();
            Archive = new();
        }

        public int Capacity { get; set; } //private set
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }


        public void IncomingMail(Mail mail)
        {
            if (Capacity >= Inbox.Count + 1)
            {
                Inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender)
        {
            Mail mailToDelete = Inbox.FirstOrDefault(x => x.Sender == sender);
            if (mailToDelete != null)
            {
                Inbox.Remove(mailToDelete);
                return true;
            }
            return false;
        }
        public int ArchiveInboxMessages()
        {
            int count = Inbox.Count;
            Archive = Inbox;
            Inbox = new();
            return count;
        }
        public string GetLongestMessage()
        {
            int longestBodyCount = Inbox.Max(x => x.Body.Length);
            Mail mailToReturn = Inbox.FirstOrDefault(x => x.Body.Length == longestBodyCount); //?
            //or 
            //Mail longestBodyCount = Inbox.MaxBy(x=> x.Body.Length);
            return mailToReturn.ToString();
        }
        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString();
        }
    }
}
