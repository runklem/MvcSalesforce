using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Salesforce.Force;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class ContactsController : Controller
    {
        // GET: /Accounts/
        public async Task<ActionResult> Index()
        {
            var accessToken = Session["AccessToken"].ToString();
            var apiVersion = Session["ApiVersion"].ToString();
            var instanceUrl = Session["InstanceUrl"].ToString();

            var client = new ForceClient(instanceUrl, accessToken, apiVersion);
            var contacts = await client.QueryAsync<ContactViewModel>("SELECT id, name, account.name, title, phone, email FROM Contact");

            return View(contacts.records);
        }
    }
}