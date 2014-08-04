﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ActionMailer.Net.Interfaces;
using ActionMailer.Net.Mvc5_2;

namespace TestProject.Controllers
{
    public class HomeController : MailerBase
    {
        public EmailResult TestEmail()
        {
            MailAttributes.FromAddress = new MailAddress("dodohani@gmail.com");
            MailAttributes.To.Add(new MailAddress("a.kamel@crossvertise.com"));
            MailAttributes.Subject = "It might work";

            return Email("View");
        }

        public async Task<ActionResult> TestAsync()
        {
            await this.TestEmail().DeliverAsync();
            return null;

        }

        public ActionResult TestSync()
        {
            this.TestEmail().Deliver();
            return null;
        }
    }
}