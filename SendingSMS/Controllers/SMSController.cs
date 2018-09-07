using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SendingSMS.Controllers
{
    public class SMSController : Controller
    {
        // GET: SMS
        public ActionResult Send()
        {
            // var accountSID = ConfigurationManager.AppSettings["TwilioSID"];
            var accountSID = "AC29f489d11c6c661be530e2f5f1da34b8";

            var authTocken = "c9aec7a4e04219880a2c6cc4bc453142";

            TwilioClient.Init(accountSID, authTocken);
            var toNumber = new PhoneNumber("+15344295519");
            var fromNumber = new PhoneNumber("+18556293762");
            var message = MessageResource.Create(
                to: toNumber,
                from: fromNumber,
                body: "Hello Test SMS From Child Health Care Projects"
            );
            return Content(accountSID);
        }
    }
}