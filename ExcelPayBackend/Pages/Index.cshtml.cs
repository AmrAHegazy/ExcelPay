using ExcelPayBackend.context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ExcelPayBackend.Views
{
    public class IndexModel : PageModel
    {
        private readonly Context _ctx;
        public string merch;
        public string intent;
        public string ifram;

        public IndexModel(Context ctx)
        {
            _ctx = ctx;
        }
        public IActionResult OnGet(int IframeId, Guid ClientSecret, string MerchantPublicKey)
        {
            var merchant = _ctx.Merchants.Where(m => m.PublicKey == MerchantPublicKey).FirstOrDefault();
            if (merchant == null)
                return RedirectToPage("NotFound/NotFound");

            var intention = _ctx.Intentions.Include(x => x.ClientSecret).Where(i => i.ClientSecret.Id == ClientSecret && i.Merchant.SecretKey == merchant.SecretKey).FirstOrDefault();
            if (intention == null)
                return RedirectToPage("NotFound/NotFound");


            var IsExpired = intention.ClientSecret.CreationDate.AddMinutes(2) <= DateTime.Now
                                                                                    || intention.ClientSecret.IsUsed;
            if (IsExpired)
                return RedirectToPage("NotFound/NotFound");

            var iframe = _ctx.Iframes.Where(fr => fr.Id == IframeId).FirstOrDefault();
            if (iframe == null)
                return RedirectToPage("NotFound/NotFound");

            merch = "Merchant is :" + merchant.Name;
            intent = "Intention is:" + intention.Id;
            ifram = "iframe is:" + iframe.Name;
            return Page();
        }
    }
}